using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Ressource
    {
        public TypeRessource typeRessource { get; set; }
        public Competence competenceAmelioree { get; set; }

        public Ressource(TypeRessource typeRessource, Competence competenceAmelioree)
        {
            this.typeRessource = typeRessource;
        }
    }
}
