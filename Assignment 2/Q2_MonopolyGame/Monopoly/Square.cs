using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public abstract class Square
    {
        private int index;
        private string name;

        public Square(string _name, int _index) {
            this.name = _name;
            this.index = _index;
        }

        public abstract void LandedOn(Player p);

        public int Index {
            get { return index; }
        }

        public string Name 
        {
            get { return name; }
        }
    }
}