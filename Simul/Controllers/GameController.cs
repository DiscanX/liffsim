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
        public int currentDay { get; set; }

        public GameController(Person controlledPerson)
        {
            this.controlledPerson = controlledPerson;
            this.currentDay = 1;
        }

        public void ForwardDays(List<Person> persons, int nbrDays = 1)
        {
            for (int i = 0; i < nbrDays; i++)
            {
                foreach (Person person in persons)
                {
                    person.alreadyTrained = false;
                    person.alreadyWorked = false;
                }
                currentDay++;
            }
        }
    }
}
