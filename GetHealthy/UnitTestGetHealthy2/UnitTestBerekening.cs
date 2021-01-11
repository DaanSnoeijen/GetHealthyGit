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
        public void TestVoedingswaardes()
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

        [TestMethod]
        public void TestGebruiker()
        {
            //Arrange
            IGebruikerContainer gebruikerContainer = new GebruikerContainer();
            IUitkomstContainer uitkomstContainer = new UitkomstContainer();
            IProductContainer productContainer = new ProductContainer();
            IInvoerContainer invoerContainer = new InvoerContainer();

            BerekenController berekenController = new BerekenController(gebruikerContainer, uitkomstContainer, productContainer, invoerContainer);

            DateTime date = new DateTime(1987, 5, 11);
            gebruikerContainer.AddGebruiker(0, 15, 19, date.Date, 0, false, false);

            //Act
            try
            {
                berekenController.Bereken();

                //Assert
                Assert.Fail();
            }
            catch
            {
                
            }

            Assert.IsFalse(gebruikerContainer.GetGebruiker().activiteit);

            date = new DateTime(2019, 5, 11);
            gebruikerContainer.AddGebruiker(1, 300, 250, date.Date, 5, true, true);

            //Act
            try
            {
                berekenController.Bereken();

                //Assert
                Assert.Fail();
            }
            catch
            {
                
            }

            Assert.IsTrue(gebruikerContainer.GetGebruiker().activiteit);
        }
    }
}
