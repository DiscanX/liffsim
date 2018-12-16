using System.Collections.Generic;

namespace Simul.Models.Bots
{
    public abstract class Bot
    {
        public Dictionary<string, int> Parameters { get; set; }
        abstract public string GetBotTypeName();
        abstract public IPlayer GetControlledPlayer();

        abstract public void LiveDay();
    }
}
