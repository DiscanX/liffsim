using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simul.Controllers;
using Simul.Models;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;

namespace SimulTests
{
    [TestClass]
    public class CompanyControllerTests
    {
        //[TestMethod]
        //public void GetCompanyByName_OnValidString_Found()
        //{
        //    //Arrange
        //    CompanyController controller = new CompanyController();

        //    Fixture fixture = new Fixture();

        //    //Tell fixture to use PrimaryResource for abstract Resource class
        //    fixture.Customizations.Add(new TypeRelay(typeof(Resource), typeof(PrimaryResource)));
        //    Company company = fixture.Build<Company>().Without(x => x.employees).Create();
        //    company.name = "Company Test Name";

        //    controller.companies.Add(company);

        //    //Act
        //    Company result = controller.GetCompanyByName("Company Test Name");

        //    //Assert
        //    Assert.AreSame(company, result);
        //}

    }
}
