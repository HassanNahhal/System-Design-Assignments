using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class PropertySquare : Square
    {
        protected int price;
        public PropertySquare(string _name, int _index) : base(_name, _index){}

        public abstract override void LandedOn(Player p);
    }
}