using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmSearchCompany : Form, ISubForm
    {
        GameController _gameController;
        CompanyController _companyController;
        private object _currentSelectedItem;

        public FrmSearchCompany()
        {
            _gameController = GameController.Instance;
            _companyController = CompanyController.Instance;

            InitializeComponent();

            olvInventory.SmallImageList = ContentReader.GetResourcesImages();
            olvResourceImg.ImageGetter = x => ((KeyValuePair<Resource, int>)x).Key.Name.ToString();

            olvInventory.Sort(olvQuantity, SortOrder.Ascending);
            dlvEmployees.Sort(olvSkill, SortOrder.Descending);
        }

        public void UpdateDisplay()
        {
            lstCompanies.Items.Clear();
            foreach (ICompany company in _companyController.Companies)
            {
                lstCompanies.Items.Add(company.Name);
            }

            if (_currentSelectedItem != null)
            {
                lstCompanies.SelectedItem = _currentSelectedItem;
            }
        }

        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentSelectedItem = lstCompanies.SelectedItem;
            DisplayCompany();
        }

        private void DisplayCompany()
        {
            var company = _companyController.Companies.First(x => x.Name == lstCompanies.SelectedItem.ToString());
            picResource.Image = ContentReader.GetResourcesImages().Images[company.ProducedResource.Name.ToString()];

            txtName.Text = company.Name;
            txtMoney.Text = string.Format("{0:C}", company.Money);
            txtProgress.Text = string.Format("{0:P2}", company.Progress);
            txtCountry.Text = company.Country.Name;

            dlvEmployees.SetObjects(company.Employees);
            olvInventory.SetObjects(company.Inventory.Stocks);
        }
    }
}
