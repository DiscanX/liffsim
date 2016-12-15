using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simul
{
    public partial class frmPrincipal : Form
    {
        PersonController personController;
        Panel currentPanel;

        public frmPrincipal()
        {
            InitializeComponent();
            personController = new PersonController();
            currentPanel = panHome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            personController.FillDisplayedList(lstPersons);
        }

        private void DisplayPerson()
        {
            Person person = personController.GetPersonByName(lstPersons.SelectedItem.ToString());
            txtName.Text = person.name;
            txtMoney.Text = person.DisplayMoney();
        }

        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPerson();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panHome);
        }

        private void ChangePanelTo(Panel newPanel)
        {
            if(currentPanel != newPanel)
            {
                var panelstoBeDisabled = Controls.OfType<Panel>().Where(p => p.Name != newPanel.Name);
                foreach(Panel panel in panelstoBeDisabled)
                {
                    panel.Visible = false;
                }

                newPanel.Visible = true;
                currentPanel = newPanel;
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panPersonnes);
        }

        private void tsmOptions_Click(object sender, EventArgs e)
        {

        }

        private void btnResourceMarket_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panResourceMarket);
        }

        private void btnJobMarket_Click(object sender, EventArgs e)
        {
            ChangePanelTo(panJobMarket);
        }
    }
}
