using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Compagnie : Joueur
    {
        public Ressource ressourceProduite { get; set; }
        public float avancement { get; set; }
        public List<Contrat> contrats { get; set; }

        public Compagnie(string nom, Ressource ressourceProduite, decimal monnaie, Inventaire inventaire) : base(nom, monnaie, inventaire)
        {
            this.ressourceProduite = ressourceProduite;
            this.contrats = new List<Contrat>();
        }

        public void Produire(Contrat contrat)
        {
            
        }
    }
}
