using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace Oresundbron 
{
    public class OresundMC : BridgeCrossing
    {
        /// <summary>
        ///  This constructor inherits from the constructor in the BridgeCrossing class.
        /// </summary>
        /// <param name="broBizzDiscount"></param>
        /// <param name="date"></param>
        public OresundMC(bool broBizzDiscount, DateTime date) : base(broBizzDiscount, date)
        {

        }

        /// <summary>
        /// This method is inherited from the the BridgeCrossing base class
        /// and implemented here. It doesn't return anything.
        /// I just assigned the price to BasePrice (which is a property in BridgeCrossing).
        /// </summary>
        public override void Price()
        {
            BasePrice = 210;
        }

        /// <summary>
        /// This method is inherited from the the BridgeCrossing base class
        /// and implemented here.
        /// </summary>
        /// <returns>the type of vehicle</returns>
        public override string Vehicle()
        {
            return "Oresund MC";
        }

    }
}
