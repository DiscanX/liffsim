using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simul.Controllers;
using Simul.Helpers;
using Simul.Models;

namespace SimulTests
{
    [TestClass]
    public class GameControllerTests
    {
        [TestMethod]
        public void ForwardDays_OnNextDay_EnergyGained()
        {
            var gameController = GameController.Instance;
            var personController = PersonController.Instance;

            var person = new Person("P1", null, Constants.BASE_MONEY, null, null, Constants.MIN_ENERGY, Constants.BASE_STRENGTH);
            personController.Persons.Add(person);

            gameController.ForwardDays(personController.Persons);

            Assert.AreEqual(Constants.ENERGY_GAINED_AFTER_DAY, person.Energy);
        }

        [TestMethod]
        public void ForwardDays_OnNextDayAfterTraining_AlreadyTrainedFalse()
        {
            var gameController = GameController.Instance;
            var personController = PersonController.Instance;

            var person = new Person("P1", null, Constants.BASE_MONEY, null, null, Constants.BASE_ENERGY, Constants.BASE_STRENGTH);
            personController.Persons.Add(person);

            person.Train();
            gameController.ForwardDays(personController.Persons);

            Assert.AreEqual(person.AlreadyTrained, false);
        }

        [TestMethod]
        public void ForwardDays_OnNextDayAfterWorking_AlreadyWorkedFalse()
        {
            var gameController = GameController.Instance;
            var companyController = CompanyController.Instance;
            var personController = PersonController.Instance;

            var company = new Company("C1", null, ContentReader.GetResources()[0], Constants.BASE_MONEY, new Inventory());
            var person = new Person("P1", null, Constants.BASE_MONEY, new Skillset(), new Inventory(), Constants.BASE_ENERGY, Constants.BASE_STRENGTH)
            {
                Employer = company
            };
            companyController.Companies.Add(company);
            personController.Persons.Add(person);

            person.Work();
            gameController.ForwardDays(personController.Persons);

            Assert.AreEqual(person.AlreadyWorked, false);
        }
    }
}
