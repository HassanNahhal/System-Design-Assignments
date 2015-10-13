using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class UtilitySquare : PropertySquare
    {
        public UtilitySquare(string _name, int _index) : base(_name, _index)
        {
            Console.WriteLine("Square[{0}] named {1} created.", _index, _name);
        }

        public override void LandedOn(Player p) {}
    }
}