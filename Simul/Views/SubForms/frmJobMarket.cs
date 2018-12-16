using BrightIdeasSoftware;
using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmJobMarket : Form, ISubForm
    {
        FrmPrincipal _frmPrincipal;
        JobMarketController _jobMarketController;
        GameController _gameController;
        JobMarket _selectedJobMarket;

        public FrmJobMarket(FrmPrincipal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            _gameController = GameController.Instance;
            _jobMarketController = JobMarketController.Instance;

            InitializeComponent();

            olvJobs.SmallImageList = ContentReader.GetResourcesImages();
            olvJobs.ButtonClick += DlvJobs_Apply;

            olvResourceImg.ImageGetter = x => ((JobOffer)x).Employer.ProducedResource.Name.ToString();
            olvApply.AspectGetter = x => "Apply";
        }

        private void DlvJobs_Apply(object sender, CellClickEventArgs e)
        {
            var jobOffer = (JobOffer)e.Model;

            _gameController.ControlledPerson.TakeJob(_selectedJobMarket, jobOffer, _gameController.CurrentDay);

            if (_selectedJobMarket.Offers.Exists(x => x == e.Model))
            {
                olvJobs.RefreshObject(e.Model);
            }
            else
            {
                olvJobs.RemoveObject(e.Model);
            }
        }

        public void UpdateDisplay()
        {
            cboJobMarkets.Items.Clear();
            foreach (JobMarket jobMarket in _jobMarketController.Markets)
            {
                cboJobMarkets.Items.Add(jobMarket.Name);
            }
            cboJobMarkets.Text = _jobMarketController.GetMarketOfCountry(_gameController.ControlledPerson.Country.Name).Name;
        }

        private void cboJobMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedJobMarket = _jobMarketController.Markets.First(x => x.Name == cboJobMarkets.SelectedItem.ToString());
            olvJobs.SetObjects(_selectedJobMarket.Offers);
        }
    }
}
