using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetHealthy;
using GetHealthy.Containers;
using GetHealthy.Controllers;
using GetHealthy.Interfaces;
using System;
using GetHealthy.Models;

namespace UnitTestGetHealthy
{
    [TestClass]
    public class UnitTestBerekening
    {
        [TestMethod]
        public void TestVoedingsWaardes()
        {
            //Arrange
            BerekenController berekenController = new BerekenController();

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

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleCalorieën < 2500 && uitkomstContainer.UitkomstList[0].maximaleCalorieën > 1500);
            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].minimaleCalorieën < 2500 && uitkomstContainer.UitkomstList[0].minimaleCalorieën > 1500);

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleTotaleVetten < 150 && uitkomstContainer.UitkomstList[0].maximaleTotaleVetten > 20);
            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].minimaleTotaleVetten < 150 && uitkomstContainer.UitkomstList[0].minimaleTotaleVetten > 20);

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleVerzadigdeVetten < 100 && uitkomstContainer.UitkomstList[0].maximaleVerzadigdeVetten > 0);

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleKoolhydraten < 500 && uitkomstContainer.UitkomstList[0].maximaleKoolhydraten > 150);
            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].minimaleKoolhydraten < 500 && uitkomstContainer.UitkomstList[0].minimaleKoolhydraten > 150);

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleSuikers < 150 && uitkomstContainer.UitkomstList[0].maximaleSuikers > 0);

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleEiwitten < 300 && uitkomstContainer.UitkomstList[0].maximaleEiwitten > 0);
            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].minimaleEiwitten < 300 && uitkomstContainer.UitkomstList[0].minimaleEiwitten > 0);

            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].maximaleZouten < 9 && uitkomstContainer.UitkomstList[0].maximaleZouten > 0);
            //Assert.IsTrue(uitkomstContainer.UitkomstList[0].minimaleZouten < 9 && uitkomstContainer.UitkomstList[0].minimaleZouten > 0);
        }
    }
}
