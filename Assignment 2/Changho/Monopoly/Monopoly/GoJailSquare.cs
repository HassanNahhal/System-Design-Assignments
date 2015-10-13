using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class GoJailSquare : Square
    {
        private const string SQUARE_NAME = "GO JAIL Square";
        Square jailSquare;
        public GoJailSquare(int index, Square jailSquare)
        : base(index, SQUARE_NAME+index)
        {
            this.jailSquare = jailSquare;
            Console.WriteLine("GO SQUARE is created at "+index);
        }

        public override void LandedOn(Player curPlayer)
        {
            Console.WriteLine(curPlayer.Name + " arrived at " + SQUARE_NAME);
            curPlayer.SetLocation(jailSquare);
            curPlayer.IsInJail = true;
            Console.WriteLine(curPlayer.Name + " is moved to JailCell $$");
        }
    }
}
