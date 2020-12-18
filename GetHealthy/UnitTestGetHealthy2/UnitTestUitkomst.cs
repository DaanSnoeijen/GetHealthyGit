using GetHealthy.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GetHealthy;

namespace UnitTestGetHealthy
{
    [TestClass]
    public class UnitTestUitkomst
    {
        [TestMethod]
        public void TestAddUitkomst()
        {
            //Arrange
            UitkomstContainer uitkomstContainer = Program.uitkomstContainer;

            //Act
            uitkomstContainer.AddUitkomst();

            //Assert
            Assert.IsTrue(uitkomstContainer.UitkomstList.Count == 1);
        }

        [TestMethod]
        public void TestUitkomstDatabase()
        {
            //Arrange
            UitkomstContainer uitkomstContainer = Program.uitkomstContainer;

            uitkomstContainer.AddUitkomst();

            //Act
            try
            {
                uitkomstContainer.AddToDatabase();
            }
            //Assert
            catch
            {
                Assert.Fail();
            }
        }
    }
}
