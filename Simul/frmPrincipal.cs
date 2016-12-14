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
            personController.FillDisplayedList(lstPersonnes);
        }

        private void DisplayPerson()
        {
            Person person = personController.GetPersonByName(lstPersonnes.SelectedItem.ToString());
            txtNom.Text = person.name;
            txtMonnaie.Text = person.DisplayMoney();
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
                currentPanel.Visible = false;
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
    }
}
