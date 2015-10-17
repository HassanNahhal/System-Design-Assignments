using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract class Square
    {
        protected string name;
        protected int index;
        public string Name
        {
            get { return name; }
        }
        public int Index
        {
            get{ return index; }
        }
        abstract public void LandedOn(Player curPlayer);

        protected Square() { }
        protected Square(int index, string name)
        {
            this.name = name;
            this.index = index;
        }
    }
}
