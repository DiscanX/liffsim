using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Competence
    {
        public TypeCompetence typeCompetence { get; set; }

        public Competence(TypeCompetence typeCompetence)
        {
            this.typeCompetence = typeCompetence;
        }
    }
}
