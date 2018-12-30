using Simul.Models.Bots;
using System;

namespace Simul.Models.Factories
{
    public static class BotFactory
    {
        public static Bot CreateSimplePersonBot(Random rnd, IPerson person)
        {
            var passion = rnd.Next(1, 101);
            var interestInEconomy = rnd.Next(0, 101);
            var interestInMilitary = 100 - interestInEconomy;

            return new SimplePersonBot(
                person,
                PersonalityTraits.GenerateRandomPersonalityTraits(rnd),
                passion,
                interestInEconomy,
                interestInMilitary,
                rnd);
        }
    }
}
