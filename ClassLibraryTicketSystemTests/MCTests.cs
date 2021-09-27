using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {

        [TestMethod()]
        public void BroBizzDiscountTrue()
        {
            //Act
            MC mc = new MC(true, new DateTime(2021, 09, 27));

            //Arrange
            double price = mc.TicketPrice;

            //Assert
            Assert.AreEqual(118.75, price);
        }

        [TestMethod()]
        public void BroBizzDiscountFalse()
        {
            //Act
            MC mc= new MC(false, new DateTime(2021, 09, 27));

            //Arrange
            double price = mc.TicketPrice;

            //Assert
            Assert.AreEqual(125.00, price);
        }

        //[TestMethod()]
        //public void PriceTest()
        //{
        //    //Act
        //    MC mc = new MC(true);

        //    //Arrange
        //    double price = mc.TicketPrice;

        //    //Assert
        //    Assert.AreEqual(118.75, price);
            
        //}

        [TestMethod()]
        public void VehicleTest()
        {
            //Act
            MC mc = new MC(true, new DateTime(2021, 09, 27));

            //Arrange
            string vehicle = mc.Vehicle();

            //Assert
            Assert.AreEqual("MC", vehicle);
            
        }
    }
}