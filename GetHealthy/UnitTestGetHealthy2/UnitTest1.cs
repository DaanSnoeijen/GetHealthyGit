using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetHealthy;
using System;

namespace UnitTestGetHealthy2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalorieën()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleCalorieën < 2500 && Program.uitkomstContainer.UitkomstList[0].maximaleCalorieën > 1500);
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].minimaleCalorieën < 2500 && Program.uitkomstContainer.UitkomstList[0].minimaleCalorieën > 1500);
        }

        [TestMethod]
        public void TestTotaleVetten()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleTotaleVetten < 150 && Program.uitkomstContainer.UitkomstList[0].maximaleTotaleVetten > 20);
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].minimaleTotaleVetten < 150 && Program.uitkomstContainer.UitkomstList[0].minimaleTotaleVetten > 20);
        }

        [TestMethod]
        public void TestVerzadigdeVetten()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleVerzagdigdeVetten < 100 && Program.uitkomstContainer.UitkomstList[0].maximaleVerzagdigdeVetten > 0);
        }

        [TestMethod]
        public void TestKoolhydraten()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleKoolhydraten < 500 && Program.uitkomstContainer.UitkomstList[0].maximaleKoolhydraten > 150);
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].minimaleKoolhydraten < 500 && Program.uitkomstContainer.UitkomstList[0].minimaleKoolhydraten > 150);
        }

        [TestMethod]
        public void TestSuikers()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleSuikers < 150 && Program.uitkomstContainer.UitkomstList[0].maximaleSuikers > 0);
        }

        [TestMethod]
        public void TestEiwitten()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleEiwitten < 300 && Program.uitkomstContainer.UitkomstList[0].maximaleEiwitten > 0);
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].minimaleEiwitten < 300 && Program.uitkomstContainer.UitkomstList[0].minimaleEiwitten > 0);
        }

        [TestMethod]
        public void TestZouten()
        {
            //Arrange
            DateTime date = new DateTime(2002, 9, 1);
            Program.gebruikerContainer.AddGebruiker(1, 65, 190, date.Date, 2, true, false);

            //Act
            Program.berekenController.Bereken();

            //Assert
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].maximaleZouten < 9 && Program.uitkomstContainer.UitkomstList[0].maximaleZouten > 0);
            Assert.IsTrue(Program.uitkomstContainer.UitkomstList[0].minimaleZouten < 9 && Program.uitkomstContainer.UitkomstList[0].minimaleZouten > 0);
        }

        [TestMethod]
        public void TestInvoerToDatabase()
        {
            //Act
            Program.invoerContainer.AddInvoer(2000, 50, 10, 50, 15, 35, 2);

            //Assert
            Assert.IsTrue(Program.invoerContainer.InvoerList.Count == 1);
        }
    }
}
