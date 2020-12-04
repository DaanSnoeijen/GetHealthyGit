using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GetHealthy;
using GetHealthy.Containers;

namespace UnitTestGetHealthy
{
    [TestClass]
    public class UnitTestInvoer
    {
        [TestMethod]
        public void TestAddInvoer()
        {
            //Act
            Program.invoerContainer.AddInvoer(2000, 50, 10, 50, 15, 35, 2);

            //Assert
            Assert.IsTrue(Program.invoerContainer.InvoerList.Count == 1);
        }
    }
}
