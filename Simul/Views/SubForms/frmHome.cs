using Simul.Controllers;
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
    public partial class frmHome : Form, ISubForm
    {
        frmPrincipal frmPrincipal;
        GameController gameController;

        public frmHome(frmPrincipal frmPrincipal, GameController gameController)
        {
            this.frmPrincipal = frmPrincipal;
            this.gameController = gameController;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            txtStrength.Text = gameController.controlledPerson.strength.ToString();
            txtProductivity.Text = gameController.controlledPerson.DisplayProductivity();

            btnWork.Enabled = (gameController.controlledPerson.employer != null && !gameController.controlledPerson.alreadyWorked);
            txtCurrentEmployer.Text = gameController.controlledPerson.employer == null ? "Nowhere" : gameController.controlledPerson.employer.name;

            btnTrain.Enabled = (!gameController.controlledPerson.alreadyTrained);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            gameController.controlledPerson.Train();
            frmPrincipal.ReloadMenu();
            UpdateDisplay();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            gameController.controlledPerson.Work();
            frmPrincipal.ReloadMenu();
            UpdateDisplay();
        }
    }
}
