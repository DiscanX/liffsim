using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Offre
    {
        public Marche marche { get; set; }
        public Joueur possesseur { get; set; }
        public Ressource ressource { get; set; }
        public int quantite { get; set; }
        public decimal prixUnitaire { get; set; }

        public Offre(Marche marche, Joueur possesseur, Ressource ressource, int quantite, decimal prixUnitaire)
        {
            this.marche = marche;
            this.possesseur = possesseur;
            this.ressource = ressource;
            this.quantite = quantite;
            this.prixUnitaire = prixUnitaire;
        }

    }
}
