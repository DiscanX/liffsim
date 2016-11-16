using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Personne : Joueur
    {
        public float force { get; set; }
        public Contrat contrat { get; set; }
        public Dictionary<Competence, float> competences { get; set; }

        public Personne(string nom, decimal monnaie, Dictionary<Competence, float> competences,  Inventaire inventaire, float force) : base(nom, monnaie, inventaire)
        {
            this.competences = competences;
            this.force = force;
        }

        public void Travailler()
        {
            contrat.compagnie.Produire(contrat);
            IncrementCompetence(contrat.compagnie.ressourceProduite.competenceAmelioree);
        }

        public void Sentrainer()
        {
            IncrementForce();
        }

        private void IncrementForce()
        {
            if (force <= 10)
            {
                force++;
            }
            else if (force <= 50)
            {
                force += 0.5f;
            }
            else if (force <= 100)
            {
                force += 0.25f;
            }
            else if (force <= 200)
            {
                force += 0.10f;
            }
            else
            {
                force += 0.05f;
            }
        }

        private void IncrementCompetence(Competence competence)
        {
            if (competences[competence] <= 1)
            {
                competences[competence]++;
            }
            else if (competences[competence] <= 5)
            {
                competences[competence] += 0.5f;
            }
            else if (competences[competence] <= 10)
            {
                competences[competence] += 0.25f;
            }
            else if (competences[competence] <= 20)
            {
                competences[competence] += 0.10f;
            }
            else
            {
                competences[competence] += 0.05f;
            }
        }
    }
}
