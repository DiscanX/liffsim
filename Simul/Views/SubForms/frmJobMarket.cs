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

        public frmJobMarket(frmPrincipal frmPrincipal, GameController gameController, JobMarketController jobMarketController)
        {
            this.frmPrincipal = frmPrincipal;
            this.gameController = gameController;
            this.jobMarketController = jobMarketController;

            InitializeComponent();

            olvJobs.SmallImageList = ContentReader.GetResourcesImages();
            olvJobs.ButtonClick += DlvJobs_Apply;
            olvJobs.FormatRow += DlvJobs_FormatRow;

            olvResourceImg.ImageGetter = delegate (object rowObject) { return ((JobOffer)rowObject).employer.producedResource.name; };
            olvApply.AspectGetter = delegate (object rowObject) { return "Apply"; };
        }

        private void DlvJobs_Apply(object sender, CellClickEventArgs e)
        {
            
        }

        private void DlvJobs_FormatRow(object sender, FormatRowEventArgs e)
        {
            JobOffer jobOffer = (JobOffer)e.Model;
            FormatRow(jobOffer);
        }

        private void FormatRow(JobOffer jobOffer)
        {

        }

        public void UpdateDisplay()
        {
            cboJobMarkets.Items.Clear();
            foreach(JobMarket jobMarket in jobMarketController.markets)
            {
                cboJobMarkets.Items.Add(jobMarket.name);
            }
            cboJobMarkets.SelectedIndex = 0;
        }

        private void cboJobMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJobMarket = jobMarketController.markets.First(x => x.name == cboJobMarkets.SelectedItem.ToString());
            olvJobs.SetObjects(selectedJobMarket.offers);

            //As the event "FormatRow" is not triggered before a mouse hover
            foreach (JobOffer jobOffer in olvJobs.Objects)
            {
                FormatRow(jobOffer);
            }
        }
    }
}
