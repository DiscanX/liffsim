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
    public partial class frmSearchCompany : Form, ISubForm
    {
        GameController gameController;
        CompanyController companyController;

        public frmSearchCompany()
        {
            this.gameController = GameController.Instance;
            this.companyController = CompanyController.Instance;

            InitializeComponent();

            olvInventory.SmallImageList = ContentReader.GetResourcesImages();
            olvResourceImg.ImageGetter = delegate (object rowObject) { return ((KeyValuePair<Resource, int>)rowObject).Key.name.ToString(); };

            olvInventory.Sort(olvQuantity, SortOrder.Ascending);
            dlvEmployees.Sort(olvSkill, SortOrder.Descending);
        }

        public void UpdateDisplay()
        {
            lstCompanies.Items.Clear();
            foreach(ICompany company in companyController.companies)
            {
                lstCompanies.Items.Add(company.name);
            }

            if(gameController.controlledPerson.employer != null)
            {
                lstCompanies.SelectedIndex = lstCompanies.FindStringExact(gameController.controlledPerson.employer.name);
            }
        }

        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCompany();
        }

        private void DisplayCompany()
        {
            ICompany company = companyController.companies.First(x => x.name == lstCompanies.SelectedItem.ToString());
            picResource.Image = ContentReader.GetResourcesImages().Images[company.producedResource.name.ToString()];

            txtName.Text = company.name;
            txtMoney.Text = string.Format("{0:C}", company.Money);
            txtProgress.Text = string.Format("{0:P2}", company.progress);
            txtCountry.Text = company.country.name;

            dlvEmployees.SetObjects(company.employees);
            olvInventory.SetObjects(company.inventory.stocks);
        }
    }
}
