using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class IncomeTaxSquare : Square
    {
        private const string SQUARE_NAME = "INCOME TAX Square";
        public IncomeTaxSquare(int index)
            :base(index, SQUARE_NAME+index)
        {
            Console.WriteLine(SQUARE_NAME + "is created at " + index);
        }
        public override void LandedOn(Player curPlayer)
        {
            Console.WriteLine(curPlayer.Name + " arrived at " + SQUARE_NAME);
        }
    }
}
