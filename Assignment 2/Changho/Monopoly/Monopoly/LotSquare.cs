using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class LotSquare : PropertySquare
    {
        private const string SQUARE_NAME = "LOT Square";
        public LotSquare(int index, int price)
            : base(index, SQUARE_NAME + index, price)
        {
            Console.WriteLine(SQUARE_NAME + " is created at " + index);
        }

        public override int GetRent()
        {
            Console.WriteLine(SQUARE_NAME + "Get Rent");
            return this.index;
        }
    }
}
