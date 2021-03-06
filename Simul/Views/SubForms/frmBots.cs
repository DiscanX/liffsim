﻿using Simul.Controllers;
using Simul.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Simul.Views.SubForms
{
    public partial class FrmBots : Form, ISubForm
    {
        private readonly GameController _gameController;
        private object _currentSelectedItem;

        public FrmBots()
        {
            _gameController = GameController.Instance;
            InitializeComponent();
        }

        public void UpdateDisplay()
        {
            lstBots.Items.Clear();
            foreach (var bot in _gameController.Bots)
            {
                lstBots.Items.Add(bot.GetControlledPlayer().Name + " (" + bot.GetBotTypeName() + ")");
            }

            if (_currentSelectedItem != null)
            {
                lstBots.SelectedItem = _currentSelectedItem;
            }
        }

        private void lstBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentSelectedItem = lstBots.SelectedItem;
            DisplayBot();
        }

        private void DisplayBot()
        {
            lstActionHistory.Items.Clear();
            var bot = _gameController.Bots.First(x => x.GetControlledPlayer().Name + " (" + x.GetBotTypeName() + ")" == lstBots.SelectedItem.ToString());

            olvParameters.SetObjects(bot.Parameters);

            var decorator = bot.GetControlledPlayer() as IDecorator;
            if (decorator != null)
            {
                foreach (var action in decorator.ActionHistory)
                {
                    lstActionHistory.Items.Add("Day " + action.day + " : " + action.description);
                }
            }
        }
    }
}
