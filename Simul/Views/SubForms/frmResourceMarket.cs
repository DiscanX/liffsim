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
using Simul.Views;

namespace Simul.Views.SubForms
{
    public partial class frmResourceMarket : Form, ISubForm
    {
        frmPrincipal frmPrincipal;
        ResourceMarketController resourceMarketController;
        GameController gameController;
        ResourceMarket selectedResourceMarket;

        public frmResourceMarket(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            this.resourceMarketController = ResourceMarketController.Instance;
            this.gameController = GameController.Instance;

            InitializeComponent();

            olvResources.SmallImageList = ContentReader.GetResourcesImages();
            olvResources.ButtonClick += DlvResources_Buy;
            olvResources.FormatRow += OlvResources_FormatRow;

            olvResourceImg.ImageGetter = delegate (object rowObject) { return ((ResourceOffer)rowObject).resource.name.ToString(); };
            olvBuy.AspectGetter = delegate (object rowObject) { return "Buy"; };
        }

        private void OlvResources_FormatRow(object sender, FormatRowEventArgs e)
        {
            ResourceOffer resourceOffer = (ResourceOffer)e.Model;
            FormatRow(resourceOffer);
        }

        private void FormatRow(ResourceOffer resourceOffer)
        {
            if (resourceOffer.unitPrice > gameController.controlledPerson.Money)
            {
                olvResources.FormatRow -= OlvResources_FormatRow;
                olvResources.DisableObject(resourceOffer);
                olvResources.FormatRow += OlvResources_FormatRow;
            }
            else if (resourceOffer.unitPrice <= gameController.controlledPerson.Money)
            {
                olvResources.FormatRow -= OlvResources_FormatRow;
                olvResources.EnableObject(resourceOffer);
                olvResources.FormatRow += OlvResources_FormatRow;
            }
        }

        private void DlvResources_Buy(object sender, CellClickEventArgs e)
        {
            ResourceOffer resourceOffer = (ResourceOffer)e.Model;

            gameController.controlledPerson.Buy(selectedResourceMarket, resourceOffer, 1);

            frmPrincipal.ReloadMenu();

            if(selectedResourceMarket.offers.Exists(x => x == e.Model))
            {
                olvResources.RefreshObject(e.Model);
            }
            else
            {
                olvResources.RemoveObject(e.Model);
            }
            
        }

        public void UpdateDisplay()
        {
            cboResourceMarkets.Items.Clear();
            foreach (ResourceMarket resourceMarket in resourceMarketController.markets)
            {
                cboResourceMarkets.Items.Add(resourceMarket.name);
            }
            cboResourceMarkets.Text = resourceMarketController.markets.First(x => x.country == gameController.controlledPerson.country).name;
        }

        private void cboResourceMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedResourceMarket = resourceMarketController.markets.First(x => x.name == cboResourceMarkets.SelectedItem.ToString());
            olvResources.SetObjects(selectedResourceMarket.offers);

            //As the event "FormatRow" is not triggered before a mouse hover
            foreach (ResourceOffer resourceOffer in olvResources.Objects)
            {
                FormatRow(resourceOffer);
            }
        }
    }
}
