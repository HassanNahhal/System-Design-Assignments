using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Piece
    {
        private string name;
        private Square location;

        public Piece(Square _square, string _name) {
            this.location = _square;
            this.name = _name;
        }

        public string Name
        {
            get { return name; }
        }

        public Square Location {
            get { return location; }
            set { location = value; }
        }
    }
}