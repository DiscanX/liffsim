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
    public partial class frmSearchCompany : Form, ISubForm
    {
        GameController gameController;
        CompanyController companyController;

        public frmSearchCompany(GameController gameController, CompanyController companyController)
        {
            this.gameController = gameController;
            this.companyController = companyController;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            lstCompanies.Items.Clear();
            foreach(Company company in companyController.companies)
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
            Company company = companyController.companies.First(x => x.name == lstCompanies.SelectedItem.ToString());
            txtName.Text = company.name;
        }
    }
}
