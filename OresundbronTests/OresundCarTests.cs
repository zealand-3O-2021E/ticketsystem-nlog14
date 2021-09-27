using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void OresundBroBizzTrueCarTest()
        {
            //Act
            OresundCar ocar = new OresundCar(true, new DateTime(2021, 09, 27));

            //Arrange
            double price = ocar.TicketPrice;

            //Assert
            Assert.AreEqual(161.00, price);
        }

        [TestMethod()]
        public void OresundBroBizzFalseCarTest()
        {
            //Act
            OresundCar ocar = new OresundCar(false, new DateTime(2021, 09, 27));

            //Arrange
            double price = ocar.TicketPrice;

            //Assert
            Assert.AreEqual(410.00, price);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Act
            OresundCar ocar = new OresundCar(true, new DateTime(2021, 09, 27));

            //Arrange
            string actualVehicle = ocar.Vehicle();

            //Assert
            Assert.AreEqual("Oresund Car", actualVehicle);
        }
    }
}