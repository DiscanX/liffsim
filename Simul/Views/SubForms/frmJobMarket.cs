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
    public partial class frmJobMarket : Form, ISubForm
    {
        frmPrincipal frmPrincipal;
        JobMarketController jobMarketController;
        GameController gameController;
        JobMarket selectedJobMarket;

        public frmJobMarket(GameController gameController, JobMarketController jobMarketController)
        {
            this.gameController = gameController;
            this.jobMarketController = jobMarketController;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {

        }
    }
}
