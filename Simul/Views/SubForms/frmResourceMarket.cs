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
    public partial class frmResourceMarket : Form, ISubForm
    {
        ResourceMarketController resourceMarketController;

        public frmResourceMarket(ResourceMarketController resourceMarketController)
        {
            this.resourceMarketController = resourceMarketController;

            InitializeComponent();

            dlvResources.SmallImageList = ContentReader.GetResourcesImages();
            olvResourceMarketImg.ImageGetter = delegate (object rowObject) { return ((ResourceOffer)rowObject).resource.name; };
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
