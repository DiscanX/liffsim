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
    public partial class frmBots : Form, ISubForm
    {
        GameController gameController;

        public frmBots()
        {
            this.gameController = GameController.Instance;

            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            lstBots.Items.Clear();
            foreach (Bot bot in gameController.bots)
            {
                lstBots.Items.Add(bot.getBotName() + " (" + bot.getBotTypeName() + ")");
            }
        }

        private void lstBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBot();
        }

        private void DisplayBot()
        {
            Bot bot = gameController.bots.First(x => x.getBotName() + " (" + x.getBotTypeName() + ")" == lstBots.SelectedItem.ToString());

            olvParameters.SetObjects(bot.parameters);
        }
    }
}
