using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Inventaire
    {
        public Dictionary<Ressource, int> ressources { get; set; }

        public Inventaire()
        {
            this.ressources = new Dictionary<Ressource, int>();
        }

        public Inventaire(Dictionary<Ressource, int> ressources)
        {
            this.ressources = ressources;
        }
    }
}
