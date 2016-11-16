using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public abstract class Joueur
    {
        public string nom { get; set; }
        public decimal monnaie { get; set; }
        public Inventaire inventaire { get; set; }

        public Joueur(string nom, decimal monnaie, Inventaire inventaire)
        {
            this.nom = nom;
            this.monnaie = monnaie;
            this.inventaire = inventaire;
        }

        public void Acheter(Offre offre, int quantite)
        {
            decimal prixTotal = offre.quantite * offre.prixUnitaire;

            if (prixTotal > monnaie)
            {
                throw new Exception("L'achat est plus grand que la monnaie possédée par le joueur");
            }

            if(quantite > offre.quantite)
            {
                throw new Exception("La quantité demandée est plus grande que la quantité offerte");
            }

            offre.possesseur.monnaie += prixTotal;
            monnaie -= prixTotal;

            if(quantite == offre.quantite)
            {
                offre.marche.SupprimerOffre(offre);
            }
            else
            {
                offre.quantite -= quantite;
            }

            inventaire.ressources[offre.ressource] += quantite;
        }

        public void Vendre(Offre offre)
        {
            if(offre.possesseur != this)
            {
                throw new Exception("Le joueur peut uniquement vendre des offres qu'il possède");
            }

            if(!inventaire.ressources.Any(x => x.Key == offre.ressource))
            {
                throw new Exception("La ressource n'est pas possédée par le joueur");
            }
            
            if(!inventaire.ressources.Any(x => x.Key == offre.ressource && x.Value > offre.quantite))
            {
                throw new Exception("L'offre contient une trop grande quantitée de cette ressource");
            }

            inventaire.ressources[offre.ressource] -= offre.quantite;
            offre.marche.offres.Add(offre);
        }

        public void TransfererVers(Joueur destinataire, Ressource ressource, int quantite)
        {

        }
    }
}
