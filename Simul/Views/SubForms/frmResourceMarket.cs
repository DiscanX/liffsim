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
using BrightIdeasSoftware;

namespace Simul.Views.SubForms
{
    public partial class frmResourceMarket : Form, ISubForm
    {
        ResourceMarketController resourceMarketController;
        GameController gameController;

        public frmResourceMarket(GameController gameController, ResourceMarketController resourceMarketController)
        {
            this.resourceMarketController = resourceMarketController;
            this.gameController = gameController;

            InitializeComponent();

            dlvResources.SmallImageList = ContentReader.GetResourcesImages();
            dlvResources.ButtonClick += DlvResources_Buy;

            olvResourceMarketImg.ImageGetter = delegate (object rowObject) { return ((ResourceOffer)rowObject).resource.name; };
            olvResourceMarketBuy.AspectGetter = delegate { return "Buy"; };
        }

        private void DlvResources_Buy(object sender, CellClickEventArgs e)
        {
            ResourceOffer resourceOffer = (ResourceOffer)e.Model;
            gameController.controlledPerson.Buy(resourceOffer, resourceOffer.quantity);

            // If something about the object changed, you probably want to refresh the model
            //dlvResources.RefreshObject(e.Model);
        }

        public void UpdateDisplay()
        {
            cboResourceMarkets.Items.Clear();
            foreach (ResourceMarket resourceMarket in resourceMarketController.markets)
            {
                cboResourceMarkets.Items.Add(resourceMarket.name);
            }

            cboResourceMarkets.SelectedIndex = 0;
        }

        private void cboResourceMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            dlvResources.SetObjects(resourceMarketController.markets.First(x => x.name == cboResourceMarkets.SelectedItem.ToString()).offers);
        }
    }
}
