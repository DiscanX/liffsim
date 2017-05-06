﻿using Simul.Controllers;
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

        public frmHome(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            this.gameController = GameController.Instance;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            txtStrength.Text = gameController.controlledPerson.strength.ToString();
            txtProductivity.Text = gameController.controlledPerson.DisplayProductivity();
            txtCurrentEmployer.Text = gameController.controlledPerson.DisplayCurrentEmployer();

            btnWork.Enabled = gameController.controlledPerson.CanWork();
            btnTrain.Enabled = gameController.controlledPerson.CanTrain();
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
