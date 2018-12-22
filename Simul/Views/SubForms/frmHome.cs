using Simul.Controllers;
using Simul.Models;
using System;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmHome : Form, ISubForm
    {
        FrmPrincipal _frmPrincipal;
        GameController _gameController;
        JobMarketController _jobMarketController;
        IPerson _myself;

        public FrmHome(FrmPrincipal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            _gameController = GameController.Instance;
            _jobMarketController = JobMarketController.Instance;
            _myself = _gameController.ControlledPerson;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            txtStrength.Text = _myself.Strength.ToString();
            txtProductivity.Text = _myself.DisplayProductivity();
            txtCurrentEmployer.Text = _myself.DisplayCurrentEmployer();

            btnWork.Enabled = _myself.CanWork();
            btnResign.Enabled = _myself.CanResign;
            btnTrain.Enabled = _myself.CanTrain();

            btnGetBestJob.Enabled = _myself.Employer == null;
            UpdateBtnAutoWorkDisplay();
            UpdateBtnAutoTrainDisplay();
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
    }
}
