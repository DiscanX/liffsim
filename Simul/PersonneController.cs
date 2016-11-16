using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class PersonneController
    {
        public List<Personne> personnes { get; set; }

        public PersonneController()
        {
            personnes = new List<Personne>();
            personnes.Add(new Personne("Keven", 10, new Dictionary<Competence, float>(), new Inventaire(), 5));
            personnes.Add(new Personne("Noèmie", 10, new Dictionary<Competence, float>(), new Inventaire(), 5));
            personnes.Add(new Personne("David", 10, new Dictionary<Competence, float>(), new Inventaire(), 5));
        }
    }
}
