using AutoFixture;
using Simul.Models;
using SimulTests.Customizations;
using System;
using System.Collections.Generic;
using Xunit;

namespace SimulTests.Models
{
    public class PlayerTest
    {
        private Fixture _fixture;
        private string _name;
        private Country _country;
        private decimal _money;
        private Inventory _inventory;
        private bool _isHumanControlled;
        private Player _player;

        public PlayerTest()
        {
            _fixture = new Fixture();
            _fixture.Customize(new InventoryCustomization());
            _fixture.Customize(new ResourceCustomization());

            _name = _fixture.Create<string>();
            _country = _fixture.Create<Country>();
            _money = _fixture.Create<decimal>();
            _inventory = _fixture.Create<Inventory>();
            _isHumanControlled = _fixture.Create<bool>();

            _player = new PlayerTestClass(
                _name,
                _country,
                _money,
                _inventory,
                _isHumanControlled);
        }

        [Fact]
        public void CalculateMaximumBuyable_QuantityToBuyTooHigh_ThrowsExeception()
        {
            var resource = _fixture.Create<Resource>();
            var quantity = _fixture.Create<int>();
            var offers = new List<(ResourceOffer, int)>
            {
                (new ResourceOffer(_player, resource, quantity, _fixture.Create<decimal>()), quantity + 1)
            };

            Assert.Throws<Exception>(() => _player.CalculateMaximumBuyable(offers));
        }
    }
}
