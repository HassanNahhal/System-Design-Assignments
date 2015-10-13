using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Player
    {
        private string name;
        public string Name
        {
            get{ return name; }
        }
        private int cash;
        public int Cash 
        {
            get { return cash; }
        }
        private Piece piece;
        private Board board;
        private Cup cup;
        private int rrcount;
        public int RRcount
        {
            set 
            {
                if (value >= 0) rrcount = value;
            }
            get { return rrcount; }

        }
        private bool isInJail;
        public bool IsInJail 
        {
            get { return isInJail; }
            set { isInJail = value; }
        }
        public Player(string name, Cup cup, Board board, int cash)
        {
            this.name = name;
            this.cup = cup;
            this.board = board;
            this.cash = cash;
            piece = new Piece(board.GetStartSquare());
            Console.WriteLine("Name:" + name + "Created");
            this.rrcount = 0;
        }
        
        public Square GetLocation()
        {
            return piece.Location;
        }

        public void SetLocation(Square square)
        {
            piece.Location = square;
        }

        public void TakeTurn()
        {
            int rollTotal = 0;

            cup.Roll();
            rollTotal = cup.FaceTotal; ;
            
            Console.WriteLine("Name:" + name + " take turn");
            Square newLoc = board.GetSquare(piece.Location, rollTotal);
            Console.WriteLine("Name:" + name + " is moved from " + piece.Location.Name+" to "+newLoc.Name);
            piece.Location = newLoc;
            piece.Location.LandedOn(this);
        }

        public void AddCash(int amount)
        {
            this.cash += amount;
        }

        public bool ReduceCash(int amount)
        {
            this.cash -= amount;
            if (this.cash < 0)
            {
                Console.WriteLine(this.name+" is shortage of money by "+Math.Abs(this.cash));
                return false;
            }
            return true;
        }

        //By expert law, AttemptPurchase is at player's member.
        public bool AttemptPurchase(PropertySquare properySquare)
        {
            if (this.cash > properySquare.Price)
            {
                properySquare.Owner = this;
                this.ReduceCash(properySquare.Price);
                Console.WriteLine("Congratulation!!  " + this.name + " will own " + properySquare.Name);
                Console.WriteLine("This property costs $" + properySquare.Price + " and current cash of player is $" + this.cash);
                return true;
            }
            else
            {
                Console.WriteLine("Unfortunately it is not possible buy due to cash shortage ");
                return false;
            }
        }
    }
}
