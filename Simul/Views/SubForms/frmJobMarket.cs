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
    public partial class frmJobMarket : Form, ISubForm
    {
        JobMarketController jobMarketController;

        public frmJobMarket(JobMarketController jobMarketController)
        {
            this.jobMarketController = jobMarketController;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {

        }
    }
}