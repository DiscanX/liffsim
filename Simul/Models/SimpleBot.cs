using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class SimplePersonBot : IBot
    {
        public Person myself { get; set; }
        public int passion { get; set; }
        public int interestInEconomy { get; set; }
        public int interestInMilitary { get; set; }
        public Random random { get; set; }

        public SimplePersonBot(Person myself, int passion, int interestInEconomy, int interestInMilitary, Random random)
        {
            this.myself = myself;
            this.myself.isHumanControlled = false;

            this.passion = passion;
            this.interestInEconomy = interestInEconomy;
            this.interestInMilitary = interestInMilitary;
            this.random = new Random();
        }

        public void LiveDay()
        {
            if(passion > 0 && random.Next(1, 101) <= passion)
            {
                //Find a job if none
                if(myself.employer == null)
                {

                }


                //Get an objective if none

                //Work & Train

                //Buy & Sell
            }
        }
    }
}
