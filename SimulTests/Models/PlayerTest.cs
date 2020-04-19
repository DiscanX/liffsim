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
        private readonly Fixture _fixture;
        private readonly Country _country;
        private readonly Inventory _inventory;
        private readonly Resource _resource;
        private readonly string _name;
        private decimal _money;
        private readonly bool _isHumanControlled;
        private int _quantity;
        private decimal _unitPrice;

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
            _resource = _fixture.Create<Resource>();
            _quantity = _fixture.Create<int>();
            _unitPrice = _fixture.Create<decimal>();
        }

        [Fact]
        public void CalculateMaximumBuyable_QuantityToBuyTooHigh_ThrowsExeception()
        {
            var quantityToBuy = _quantity + 1;
            var offers = new List<(ResourceOffer, int)>
            {
                (CreateResourceOffer(), quantityToBuy)
            };

            Assert.Throws<Exception>(() => CreatePlayerTestClass().CalculateMaximumBuyable(offers));
        }

        [Fact]
        public void CalculateMaximumBuyable_OneOfferFirstOfferHigherThanMoney_ReturnsGoodAmountToBuy()
        {
            _quantity = 5;
            _unitPrice = 2m;
            _money = 6.01m;
            var quantityToBuy = 4;
            var offers = new List<(ResourceOffer, int)>
            {
                (CreateResourceOffer(), quantityToBuy)
            };

            var result = CreatePlayerTestClass().CalculateMaximumBuyable(offers);

            Assert.Equal(3, result);
        }

        [Fact]
        public void CalculateMaximumBuyable_ManyOffersLastOfferHigherThanMoney_ReturnsGoodAmountToBuy()
        {
            _quantity = 5;
            _unitPrice = 1.5m;
            _money = 13.45m;
            var quantityToBuy = 5;
            var offers = new List<(ResourceOffer, int)>
            {
                (CreateResourceOffer(), quantityToBuy),
                (CreateResourceOffer(), quantityToBuy)
            };

            var result = CreatePlayerTestClass().CalculateMaximumBuyable(offers);

            Assert.Equal(8, result);
        }

        private Player CreatePlayerTestClass()
        {
            return new PlayerTestClass(
                _name,
                _country,
                _money,
                _inventory,
                _isHumanControlled);
        }

        private ResourceOffer CreateResourceOffer()
        {
            return new ResourceOffer(
                CreatePlayerTestClass(),
                _resource,
                _quantity,
                _unitPrice);
        }
    }
}
