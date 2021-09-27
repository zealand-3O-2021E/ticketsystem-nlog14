using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : BridgeCrossing
    {
        /// <summary>
        /// This constructor inherits from the BridgeCrossing base class.
        /// </summary>
        /// <param name="broBizzDiscount"></param>
        public MC(bool broBizzDiscount, DateTime date) : base(broBizzDiscount, date)
        {

        }


        /// <summary>
        /// This method is inherited from the the BridgeCrossing base class
        /// and implemented here. It doesn't return anything.
        /// I just assigned the price to BasePrice (which is a property in BridgeCrossing).
        /// </summary>
        public override void Price()
        {
            BasePrice = 125.00;
        }

        /// <summary>
        /// This method is inherited from the the BridgeCrossing base class
        /// and implemented here.
        /// </summary>
        /// <returns>the type of vehicle</returns>
        public override string Vehicle()
        {
            return "MC";
        }
    }
}
