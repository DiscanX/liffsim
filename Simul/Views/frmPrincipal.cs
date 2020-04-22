using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using Simul.Models.Bots;
using Simul.Models.Decorators;
using Simul.Models.Factories;
using Simul.Views.SubForms;
using Simul.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace Simul.Views
{
    public partial class FrmPrincipal : Form
    {
        private readonly GameController _gameController;
        private readonly CountryController _countryController;
        private readonly PersonController _personController;
        private readonly CompanyController companyController;
        private readonly ResourceMarketController _resourceMarketController;
        private readonly JobMarketController _jobMarketController;
        private readonly FrmHome _frmHome;
        private readonly FrmJobMarket _frmJobMarket;
        private readonly FrmResourceMarket _frmResourceMarket;
        private readonly FrmSearch _frmSearch;
        private readonly FrmSearchCompany _frmSearchCompany;
        private readonly FrmBots _frmBots;
        private Form _currentSubForm;

        public FrmPrincipal()
        {
            InitializeComponent();

            _countryController = CountryController.Instance;
            _personController = PersonController.Instance;
            companyController = CompanyController.Instance;
            _resourceMarketController = ResourceMarketController.Instance;
            _jobMarketController = JobMarketController.Instance;
            _gameController = GameController.Instance;

            //Temporary Country Creator
            _countryController.Countries.Add(new Country("Alpha"));
            _countryController.Countries.Add(new Country("Beta"));
            _countryController.Countries.Add(new Country("Gamma"));
            _countryController.Countries.Add(new Country("Delta"));
            _countryController.Countries.Add(new Country("Epsilon"));

            var rnd = new Random();

            //Temporary Person Creator
            var controlledPerson = PersonFactory.Create(rnd);
            controlledPerson.Name = "Keven";
            controlledPerson.Country = _countryController.Countries.Last();

            _personController.Persons.Add(controlledPerson);
            _gameController.ControlledPerson = controlledPerson;

            for (int i = 0; i < 150; i++)
            {
                var person = PersonFactory.Create(rnd);
                _personController.Persons.Add(person);

                var SPBot = BotFactory.CreateSimplePersonBot(rnd, person);
                _gameController.Bots.Add(SPBot);
            }

            //Temporary Markets Creator
            for (int i = 0; i < 5; i++)
            {
                var ressourceMarket = new ResourceMarket(_countryController.Countries[i].Name + " Resource Market", _countryController.Countries[i], new List<ResourceOffer>());
                _resourceMarketController.Markets.Add(ressourceMarket);

                var jobMarket = new JobMarket(_countryController.Countries[i].Name + " Job Market", _countryController.Countries[i], new List<JobOffer>());
                _jobMarketController.Markets.Add(jobMarket);
            }

            //Temporary Company Creator
            int companyNumber = 1;
            foreach (var country in _countryController.Countries)
            {
                foreach (var resource in Enum.GetValues(typeof(ResourceName)) as IEnumerable<ResourceName>)
                {
                    var name = "Company " + companyNumber;

                    var resourcesCount = Enum.GetValues(typeof(ResourceName)).Length;
                    var producedResource = ContentReader.GetResources().First(x => x.Name == resource);

                    var decoratedCompany = new Company(name, country, producedResource, 1000 * producedResource.ProductionCost, new Inventory());
                    var company = new CompanyDecorator(decoratedCompany);

                    var passion = rnd.Next(1, 101);
                    var greediness = rnd.Next(0, 101);
                    var stability = rnd.Next(0, 101);
                    var SCBot = new SimpleCompanyBot(company, 100, greediness, stability, rnd);

                    companyController.Companies.Add(company);
                    _gameController.Bots.Add(SCBot);
                    companyNumber++;
                }
            }

            foreach (JobMarket market in _jobMarketController.Markets)
            {
                foreach (ICompany company in companyController.Companies)
                {
                    if (company.Country.Name == market.Country.Name)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            market.Offers.Add(new JobOffer(company, 1m));
                        }
                    }
                }
            }

            _frmHome = new FrmHome(this);
            _frmJobMarket = new FrmJobMarket(this);
            _frmResourceMarket = new FrmResourceMarket(this);
            _frmSearch = new FrmSearch();
            _frmSearchCompany = new FrmSearchCompany();
            _frmBots = new FrmBots();

            SetupMainPanels();

            SetCurrentSubForm(_frmHome);
            ReloadMenu();
        }

        private void SetupMainPanels()
        {
            var subforms = new List<ISubForm>
            {
                _frmHome,
                _frmJobMarket,
                _frmResourceMarket,
                _frmSearch,
                _frmSearchCompany,
                _frmBots
            };

            foreach (Form subForm in subforms)
            {
                subForm.TopLevel = false;
                subForm.Dock = DockStyle.Fill;
                subForm.Visible = false;
                panMain.Controls.Add(subForm);
            }
        }

        private void SetCurrentSubForm(Form subForm)
        {
            if (_currentSubForm != null)
            {
                _currentSubForm.Visible = false;
            }

            _currentSubForm = subForm;
            _currentSubForm.Visible = true;
            ((ISubForm)_currentSubForm).UpdateDisplay();
        }

        public void ReloadMenu()
        {
            txtMoney.Text = string.Format("{0:C}", _gameController.ControlledPerson.Money);
            txtEnergy.Text = "Energy : " + _gameController.ControlledPerson.Energy + "%";
            txtCurrentDay.Text = "Day " + _gameController.CurrentDay;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(_frmHome);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            _gameController.ForwardDays(_personController.Persons);
            ReloadMenu();
            ((ISubForm)_currentSubForm).UpdateDisplay();
        }

        private void tsmOptions_Click(object sender, EventArgs e)
        {

        }

        private void tsmSearchPerson_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(_frmSearch);
        }

        private void tsmSearchCompany_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(_frmSearchCompany);
        }

        private void tsmResourceMarket_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(_frmResourceMarket);
        }

        private void tsmJobMarket_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(_frmJobMarket);
        }

        private void btnBots_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(_frmBots);
        }

        private void tsmStatsGeneral_Click(object sender, EventArgs e)
        {
            var statsWindow = new GeneralStats();
            ElementHost.EnableModelessKeyboardInterop(statsWindow);
            statsWindow.Show();
        }
    }
}
