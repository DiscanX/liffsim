using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public abstract class Bot
    {
        public Dictionary<string, int> parameters { get; set; }
        abstract public string getBotTypeName();
        abstract public string getBotName();

        abstract public void LiveDay();
    }
}
