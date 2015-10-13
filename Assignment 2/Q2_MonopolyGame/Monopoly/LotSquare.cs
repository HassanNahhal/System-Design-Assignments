using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class LotSquare : PropertySquare
    {
        public LotSquare(string _name, int _index) : base(_name, _index)
        {
            Console.WriteLine("Square[{0}] {1} was created.", _index, _name);
        }
        public override void LandedOn(Player p) {}
    }
}