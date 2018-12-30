using Simul.Controllers;
using Simul.Models.Decorators;
using System;

namespace Simul.Models.Factories
{
    public static class PersonFactory
    {
        private static CountryController _countryController;

        static PersonFactory()
        {
            _countryController = CountryController.Instance;
        }

        public static IPerson Create(Random rnd, bool decorated = true)
        {
            var name = Guid.NewGuid().ToString().Substring(0, 15);
            var country = _countryController.Countries[rnd.Next(0, _countryController.Countries.Count)];
            var person = new Person(
                name,
                country,
                Constants.BASE_MONEY,
                new Skillset(),
                new Inventory(),
                Constants.BASE_ENERGY,
                Constants.BASE_STRENGTH);

            if (decorated)
            {
                return new PersonDecorator(person);
            }

            return person;
        }
    }
}
