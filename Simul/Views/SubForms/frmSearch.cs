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

namespace Simul.Views.SubForms
{
    public partial class frmSearch : Form, ISubForm
    {
        GameController gameController;
        PersonController personController;

        public frmSearch(GameController gameController, PersonController personController)
        {
            this.gameController = gameController;
            this.personController = personController;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            lstPersons.Items.Clear();
            foreach (Person person in personController.persons)
            {
                lstPersons.Items.Add(person.name);
            }

            lstPersons.SelectedIndex = lstPersons.FindStringExact(gameController.controlledPerson.name);
        }

        private void lstPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPerson();
        }

        private void DisplayPerson()
        {
            Person person = personController.GetPersonByName(lstPersons.SelectedItem.ToString());
            txtName.Text = person.name;
            txtMoney.Text = string.Format("{0:C}", person.Money);
            txtStrengthPanSearch.Text = person.strength.ToString();

            dlvSkills.SetObjects(person.skillset.skills);
        }
    }
}
