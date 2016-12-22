using Simul.Controllers;
using Simul.Models;
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
        Panel currentPanel;

        public frmPrincipal()
        {
            InitializeComponent();

            personController = new PersonController();
            companyController = new CompanyController();
            gameController = new GameController(personController.GetPersonByName("Keven"));

            currentPanel = panHome;
            FillPanHome();
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
            FillPanHome();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panPersons);
            FillPanPersons();
        }

        private void btnResourceMarket_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panResourceMarket);
            FillPanResourceMaket();
        }

        private void btnJobMarket_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panJobMarket);
            FillPanJobMarket();
        }

        private void FillPanHome()
        {
            txtStrength.Text = gameController.controlledPerson.DisplayStrength();
            txtProductivity.Text = gameController.controlledPerson.DisplayProductivity();
        }

        private void FillPanPersons()
        {
            lstPersons.Items.Clear();
            foreach (Person person in personController.persons)
            {
                lstPersons.Items.Add(person.name);
            }
        }

        private void FillPanResourceMaket()
        {

        }

        private void FillPanJobMarket()
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
    }
}
