using Simul.Models;
using Simul.Models.Bots;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simul.Controllers
{
    public class GameController
    {
        static GameController() { }
        public static GameController Instance = new GameController();

        public IPerson ControlledPerson { get; set; }
        public bool AutoWorkIsActivated { get; set; }
        public bool AutoTrainIsActivated { get; set; }
        public bool AutoEatIsActivated { get; set; }
        public List<Bot> Bots { get; set; }
        public int CurrentDay { get; set; }
        public Random Random { get; set; }

        private GameController()
        {
            Bots = new List<Bot>();
            Random = new Random();
            CurrentDay = 1;
        }

        public void ForwardDays(List<IPerson> persons, int nbrDays = 1)
        {
            for (int i = 0; i < nbrDays; i++)
            {
                if (AutoEatIsActivated)
                {
                    ControlledPerson.EatUntilFull();
                }

                if (AutoWorkIsActivated && ControlledPerson.CanWork())
                {
                    ControlledPerson.Work();
                }

                if (AutoTrainIsActivated && ControlledPerson.CanTrain())
                {
                    ControlledPerson.Train();
                }

                foreach (Bot bot in Bots.OrderBy(x => Random.Next()))
                {
                    bot.LiveDay();
                }

                foreach (IPerson person in persons)
                {
                    person.Energy += Constants.ENERGY_GAINED_AFTER_DAY;
                    person.AlreadyTrained = false;
                    person.AlreadyWorked = false;

                    //Can't resign the same day or the day after a person got a job
                    if (person.Employer != null && !person.CanResign && person.JobStartDay > CurrentDay)
                    {
                        person.CanResign = true;
                    }
                }

                CurrentDay++;
            }
        }
    }
}
