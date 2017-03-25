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
        static GameController() { }
        private static GameController instance = new GameController();
        public static GameController Instance { get { return instance; } }

        public Person controlledPerson { get; set; }
        public List<IBot> bots { get; set; }
        public int currentDay { get; set; }
        public Random random { get; set; }

        private GameController()
        {
            this.bots = new List<IBot>();
            this.random = new Random();
            this.currentDay = 1;
        }

        public void ForwardDays(List<Person> persons, int nbrDays = 1)
        {
            for (int i = 0; i < nbrDays; i++)
            {
                foreach (Person person in persons)
                {
                    person.Energy += 5;
                    person.alreadyTrained = false;
                    person.alreadyWorked = false;
                }
                currentDay++;

                IEnumerable<IBot> shuffledBots = bots.OrderBy(x => random.Next());
                foreach(IBot bot in shuffledBots)
                {
                    bot.LiveDay();
                }
            }
        }
    }
}
