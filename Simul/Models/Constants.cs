namespace Simul.Models
{
    public static class Constants
    {
        public const int MIN_ENERGY = 0;
        public const int MAX_ENERGY = 100;
        public const int BASE_ENERGY = 100;
        public const int ENERGY_LOST_WORKING = 20;
        public const int ENERGY_LOST_TRAINING = 20;
        public const int ENERGY_GAINED_AFTER_DAY = 5;
        public const int ENERGY_GAINED_AFTER_EATING = 20;

        public const int BASE_STRENGTH = 5;

        public const decimal BASE_MONEY = 5;

        public const string SIMPLE_COMPANY_BOT_NAME = "SC Bot";
        public const string SIMPLE_PERSON_BOT_NAME = "SP Bot";

        //Decorators
        public const string ACTION_DESCRIPTION_BUY = "Bought {0} {1} from the market {2}";
        public const string ACTION_DESCRIPTION_GIVETO = "Gave {0} {1} to the player {2}";
        public const string ACTION_DESCRIPTION_REMOVEOFFER = "Removed offer of {0} {1} from the market {2}";
        public const string ACTION_DESCRIPTION_SELL = "Put for sale {0} {1} to the market {2}";
    }
}
