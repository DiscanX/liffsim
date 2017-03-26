using BrightIdeasSoftware;
using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
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

            personController.persons.Add(new Person("Keven", 10, new Skillset(), new Inventory(), 100, 5, true));
            personController.persons.Add(new Person("Noèmie", 10, new Skillset(), new Inventory(), 100, 5));
            personController.persons.Add(new Person("John", 10, new Skillset(), new Inventory(), 100, 5));
            personController.persons.Add(new Person("Peter", 10, new Skillset(), new Inventory(), 100, 5));
            personController.persons.Add(new Person("Chris", 10, new Skillset(), new Inventory(), 100, 5));

            companyController.companies.Add(new Company("Sample Company", ContentReader.GetResources()[(int)eResourceName.wheat], 100, new Inventory()));
            companyController.companies.Add(new Company("World Company", ContentReader.GetResources()[(int)eResourceName.iron], 10000, new Inventory()));
            companyController.companies[0].employees.Add(personController.persons[0]);

            resourceMarketController.markets.Add(new ResourceMarket("Main resource market", new List<ResourceOffer>()));
            resourceMarketController.markets.Add(new ResourceMarket("Secondary resource market", new List<ResourceOffer>()));
            resourceMarketController.markets[0].offers.Add(new ResourceOffer(personController.persons[1], personController.persons[1].inventory.stocks.First().Key, 50, 1));
            resourceMarketController.markets[0].offers.Add(new ResourceOffer(personController.persons[2], personController.persons[2].inventory.stocks.Last().Key, 27, 110.50m));

            jobMarketController.markets.Add(new JobMarket("Main job market", new List<JobOffer>()));
            jobMarketController.markets[0].offers.Add(new JobOffer(companyController.companies[0], 5m));
            jobMarketController.markets[0].offers.Add(new JobOffer(companyController.companies[1], 7m));

            gameController.controlledPerson = personController.persons.First(x => x.name == "Keven");
            gameController.controlledPerson.employer = companyController.companies[0];
            gameController.controlledPerson.salary = 5.50m;

            Random rnd = new Random();
            for(int i = 0; i < 4; i++)
            {
                int interestInEconomy = rnd.Next(0, 101);
                gameController.bots.Add(new SimplePersonBot(personController.persons[i + 1], rnd.Next(1, 101), interestInEconomy, 100 - interestInEconomy, rnd));
            }

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
