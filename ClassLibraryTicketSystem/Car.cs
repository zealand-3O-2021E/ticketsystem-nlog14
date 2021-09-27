using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car: BridgeCrossing
    {

        /// <summary>
        /// This constructor inherits from the BridgeCrossing base class.
        /// </summary>
        /// <param name="broBizzDiscount"></param>
        public Car(bool broBizzDiscount, DateTime date) : base(broBizzDiscount, date)
        {
           
        }

        /// <summary>
        /// This method is inherited from the the BridgeCrossing base class
        /// and implemented here. It doesn't return anything.
        /// I just assigned the price to BasePrice (which is a property in BridgeCrossing).
        /// </summary>
        public override void Price()
        {
            BasePrice = 240.00 ;
        }

        /// <summary>
        /// This method is inherited from the the BridgeCrossing base class
        /// and implemented here.
        /// </summary>
        /// <returns>the type of vehicle</returns>
        public override string Vehicle()
        {
            return "Car";
        }

        ///// <summary>
        ///// This method is to calculate the weekend discount price.
        ///// It checks the day of the week and if it's the correct days it will apply the 20% off.
        ///// Otherwise it will apply the normal BasePrice.
        ///// It also checks if the BroBizz discount is applicable,
        ///// then applies the 5% discount to the new price after the 20% is discounted.
        ///// Otherwise it will not apply the 5% discount.
        ///// </summary>
        ///// <param name="broBizzDiscount"></param>
        ///// <returns></returns>
        //public override double CalculateDiscountPrice(bool broBizzDiscount)
        //{
        //    double WeekendDiscount;
        //    if (Date.DayOfWeek == DayOfWeek.Saturday ||
        //                               Date.DayOfWeek == DayOfWeek.Sunday)
        //    {
        //        WeekendDiscount = BasePrice - (BasePrice * 0.2);
        //    }
        //    else
        //    {
        //        WeekendDiscount = BasePrice;
        //    }
        //    if (broBizzDiscount == true)
        //    {
        //        return WeekendDiscount - (WeekendDiscount * Discount);
        //    }
        //    else
        //    {
        //        return WeekendDiscount;
        //    }
           
    }

    
}
