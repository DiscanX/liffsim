using Simul.Controllers;
using Simul.Helpers;
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

        public frmSearch()
        {
            this.gameController = GameController.Instance;
            this.personController = PersonController.Instance;

            InitializeComponent();

            olvInventory.SmallImageList = ContentReader.GetResourcesImages();
            olvResourceImg.ImageGetter = delegate (object rowObject) { return ((KeyValuePair<Resource, int>)rowObject).Key.name.ToString(); };
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
            Person person = personController.persons.First(x => x.name == lstPersons.SelectedItem.ToString());
            txtName.Text = person.name;
            txtMoney.Text = string.Format("{0:C}", person.Money);
            txtStrengthPanSearch.Text = person.strength.ToString();

            dlvSkills.SetObjects(person.skillset.skills);
            olvInventory.SetObjects(person.inventory.stocks);
        }
    }
}
