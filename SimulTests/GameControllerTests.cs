using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simul.Controllers;
using Ploeh.AutoFixture;
using Simul.Models;
using Simul.Helpers;

namespace SimulTests
{
    [TestClass]
    public class GameControllerTests
    {
        [TestMethod]
        public void ForwardDays_OnNextDay_EnergyGained()
        {
            //Arrange
            GameController gameController = GameController.Instance;
            PersonController personController = PersonController.Instance;

            Person person = new Person("P1", null, Constants.BASE_MONEY, null, null, Constants.MIN_ENERGY, Constants.BASE_STRENGTH);
            personController.persons.Add(person);

            //Act
            gameController.ForwardDays(personController.persons);

            //Assert
            Assert.AreEqual(Constants.ENERGY_GAINED_AFTER_DAY, person.Energy);
        }

        [TestMethod]
        public void ForwardDays_OnNextDayAfterTraining_AlreadyTrainedFalse()
        {
            //Arrange
            GameController gameController = GameController.Instance;
            PersonController personController = PersonController.Instance;

            Person person = new Person("P1", null, Constants.BASE_MONEY, null, null, Constants.BASE_ENERGY, Constants.BASE_STRENGTH);
            personController.persons.Add(person);

            //Act
            person.Train();
            gameController.ForwardDays(personController.persons);

            //Assert
            Assert.AreEqual(person.alreadyTrained, false);
        }

        [TestMethod]
        public void ForwardDays_OnNextDayAfterWorking_AlreadyWorkedFalse()
        {
            //Arrange
            GameController gameController = GameController.Instance;
            CompanyController companyController = CompanyController.Instance;
            PersonController personController = PersonController.Instance;

            Company company = new Company("C1", null, ContentReader.GetResources()[0], Constants.BASE_MONEY, new Inventory());
            Person person = new Person("P1", null, Constants.BASE_MONEY, new Skillset(), new Inventory(), Constants.BASE_ENERGY, Constants.BASE_STRENGTH);
            person.employer = company;
            companyController.companies.Add(company);
            personController.persons.Add(person);

            //Act
            person.Work();
            gameController.ForwardDays(personController.persons);

            //Assert
            Assert.AreEqual(person.alreadyWorked, false);
        }
    }
}
