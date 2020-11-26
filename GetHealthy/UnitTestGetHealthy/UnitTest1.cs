using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetHealthy;

namespace UnitTestGetHealthy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVoedingswaardes()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsFalse(Program.uitkomstContainer.UitkomstList[0].maximaleCalorieën > 2500 && Program.uitkomstContainer.UitkomstList[0].maximaleCalorieën < 1500);
            Assert.IsFalse(Program.uitkomstContainer.UitkomstList[0].minimaleCalorieën > 1500 && Program.uitkomstContainer.UitkomstList[0].minimaleCalorieën < 500);
        }

        [TestMethod]
        public void test()
        {

        }
    }
}
