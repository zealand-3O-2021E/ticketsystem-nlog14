using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// This is the base class from which the Car and MC classes and the library classes inherit.
    /// </summary>
    public abstract class BridgeCrossing
    {
        public string _licensePlate;

        public DateTime Date { get; set; } = DateTime.Now;
        public double Discount { get; private set; }
        public double TicketPrice { get; set; }
        public double BasePrice { get; set; }
       

        /// <summary>
        /// This constructor initializes the Brobizz discount and the date when a Car or MC object is created.
        /// It also takes the Price() from each vehicle class and uses it to calculate the discounted price to be paid,
        /// which becomes the TicketPrice.
        /// </summary>
        /// <param name="broBizzDiscount"></param> 
        ///
        public BridgeCrossing(bool broBizzDiscount, DateTime date)
        {
                Price();
                Discount = 0.05;
                Date = date;
                if (Vehicle().Contains("Oresund Car") || Vehicle().Contains("Oresund MC"))
                {
                    TicketPrice = OresundBroBizzPrice(broBizzDiscount);
                }
                else
                {
                     TicketPrice = CalculateDiscountPrice(broBizzDiscount);
                }
        }

        /// <summary>
        /// This is a property for the license plate.
        /// It must only be 7 characters long,
        /// otherwise it will throw an exception.
        /// </summary>
        public string LicensePlate
        {
            get { return _licensePlate;}
            set
            {
                _licensePlate = value;

                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate number must only contain 7 characters.");
                }
            }
        }

        /// <summary>
        /// Checks if the user is a Brobizz user then
        /// calculates the the price to be paid accordingly.
        /// BasePrice is the price of each vehicle that is set in the corresponding classes.
        /// Made this a virtual method so it can be overrided in the Car class to implement the
        /// weekend discount.
        /// </summary>
        /// <returns>The result of the calculation to get the price after discount.</returns>
        public virtual double CalculateDiscountPrice(bool broBizzDiscount)
        {
            if (broBizzDiscount == true)
            {
                return BasePrice - (BasePrice * Discount);
            }
            else
            {
                return BasePrice;
            }
        }


        public double OresundBroBizzPrice(bool broBizzDiscount)
        {
            if (broBizzDiscount == true && BasePrice == 410.00)
            {
                TicketPrice = 161.00;
                return TicketPrice;
            }
            if (broBizzDiscount == true && BasePrice == 210.00)
            {
                TicketPrice = 73.00;
                return TicketPrice;
            }
            else
            {
                return BasePrice;
            }
        }

        /// <summary>
        /// This is inherited and implemented by the different types of vehicle classes and other library classes.
        /// </summary>
        public abstract void Price();

        /// <summary>
        /// This is inherited and implemented by the different types of vehicle classes and other library classes.
        /// </summary>
        public abstract string Vehicle();

    }
}
