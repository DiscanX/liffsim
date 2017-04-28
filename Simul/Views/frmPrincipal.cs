using BrightIdeasSoftware;
using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using Simul.Models.Bots;
using Simul.Models.Decorators;
using Simul.Properties;
using Simul.Views.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simul.Views
{
    public partial class frmPrincipal : Form
    {
        GameController gameController;
        CountryController countryController;
        PersonController personController;
        CompanyController companyController;
        ResourceMarketController resourceMarketController;
        JobMarketController jobMarketController;

        frmHome frmHome;
        frmJobMarket frmJobMarket;
        frmResourceMarket frmResourceMarket;
        frmSearch frmSearch;
        frmSearchCompany frmSearchCompany;
        frmBots frmBots;

        Form currentSubForm;

        public frmPrincipal()
        {
            InitializeComponent();

            countryController = CountryController.Instance;
            personController = PersonController.Instance;
            companyController = CompanyController.Instance;
            resourceMarketController = ResourceMarketController.Instance;
            jobMarketController = JobMarketController.Instance;
            gameController = GameController.Instance;

            frmHome = new frmHome(this);
            frmJobMarket = new frmJobMarket(this);
            frmResourceMarket = new frmResourceMarket(this);
            frmSearch = new frmSearch();
            frmSearchCompany = new frmSearchCompany();
            frmBots = new frmBots();

            countryController.countries.Add(new Country("Alpha"));
            countryController.countries.Add(new Country("Beta"));
            countryController.countries.Add(new Country("Gamma"));
            countryController.countries.Add(new Country("Delta"));
            countryController.countries.Add(new Country("Epsilon"));

            Random rnd = new Random();

            personController.persons.Add(new Person("Keven", countryController.countries.Last(), Constants.BASE_MONEY, new Skillset(), new Inventory(), Constants.BASE_ENERGY, Constants.BASE_STRENGTH));
            for(int i = 0; i < 50; i++)
            {
                string name = "Person " + (i + 1);
                Country country = countryController.countries.ElementAt(rnd.Next(0, countryController.countries.Count));
                Person decoratedPerson = new Person(name, country, Constants.BASE_MONEY, new Skillset(), new Inventory(), Constants.BASE_ENERGY, Constants.BASE_STRENGTH);
                IPerson person = new PersonDecorator(decoratedPerson);

                int passion = rnd.Next(1, 101);
                int interestInEconomy = rnd.Next(0, 101);
                int interestInMilitary = 100 - interestInEconomy;
                SimplePersonBot SPBot = new SimplePersonBot(person, PersonalityTraits.GenerateRandomPersonalityTraits(rnd), 100, interestInEconomy, interestInMilitary, rnd);

                personController.persons.Add(person);
                gameController.bots.Add(SPBot);
            }

            for(int i = 0; i < 10; i++)
            {
                string name = "Company " + (i + 1);
                Country country = countryController.countries.ElementAt(rnd.Next(0, countryController.countries.Count));
                Resource producedResource = ContentReader.GetResources().ElementAt(rnd.Next(0, ContentReader.GetResources().Count));
                Company company = new Company(name, country, producedResource, 1000, new Inventory());

                int passion = rnd.Next(1, 101);
                int greediness = rnd.Next(0, 101);
                int stability = rnd.Next(0, 101);
                SimpleCompanyBot SCBot = new SimpleCompanyBot(company, passion, greediness, stability, rnd);

                companyController.companies.Add(company);
                gameController.bots.Add(SCBot);
            }

            for(int i = 0; i < 5; i++)
            {
                resourceMarketController.markets.Add(new ResourceMarket(countryController.countries[i].name + " Resource Market", countryController.countries[i], new List<ResourceOffer>()));
                resourceMarketController.markets[0].offers.Add(new ResourceOffer(personController.persons[i], personController.persons[i].inventory.stocks.First().Key, 50, 1));
                resourceMarketController.markets[0].offers.Add(new ResourceOffer(personController.persons[i + 1], personController.persons[i + 1].inventory.stocks.Last().Key, 27, 110.50m));

                jobMarketController.markets.Add(new JobMarket(countryController.countries[i].name + " Job Market", countryController.countries[i], new List<JobOffer>()));

                jobMarketController.markets[i].offers.Add(new JobOffer(companyController.companies[i], 5m));
                jobMarketController.markets[i].offers.Add(new JobOffer(companyController.companies[i], 4m));
                jobMarketController.markets[i].offers.Add(new JobOffer(companyController.companies[i], 3m));
                jobMarketController.markets[i].offers.Add(new JobOffer(companyController.companies[i], 3m));
                jobMarketController.markets[i].offers.Add(new JobOffer(companyController.companies[i], 3m));
            }

            gameController.controlledPerson = personController.persons.First(x => x.name == "Keven");
            gameController.controlledPerson.employer = companyController.companies[0];
            gameController.controlledPerson.salary = 5.50m;

            SetupMainPanels();

            SetCurrentSubForm(frmHome);
            ReloadMenu();
        }

        private void SetupMainPanels()
        {
            List<ISubForm> subforms = new List<ISubForm>();
            subforms.Add(frmHome);
            subforms.Add(frmJobMarket);
            subforms.Add(frmResourceMarket);
            subforms.Add(frmSearch);
            subforms.Add(frmSearchCompany);
            subforms.Add(frmBots);

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
            if(currentSubForm != null)
            {
                currentSubForm.Visible = false;
            }

            currentSubForm = subForm;
            currentSubForm.Visible = true;
            ((ISubForm)currentSubForm).UpdateDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ReloadMenu()
        {
            txtMoney.Text = String.Format("{0:C}", gameController.controlledPerson.Money);
            txtEnergy.Text = "Energy : " + gameController.controlledPerson.Energy + "%";
            txtCurrentDay.Text = "Day " + gameController.currentDay;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmHome);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            gameController.ForwardDays(personController.persons);
            ReloadMenu();
            ((ISubForm)currentSubForm).UpdateDisplay();
        }

        private void tsmOptions_Click(object sender, EventArgs e)
        {

        }

        private void tsmSearchPerson_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmSearch);
        }

        private void tsmSearchCompany_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmSearchCompany);
        }

        private void tsmResourceMarket_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmResourceMarket);
        }

        private void tsmJobMarket_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmJobMarket);
        }

        private void btnBots_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmBots);
        }
    }
}
