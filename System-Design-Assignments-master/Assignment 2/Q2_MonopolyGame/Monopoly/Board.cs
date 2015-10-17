using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public sealed class Board
    {
        private const int SQUARE_SIZE = 40;
        private const int GO_SQUARE = 0;
        private const int INCOMTAX_SQUARE = 10;
        private const int REGULAR_SQUARE = 15;
        private const int RAILROAD_SQUARE = 20;
        private const int UTILITY_SQUARE = 30;

        private List<Square> squares = new List<Square>(SQUARE_SIZE);

        private static readonly Board instance = new Board();

        public static Board Instance
        {
            get { return instance; }
        }

        private Board() {
            CreateSquares();
        }

        private void CreateSquares() {
            //create 40 squares
            for (int i = 0; i < SQUARE_SIZE; i++) {
                switch (i) {
                    case GO_SQUARE:
                        squares.Add(new GoSquare("Go Square", i));
                        break;
                    case INCOMTAX_SQUARE:
                        squares.Add(new IncomeTaxSquare("IncomeTax Square", i));
                        break;
                    case REGULAR_SQUARE:
                        squares.Add(new RegularSquare("Regular Square", i));
                        break;
                    case RAILROAD_SQUARE:
                        squares.Add(new RailroadSquare("RailRoad Square", i));
                        break;
                    case UTILITY_SQUARE:
                        squares.Add(new UtilitySquare("Utility Square", i));
                        break;
                    default:
                        squares.Add(new LotSquare("Lot Square", i));
                        break;
                }                
            }
        }

        public Square GetSquare(Square currentSquare, int dieFaceValues) {
            int nextIndex = (currentSquare.Index + dieFaceValues) % SQUARE_SIZE;
            return squares.ElementAt(nextIndex);
        }

        public Square GetStartSquare() {
            return squares.ElementAt(GO_SQUARE);
        }
    }
}