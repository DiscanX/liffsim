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

        public IPerson controlledPerson { get; set; }
        public List<Bot> bots { get; set; }
        public int currentDay { get; set; }
        public Random random { get; set; }

        private GameController()
        {
            this.bots = new List<Bot>();
            this.random = new Random();
            this.currentDay = 1;
        }

        public void ForwardDays(List<IPerson> persons, int nbrDays = 1)
        {
            for (int i = 0; i < nbrDays; i++)
            {
                IEnumerable<Bot> shuffledBots = bots.OrderBy(x => random.Next());
                foreach(Bot bot in shuffledBots)
                {
                    bot.LiveDay();
                }

                foreach (IPerson person in persons)
                {
                    person.Energy += Constants.ENERGY_GAINED_AFTER_DAY;
                    person.alreadyTrained = false;
                    person.alreadyWorked = false;

                    //Can't resign the same day or the day after a person got a job
                    if (person.employer != null && !person.canResign && person.jobStartDay > currentDay)
                    {
                        person.canResign = true;
                    }
                }
                currentDay++;
            }
        }
    }
}
