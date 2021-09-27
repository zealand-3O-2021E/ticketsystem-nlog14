using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void BroBizzDiscountTrue()
        {
            //Act
            Car car = new Car(true, new DateTime(2021, 09, 27));

            //Arrange
            double price = car.TicketPrice;

            //Assert
            Assert.AreEqual(228.00, price);
        }

        [TestMethod()]
        public void BroBizzDiscountFalse()
        {
            //Act
            Car car = new Car(false, new DateTime(2021, 09, 27));

            //Arrange
            double price = car.TicketPrice;

            //Assert
            Assert.AreEqual(240.00, price);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateLengthTest()
        {
            //Act
            Car car = new Car(true, new DateTime(2021, 09, 27));

            //Arrange
            car.LicensePlate = "ABC12345";

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Act
            Car car = new Car(true, new DateTime(2021, 09, 27));

            //Arrange
            string actualVehicle = car.Vehicle();

            //Assert
            Assert.AreEqual("Car", actualVehicle);
        }

        //[TestMethod()]
        //public void CalculateDiscountPriceBrobizzTrueTest()
        //{
        //    //Act
        //    Car car = new Car(true, new DateTime(2021, 09, 26));

        //    //Arrange
        //    double price = car.TicketPrice;

        //    //Assert
        //    Assert.AreEqual(182.4, price);
        //}

        //public void CalculateDiscountPriceBrobizzFalseTest()
        //{
        //    //Act
        //    Car car = new Car(false, new DateTime(2021, 09, 26));

        //    //Arrange
        //    double price = car.TicketPrice;

        //    //Assert
        //    Assert.AreEqual(192, price);
        //}
    }
}