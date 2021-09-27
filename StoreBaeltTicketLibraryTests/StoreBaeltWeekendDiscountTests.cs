using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltWeekendDiscountTests
    {

        [TestMethod()]
        public void CalculateDiscountPriceBrobizzTrueTest()
        {
            //Act
            StoreBaeltWeekendDiscount SBWD = new StoreBaeltWeekendDiscount(true, new DateTime(2021, 09, 26));

            //Arrange
            double price = SBWD.TicketPrice;

            //Assert
            Assert.AreEqual(182.4, price);
        }

        [TestMethod()]
        public void CalculateDiscountPriceBrobizzFalseTest()
        {
            //Act
            StoreBaeltWeekendDiscount SBWD = new StoreBaeltWeekendDiscount(false, new DateTime(2021, 09, 26));

            //Arrange
            double price = SBWD.TicketPrice;

            //Assert
            Assert.AreEqual(192, price);
        }


        [TestMethod()]
        public void VehicleTest()
        {
            //Act
            StoreBaeltWeekendDiscount SBWD = new StoreBaeltWeekendDiscount(true, new DateTime(2021, 09, 27));

            //Arrange
            var actualVehicle = SBWD.Vehicle();

            //Assert
            Assert.AreEqual("Car", actualVehicle);
        }
    }
}