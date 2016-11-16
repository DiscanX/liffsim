using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Contrat
    {
        public Personne personne { get; set; }
        public Compagnie compagnie { get; set; }
        public decimal salaire { get; set; }

        public Contrat(Personne personne, Compagnie compagnie, decimal salaire)
        {
            this.personne = personne;
            this.compagnie = compagnie;
            this.salaire = salaire;
        }
    }
}
