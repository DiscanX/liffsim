using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmHome : Form, ISubForm
    {
        private readonly FrmPrincipal _frmPrincipal;
        private readonly GameController _gameController;
        private readonly JobMarketController _jobMarketController;
        private readonly IPerson _myself;

        public FrmHome(FrmPrincipal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            _gameController = GameController.Instance;
            _jobMarketController = JobMarketController.Instance;
            _myself = _gameController.ControlledPerson;

            InitializeComponent();

            olvInventory.SmallImageList = ContentReader.GetResourcesImages();
            olvResourceImg.ImageGetter = x => ((KeyValuePair<Resource, int>)x).Key.Name.ToString();
        }

        public void UpdateDisplay()
        {
            txtStrength.Text = _myself.Strength.ToString();
            txtCurrentEmployer.Text = _myself.DisplayCurrentEmployer();

            btnWork.Enabled = _myself.CanWork();
            btnResign.Enabled = _myself.CanResign;
            btnTrain.Enabled = _myself.CanTrain();

            btnGetBestJob.Enabled = _myself.Employer == null;
            UpdateLstControlledPersonActions();
            UpdateBtnAutoWorkDisplay();
            UpdateBtnAutoTrainDisplay();

            UpdateInventory();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            _myself.Train();
            _frmPrincipal.ReloadMenu();
            UpdateDisplay();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            _myself.Work();
            _frmPrincipal.ReloadMenu();
            UpdateDisplay();
        }

        private void btnResign_Click(object sender, EventArgs e)
        {
            _myself.Resign(_gameController.CurrentDay);
            UpdateDisplay();
        }

        private void btnGetBestJob_Click(object sender, EventArgs e)
        {
            var bestJob = _jobMarketController.FindBestJob(_myself.Country);
            if (bestJob.jobOffer != null)
            {
                _myself.TakeJob(bestJob.jobMarket, bestJob.jobOffer, _gameController.CurrentDay);
                UpdateDisplay();
            }
        }

        private void btnAutoWork_Click(object sender, EventArgs e)
        {
            _gameController.AutoWorkIsActivated = !_gameController.AutoWorkIsActivated;
            UpdateBtnAutoWorkDisplay();
        }

        private void btnAutoTrain_Click(object sender, EventArgs e)
        {
            _gameController.AutoTrainIsActivated = !_gameController.AutoTrainIsActivated;
            UpdateBtnAutoTrainDisplay();
        }

        private void btnAutoEat_Click(object sender, EventArgs e)
        {
            _gameController.AutoEatIsActivated = !_gameController.AutoEatIsActivated;
            UpdateBtnAutoEatDisplay();
        }

        private void UpdateLstControlledPersonActions()
        {
            lstControlledPersonActions.Items.Clear();

            var decorator = _myself as IDecorator;
            if (decorator != null)
            {
                foreach (var action in decorator.ActionHistory)
                {
                    lstControlledPersonActions.Items.Add("Day " + action.day + " : " + action.description);
                }
            }
        }

        private void UpdateBtnAutoWorkDisplay()
        {
            btnAutoWork.Text = _gameController.AutoWorkIsActivated ?
                "Disable auto work" : "Enable auto work";
        }

        private void UpdateBtnAutoTrainDisplay()
        {
            btnAutoTrain.Text = _gameController.AutoTrainIsActivated ?
                "Disable auto train" : "Enable auto train";
        }

        private void UpdateBtnAutoEatDisplay()
        {
            btnAutoEat.Text = _gameController.AutoEatIsActivated ?
                "Disable auto eat" : "Enable auto eat";
        }

        private void UpdateInventory()
        {
            dlvSkills.SetObjects(_myself.Skillset.Skills);
            olvInventory.SetObjects(_myself.Inventory.Stocks);
        }


    }
}
