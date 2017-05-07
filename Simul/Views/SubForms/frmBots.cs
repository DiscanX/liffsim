using Simul.Controllers;
using Simul.Models;
using Simul.Models.Bots;
using Simul.Models.Decorators;
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
                lstBots.Items.Add(bot.getControlledPlayer().name + " (" + bot.getBotTypeName() + ")");
            }
        }

        private void lstBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBot();
        }

        private void DisplayBot()
        {
            lstActionHistory.Items.Clear();
            Bot bot = gameController.bots.First(x => x.getControlledPlayer().name + " (" + x.getBotTypeName() + ")" == lstBots.SelectedItem.ToString());

            olvParameters.SetObjects(bot.parameters);

            IDecorator decorator = bot.getControlledPlayer() as IDecorator;
            if(decorator != null)
            {
                foreach(Tuple<int, string> action in decorator.actionHistory)
                {
                    lstActionHistory.Items.Add("Day " + action.Item1 + " : " + action.Item2);
                }
            }
        }
    }
}
