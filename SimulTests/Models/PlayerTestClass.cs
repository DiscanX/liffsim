using Simul.Models;

namespace SimulTests.Models
{
    public class PlayerTestClass : Player
    {
        public PlayerTestClass(string name, Country country, decimal money, Inventory inventory, bool isHumanControlled)
            : base(name, country, money, inventory, isHumanControlled)
        {

        }
    }
}
