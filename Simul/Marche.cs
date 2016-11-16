using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Marche
    {
        public string nom { get; set; }
        public List<Offre> offres { get; set; }

        public Marche(string nom, List<Offre> offres)
        {
            this.nom = nom;
            this.offres = offres;
        }

        public void SupprimerOffre(Offre offre)
        {
            if (nom != offre.marche.nom)
            {
                throw new Exception("Ce marché n'est pas le bon marché pour cette offre");
            }

            Offre offreTrouvee = offres.Find(x => x == offre);

            if(offreTrouvee == null)
            {
                throw new Exception("Ce marché ne possède pas cette offre");
            }

            offres.Remove(offreTrouvee);
        }
    }
}
