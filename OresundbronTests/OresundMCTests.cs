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
    public class OresundMCTests
    {
        [TestMethod()]
        public void OresundBroBizzTrueMCTest()
        {
            //Act
            OresundMC omc = new OresundMC(true, new DateTime(2021, 09, 27));

            //Arrange
            double price = omc.TicketPrice;

            //Assert
            Assert.AreEqual(73.00, price);
        }

        [TestMethod()]
        public void OresundBroBizzFalseMCTest()
        {
            //Act
            OresundMC omc = new OresundMC(false, new DateTime(2021, 09, 27));

            //Arrange
            double price = omc.TicketPrice;

            //Assert
            Assert.AreEqual(210.00, price);
        }



        [TestMethod()]
        public void VehicleTest()
        {
            //Act
            OresundMC omc = new OresundMC(true, new DateTime(2021, 09, 27));

            //Arrange
            string actualVehicle = omc.Vehicle();

            //Assert
            Assert.AreEqual("Oresund MC", actualVehicle);
        }
    }
}