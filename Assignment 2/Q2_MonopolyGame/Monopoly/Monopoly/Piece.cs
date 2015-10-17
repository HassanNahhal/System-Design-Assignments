using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Piece
    {
        private Square location;
        public Square Location
        {
            get {return location;}
            set {this.location = value;}
        }

        public Piece(Square location)
        {
            this.location = location;
        }
    }
}
