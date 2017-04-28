using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models.Bots
{
    public enum ePersonalityTrait
    {
        stacker,
        greedy,
        pacifist,
        dumb
    }

    public static class PersonalityTraits
    {
        private static Dictionary<ePersonalityTrait, int> personalityTraitsChances = new Dictionary<ePersonalityTrait, int>
        {
            {ePersonalityTrait.stacker, 5},
            {ePersonalityTrait.greedy, 5},
            {ePersonalityTrait.pacifist, 1},
            {ePersonalityTrait.dumb, 10}
        };

        public static List<ePersonalityTrait> GenerateRandomPersonalityTraits(Random rnd)
        {
            var personalityTraits = new List<ePersonalityTrait>();

            foreach(var personalityTrait in personalityTraitsChances)
            {
                int personTraitChance = rnd.Next(1, 101);

                if(personalityTrait.Value >= personTraitChance)
                {
                    personalityTraits.Add(personalityTrait.Key);
                }
            }

            return personalityTraits;
        }
    }
}
