using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class JailSquare : Square
    {
        private const string SQUARE_NAME = "JAIL Square";
        public JailSquare(int index)
            : base(index, SQUARE_NAME+index)
        {
            Console.WriteLine("GO SQUARE is created at "+index);
        }

        public override void LandedOn(Player curPlayer)
        {
            Console.WriteLine(curPlayer.Name + " arrived at " + SQUARE_NAME);
            curPlayer.IsInJail = true;
        }
    }
}
