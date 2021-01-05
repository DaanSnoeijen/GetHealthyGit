using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetHealthy;
using GetHealthy.Containers;
using GetHealthy.Controllers;
using GetHealthy.Interfaces;
using System;

namespace UnitTestGetHealthy
{
    [TestClass]
    public class UnitTestBerekening
    {
        [TestMethod]
        public void TestVoedingsWaardes()
        {
            //Arrange
            IGebruikerContainer gebruikerContainer = new GebruikerContainer();
            IUitkomstContainer uitkomstContainer = new UitkomstContainer();
            IProductContainer productContainer = new ProductContainer();
            IInvoerContainer invoerContainer = new InvoerContainer();

            BerekenController berekenController = new BerekenController(gebruikerContainer, uitkomstContainer, productContainer, invoerContainer);

            DateTime date = new DateTime(2002, 9, 1);
            gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            berekenController.Bereken();

            //Assert
            try
            {
                berekenController.Bereken();
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
