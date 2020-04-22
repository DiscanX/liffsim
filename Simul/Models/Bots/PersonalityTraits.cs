using System;
using System.Collections.Generic;

namespace Simul.Models.Bots
{
    public enum ePersonalityTrait
    {
        stacker,
        greedy,
        pacifist,
        dumb
    }

    /// <summary>
    /// TODO : Check if we need this, could be great but dead code for now
    /// </summary>
    public static class PersonalityTraits
    {
        private static Dictionary<ePersonalityTrait, int> _personalityTraitsChances = new Dictionary<ePersonalityTrait, int>
        {
            {ePersonalityTrait.stacker, 5},
            {ePersonalityTrait.greedy, 5},
            {ePersonalityTrait.pacifist, 1},
            {ePersonalityTrait.dumb, 10}
        };

        public static List<ePersonalityTrait> GenerateRandomPersonalityTraits(Random rnd)
        {
            var personalityTraits = new List<ePersonalityTrait>();

            foreach (var personalityTrait in _personalityTraitsChances)
            {
                var personTraitChance = rnd.Next(1, 101);

                if (personalityTrait.Value >= personTraitChance)
                {
                    personalityTraits.Add(personalityTrait.Key);
                }
            }

            return personalityTraits;
        }
    }
}
