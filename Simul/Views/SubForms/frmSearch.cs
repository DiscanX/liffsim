using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmSearch : Form, ISubForm
    {
        GameController _gameController;
        PersonController _personController;

        public FrmSearch()
        {
            _gameController = GameController.Instance;
            _personController = PersonController.Instance;

            InitializeComponent();

            olvInventory.SmallImageList = ContentReader.GetResourcesImages();
            olvResourceImg.ImageGetter = x => ((KeyValuePair<Resource, int>)x).Key.Name.ToString();
        }

        public void UpdateDisplay()
        {
            lstPersons.Items.Clear();
            foreach (IPerson person in _personController.Persons)
            {
                lstPersons.Items.Add(person.Name);
            }

            lstPersons.SelectedIndex = lstPersons.FindStringExact(_gameController.ControlledPerson.Name);
        }

        private void lstPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPerson();
        }

        private void DisplayPerson()
        {
            var person = _personController.Persons.First(x => x.Name == lstPersons.SelectedItem.ToString());

            txtName.Text = person.Name;
            txtMoney.Text = string.Format("{0:C}", person.Money);
            txtCountry.Text = person.Country.Name;
            txtStrengthPanSearch.Text = person.Strength.ToString();

            dlvSkills.SetObjects(person.Skillset.Skills);
            olvInventory.SetObjects(person.Inventory.Stocks);
        }
    }
}
