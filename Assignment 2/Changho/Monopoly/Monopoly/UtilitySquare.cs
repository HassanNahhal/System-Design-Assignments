using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class UtilitySquare : PropertySquare
    {
        private const string SQUARE_NAME = "UTILITY Square";
        public UtilitySquare(int index, int price)
            : base(index, SQUARE_NAME+index, price)
        {
            Console.WriteLine(SQUARE_NAME + "is created at " + index);
        }

        public override int GetRent()
        {
            //Due to Cup is singleton, hope same value with current player
            Cup cup = Cup.Instance;
            Console.WriteLine(SQUARE_NAME + "Get Rent");
            return cup.FaceTotal * 4;
        }
    }
}
