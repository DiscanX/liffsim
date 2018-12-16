using BrightIdeasSoftware;
using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmResourceMarket : Form, ISubForm
    {
        FrmPrincipal _frmPrincipal;
        ResourceMarketController _resourceMarketController;
        GameController _gameController;
        ResourceMarket _selectedResourceMarket;

        public FrmResourceMarket(FrmPrincipal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            _resourceMarketController = ResourceMarketController.Instance;
            _gameController = GameController.Instance;

            InitializeComponent();

            olvResources.SmallImageList = ContentReader.GetResourcesImages();
            olvResources.ButtonClick += DlvResources_Buy;
            olvResources.FormatRow += OlvResources_FormatRow;

            olvResourceImg.ImageGetter = x => ((ResourceOffer)x).Resource.Name.ToString();
            olvBuy.AspectGetter = x => "Buy";
        }

        private void OlvResources_FormatRow(object sender, FormatRowEventArgs e)
        {
            var resourceOffer = (ResourceOffer)e.Model;
            FormatRow(resourceOffer);
        }

        private void FormatRow(ResourceOffer resourceOffer)
        {
            if (resourceOffer.UnitPrice > _gameController.ControlledPerson.Money)
            {
                olvResources.FormatRow -= OlvResources_FormatRow;
                olvResources.DisableObject(resourceOffer);
                olvResources.FormatRow += OlvResources_FormatRow;
            }
            else if (resourceOffer.UnitPrice <= _gameController.ControlledPerson.Money)
            {
                olvResources.FormatRow -= OlvResources_FormatRow;
                olvResources.EnableObject(resourceOffer);
                olvResources.FormatRow += OlvResources_FormatRow;
            }
        }

        private void DlvResources_Buy(object sender, CellClickEventArgs e)
        {
            var resourceOffer = (ResourceOffer)e.Model;

            _gameController.ControlledPerson.Buy(_selectedResourceMarket, resourceOffer, 1);

            _frmPrincipal.ReloadMenu();

            if (_selectedResourceMarket.Offers.Exists(x => x == e.Model))
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
            foreach (ResourceMarket resourceMarket in _resourceMarketController.Markets)
            {
                cboResourceMarkets.Items.Add(resourceMarket.Name);
            }
            cboResourceMarkets.Text = _resourceMarketController.GetMarketOfCountry(_gameController.ControlledPerson.Country.Name).Name;
        }

        private void cboResourceMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedResourceMarket = _resourceMarketController.Markets.First(x => x.Name == cboResourceMarkets.SelectedItem.ToString());
            olvResources.SetObjects(_selectedResourceMarket.Offers);

            //As the event "FormatRow" is not triggered before a mouse hover
            foreach (ResourceOffer resourceOffer in olvResources.Objects)
            {
                FormatRow(resourceOffer);
            }
        }
    }
}
