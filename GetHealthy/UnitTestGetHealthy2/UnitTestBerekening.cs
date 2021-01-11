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
            IGebruikerContainer gebruikerContainer = new GebruikerContainer();
            IUitkomstContainer uitkomstContainer = new UitkomstContainer();
            IProductContainer productContainer = new ProductContainer();
            IInvoerContainer invoerContainer = new InvoerContainer();

            BerekenController berekenController = new BerekenController(gebruikerContainer, uitkomstContainer, productContainer, invoerContainer);

            DateTime date = new DateTime(2002, 9, 1);
            gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            berekenController.Bereken();

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
        public void TestGebruikerFout()
        {
            GebruikerContainer gebruikerContainer = new GebruikerContainer();

            DateTime date = new DateTime(1987, 5, 11);
            gebruikerContainer.AddGebruiker(0, 15, 19, date.Date, 0, false, false);

            Assert.IsNull(gebruikerContainer.GetGebruiker());

            date = new DateTime(2019, 5, 11);
            gebruikerContainer.AddGebruiker(1, 300, 250, date.Date, 5, true, true);

            Assert.IsNull(gebruikerContainer.GetGebruiker());
        }

        [TestMethod]
        public void TestBerekeningGoedeGebruiker()
        {
            IGebruikerContainer gebruikerContainer = new GebruikerContainer();
            IUitkomstContainer uitkomstContainer = new UitkomstContainer();
            IProductContainer productContainer = new ProductContainer();
            IInvoerContainer invoerContainer = new InvoerContainer();

            BerekenController berekenController = new BerekenController(gebruikerContainer, uitkomstContainer, productContainer, invoerContainer);

            DateTime date = new DateTime(2002, 9, 1);
            gebruikerContainer.AddGebruiker(1, 60, 189, date.Date, 2, true, false);

            Assert.IsNotNull(gebruikerContainer.GetGebruiker());

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
