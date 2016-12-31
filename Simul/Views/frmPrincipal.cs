using BrightIdeasSoftware;
using Simul.Controllers;
using Simul.Models;
using Simul.Properties;
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
        Panel currentPanel;

        public frmPrincipal()
        {
            InitializeComponent();

            personController = new PersonController();
            companyController = new CompanyController();
            gameController = new GameController(personController.GetPersonByName("Keven"));
            resourceMarketController = new ResourceMarketController();
            jobMarketController = new JobMarketController();

            currentPanel = panHome;
            ReloadPanHome();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtControlledPerson.Text = gameController.controlledPerson.name;
        }

        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPerson();
        }

        private void DisplayPerson()
        {
            Person person = personController.GetPersonByName(lstPersons.SelectedItem.ToString());
            txtName.Text = person.name;
            txtMoney.Text = person.DisplayMoney();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panHome);
            ReloadPanHome();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panPersons);
            ReloadPanPersons();
        }

        private void btnResourceMarket_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panResourceMarket);
            ReloadPanResourceMaket();
        }

        private void btnJobMarket_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panJobMarket);
            ReloadPanJobMarket();
        }

        private void ReloadPanHome()
        {
            txtStrength.Text = gameController.controlledPerson.DisplayStrength();
            txtProductivity.Text = gameController.controlledPerson.DisplayProductivity();

            btnWork.Enabled = (gameController.controlledPerson.contract != null);
        }

        private void ReloadPanPersons()
        {
            lstPersons.Items.Clear();
            foreach (Person person in personController.persons)
            {
                lstPersons.Items.Add(person.name);
            }
        }

        private void ReloadPanResourceMaket()
        {
            List<ResourceOffer> testR = new List<ResourceOffer>();
            testR.Add(new ResourceOffer(resourceMarketController.markets[0], personController.persons[0], personController.persons[0].inventory.stocks.First().Key, 5, 10));
            testR.Add(new ResourceOffer(resourceMarketController.markets[0], personController.persons[0], personController.persons[0].inventory.stocks.Last().Key, 27, 5.50m));

            ImageList imageList = new ImageList();
            imageList.Images.Add("wheat", Resources.wheat);
            imageList.Images.Add("iron", Resources.iron);
            imageList.Images.Add("bread", Resources.bread);
            imageList.Images.Add("weapon", Resources.weapon);
            imageList.ImageSize = new Size(50, 50);
            imageList.ColorDepth = ColorDepth.Depth24Bit;

            dlvResources.SmallImageList = imageList;

            olvImgResource.ImageGetter = delegate (object rowObject) { return ((ResourceOffer)rowObject).resource.name; };
            dlvResources.SetObjects(testR);
        }

        private void ReloadPanJobMarket()
        {

        }

        private void ChangePanelTo(Panel newPanel)
        {
            if (currentPanel != newPanel)
            {
                var panelstoBeDisabled = Controls.OfType<Panel>().Where(p => p.Name != newPanel.Name);
                foreach (Panel panel in panelstoBeDisabled)
                {
                    panel.Visible = false;
                }

                newPanel.Visible = true;
                currentPanel = newPanel;
            }
        }

        private void tsmOptions_Click(object sender, EventArgs e)
        {

        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            gameController.controlledPerson.Train();
            ReloadPanHome();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            gameController.controlledPerson.Work();
            ReloadPanHome();
        }
    }
}
