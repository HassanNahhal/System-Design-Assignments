using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class RegularSquare : Square
    {
        private const string SQUARE_NAME = "Regular Square:";
        public RegularSquare() { }
        public RegularSquare(int index)
            : base(index, SQUARE_NAME+index)
        {
            Console.WriteLine(SQUARE_NAME+ "is created at " + index);
        }

        public override void LandedOn(Player curPlayer)
        {
            Console.WriteLine(curPlayer.Name + " arrived at " + SQUARE_NAME);
        }
    }
}
