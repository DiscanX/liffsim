using BrightIdeasSoftware;
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
    public partial class frmJobMarket : Form, ISubForm
    {
        frmPrincipal frmPrincipal;
        JobMarketController jobMarketController;
        GameController gameController;
        JobMarket selectedJobMarket;

        public frmJobMarket(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            this.gameController = GameController.Instance;
            this.jobMarketController = JobMarketController.Instance;

            InitializeComponent();

            olvJobs.SmallImageList = ContentReader.GetResourcesImages();
            olvJobs.ButtonClick += DlvJobs_Apply;

            olvResourceImg.ImageGetter = delegate (object rowObject) { return ((JobOffer)rowObject).employer.producedResource.name.ToString(); };
            olvApply.AspectGetter = delegate (object rowObject) { return "Apply"; };
        }

        private void DlvJobs_Apply(object sender, CellClickEventArgs e)
        {
            JobOffer jobOffer = (JobOffer)e.Model;

            gameController.controlledPerson.TakeJob(selectedJobMarket, jobOffer, gameController.currentDay);

            if (selectedJobMarket.offers.Exists(x => x == e.Model))
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
            foreach(JobMarket jobMarket in jobMarketController.markets)
            {
                cboJobMarkets.Items.Add(jobMarket.name);
            }
            cboJobMarkets.Text = jobMarketController.GetMarketOfCountry(gameController.controlledPerson.country.name).name;
        }

        private void cboJobMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJobMarket = jobMarketController.markets.First(x => x.name == cboJobMarkets.SelectedItem.ToString());
            olvJobs.SetObjects(selectedJobMarket.offers);
        }
    }
}
