using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class RailroadSquare : PropertySquare
    {
        private const string SQUARE_NAME = "RAILROAD Square";
        public RailroadSquare(int index, int price)
            : base(index, SQUARE_NAME+index, price)
        {
            Console.WriteLine(SQUARE_NAME + "is created at " + index);
        }

        public override int GetRent()
        {
            Console.WriteLine(SQUARE_NAME + " Get Rent");
            int c = this.owner.RRcount;
            return c * 25;
        }

        public override void BuyProperty(Player curPlayer)
        {
            base.BuyProperty(curPlayer);
            curPlayer.RRcount++;
            Console.WriteLine("RR Count Increased to " + curPlayer.RRcount);
        }
    }
}
