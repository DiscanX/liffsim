using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public abstract class Bot
    {
        internal static string botTypeName;

        public string BotTypeName { get { return botTypeName; } }
        public Person myself { get; set; }
        public Random random { get; set; }

        abstract public void LiveDay();
    }
}
