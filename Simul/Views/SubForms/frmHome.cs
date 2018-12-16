using Simul.Controllers;
using System;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmHome : Form, ISubForm
    {
        FrmPrincipal _frmPrincipal;
        GameController _gameController;

        public FrmHome(FrmPrincipal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            _gameController = GameController.Instance;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            txtStrength.Text = _gameController.ControlledPerson.Strength.ToString();
            txtProductivity.Text = _gameController.ControlledPerson.DisplayProductivity();
            txtCurrentEmployer.Text = _gameController.ControlledPerson.DisplayCurrentEmployer();

            btnWork.Enabled = _gameController.ControlledPerson.CanWork();
            btnResign.Enabled = _gameController.ControlledPerson.CanResign;
            btnTrain.Enabled = _gameController.ControlledPerson.CanTrain();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            _gameController.ControlledPerson.Train();
            _frmPrincipal.ReloadMenu();
            UpdateDisplay();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            _gameController.ControlledPerson.Work();
            _frmPrincipal.ReloadMenu();
            UpdateDisplay();
        }

        private void btnResign_Click(object sender, EventArgs e)
        {
            _gameController.ControlledPerson.Resign(_gameController.CurrentDay);
            UpdateDisplay();
        }
    }
}
