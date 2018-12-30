using System.Collections.Generic;

namespace Simul.Models.Bots
{
    public abstract class Bot
    {
        public int IdleDays { get; set; }
        public Dictionary<string, int> Parameters { get; set; }
        abstract public string GetBotTypeName();
        abstract public IPlayer GetControlledPlayer();

        abstract public void LiveDay();
    }
}
