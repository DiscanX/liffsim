using Simul.Models;
using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Controllers
{
    public class GameController
    {
        public Person controlledPerson { get; set; }

        public GameController(Person controlledPerson)
        {
            this.controlledPerson = controlledPerson;
        }

        public void ForwardDays(int nbrDays)
        {

        }
    }
}
