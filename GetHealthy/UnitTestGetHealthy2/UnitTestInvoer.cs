using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GetHealthy;
using GetHealthy.Containers;
using GetHealthy.Interfaces;
using GetHealthy.Models;

namespace UnitTestGetHealthy
{
    [TestClass]
    public class UnitTestInvoer
    {
        [TestMethod]
        public void TestAddInvoer()
        {
            //Arrange
            InvoerContainer invoerContainer = new InvoerContainer();

            //Act
            invoerContainer.AddInvoer(2000, 50, 10, 50, 15, 35, 2);

            //Assert
            Assert.IsTrue(invoerContainer.Invoer() != null);
        }
    }
}
