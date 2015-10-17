using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Player
    {
        private string name;
        private Piece piece;
        private Die[] dice;
        private Board board;
        private int cash;

        public Player(string _name, Die[] _dice, Board _board, int _cash) {
            this.name = _name;
            this.dice = _dice;
            this.board = _board;
            this.cash = _cash;
            this.piece = new Piece(board.GetStartSquare(), this.name);
        }

        public string Name
        {
            get {return name;}
        }

        public int Cash
        {
            get{return cash;}
            set{cash = value;}
        }

        public void TakeTurn() {
            //Roll Die
            int totalFaceValues = RollDice();

            //Move piece to new location of square
            Square newLocation = board.GetSquare(piece.Location, totalFaceValues);
            piece.Location = newLocation;

            Console.WriteLine("\nMoved a {0}'s piece to {1}th square.\n", 
                piece.Name , (piece.Location.Index).ToString());

            //Player lands on the square
            newLocation.LandedOn(this);
        }

        private int RollDice() {

            int totalFaceValues = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
                totalFaceValues += dice[i].FaceValue;
            }
            return totalFaceValues;
        }

    }
}