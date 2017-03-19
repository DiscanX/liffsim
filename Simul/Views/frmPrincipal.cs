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

        Form currentSubForm;

        public frmPrincipal()
        {
            InitializeComponent();

            personController = new PersonController();
            companyController = new CompanyController();
            gameController = new GameController(personController.persons.First(x => x.name == "Keven"));
            resourceMarketController = new ResourceMarketController();
            jobMarketController = new JobMarketController();

            frmHome = new frmHome(this, gameController);
            frmJobMarket = new frmJobMarket(this, gameController, jobMarketController);
            frmResourceMarket = new frmResourceMarket(this, gameController, resourceMarketController);
            frmSearch = new frmSearch(gameController, personController);
            frmSearchCompany = new frmSearchCompany(gameController, companyController);

            resourceMarketController.markets[0].offers.Add(new ResourceOffer(personController.persons[1], personController.persons[1].inventory.stocks.First().Key, 50, 1));
            resourceMarketController.markets[0].offers.Add(new ResourceOffer(personController.persons[2], personController.persons[2].inventory.stocks.Last().Key, 27, 110.50m));

            gameController.controlledPerson.employer = companyController.companies[0];
            gameController.controlledPerson.salary = 5.50m;
            companyController.companies[0].employees.Add(gameController.controlledPerson);

            jobMarketController.markets[0].offers.Add(new JobOffer(companyController.companies[0], 5m));
            jobMarketController.markets[0].offers.Add(new JobOffer(companyController.companies[1], 7m));

            SetupMainPanels();

            SetCurrentSubForm(frmHome);
            ReloadMenu();
        }

        private void SetupMainPanels()
        {
            frmHome.TopLevel = frmJobMarket.TopLevel = frmResourceMarket.TopLevel = frmSearch.TopLevel = frmSearchCompany.TopLevel = false;
            frmHome.Dock = frmJobMarket.Dock = frmResourceMarket.Dock = frmSearch.Dock = frmSearchCompany.Dock = DockStyle.Fill;

            panMain.Controls.Add(frmHome);
            panMain.Controls.Add(frmJobMarket);
            panMain.Controls.Add(frmResourceMarket);
            panMain.Controls.Add(frmSearch);
            panMain.Controls.Add(frmSearchCompany);

            foreach (Control control in panMain.Controls)
            {
                control.Visible = false;
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
    }
}
