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

        Form currentSubForm;

        public frmPrincipal()
        {
            InitializeComponent();

            personController = new PersonController();
            companyController = new CompanyController();
            gameController = new GameController(personController.GetPersonByName("Keven"));
            resourceMarketController = new ResourceMarketController();
            jobMarketController = new JobMarketController();

            frmHome = new frmHome(this, gameController);
            frmJobMarket = new frmJobMarket(jobMarketController);
            frmResourceMarket = new frmResourceMarket(this, gameController, resourceMarketController);
            frmSearch = new frmSearch(gameController, personController);

            resourceMarketController.markets[0].AddOffer(new ResourceOffer(resourceMarketController.markets[0], personController.persons[1], personController.persons[1].inventory.stocks.First().Key, 50, 1));
            resourceMarketController.markets[0].AddOffer(new ResourceOffer(resourceMarketController.markets[0], personController.persons[2], personController.persons[2].inventory.stocks.Last().Key, 27, 110.50m));

            SetupMainPanels();

            SetCurrentSubForm(frmHome);
            ReloadMenu();
        }

        private void SetupMainPanels()
        {
            frmHome.TopLevel = frmJobMarket.TopLevel = frmResourceMarket.TopLevel = frmSearch.TopLevel = false;
            frmHome.Dock = frmJobMarket.Dock = frmResourceMarket.Dock = frmSearch.Dock = DockStyle.Fill;

            panMain.Controls.Add(frmHome);
            panMain.Controls.Add(frmJobMarket);
            panMain.Controls.Add(frmResourceMarket);
            panMain.Controls.Add(frmSearch);

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

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmSearch);
        }

        private void btnResourceMarket_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmResourceMarket);
        }

        private void btnJobMarket_Click(object sender, EventArgs e)
        {
            SetCurrentSubForm(frmJobMarket);
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
    }
}
