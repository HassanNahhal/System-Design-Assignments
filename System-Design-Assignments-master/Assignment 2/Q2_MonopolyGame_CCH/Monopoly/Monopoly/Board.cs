using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    sealed class Board
    {
        private const int BOARD_SIZE = 40;
        private const int NUM_OF_SQUARE = 40;

        private const int FIX_SQUARE_PRICE = 2000;
        private const int FIX_RENT_PRICE = 500;
        private const int UTILITY_PRICE = 100;
        private const int RAILROAD_PRICE = 300;
        private const int LOTSQUARE_PRICE = 200;

        private const int GOSQUARE_INDEX = 0;
        private const int INCOMETAXSQUARE_INDEX = 4;
        private const int JAILSQUARE_INDEX = 10;
        private const int UTILITYSQUARE1_INDEX = 15;
        private const int RAILROADSQUARE1_INDEX = 20;
        private const int UTILITYSQUARE2_INDEX = 22;
        private const int RAILROADSQUARE2_INDEX = 28;
        private const int GOTOJAIL_INDEX = 30;
        private const int LOTSQUARE_INDEX = 35;

        List<Square> Squares = new List<Square> ();

        private Board() 
        {
            BuildSquare();
        }
        private static readonly Board instance = new Board();
        public static Board Instance
        {
            get { return instance; }
        }

        public Square GetSquare(Square start, int distance)
        {
            int endIndex = (start.Index + distance) % BOARD_SIZE;
            return (Square)Squares.ElementAt(endIndex);
        }
        //Overloading GetSquare
        public Square GetSquare(int distance)
        {
            int endIndex = distance % BOARD_SIZE;
            return (Square)Squares.ElementAt(endIndex);
        }

        public Square GetStartSquare()
        {
            return (Square)Squares.ElementAt(0);
        }

        private void BuildSquare()
        {
            for (int index = 0; index < NUM_OF_SQUARE; index++)
            {
                switch (index)
                {
                    case GOSQUARE_INDEX:
                        Squares.Add(new GoSqaure(index));
                        break;
                    case INCOMETAXSQUARE_INDEX:
                        Squares.Add(new IncomeTaxSquare(index));
                        break;
                    case JAILSQUARE_INDEX:
                        Squares.Add(new JailSquare(index));
                        break;
                    case GOTOJAIL_INDEX:
                        Squares.Add(new GoJailSquare(index, GetSquare(JAILSQUARE_INDEX)));
                        break;
                    case UTILITYSQUARE1_INDEX:
                    case UTILITYSQUARE2_INDEX:
                        Squares.Add(new UtilitySquare(index, UTILITY_PRICE));
                        break;
                    case RAILROADSQUARE1_INDEX:
                    case RAILROADSQUARE2_INDEX:
                        Squares.Add(new RailroadSquare(index,RAILROAD_PRICE));
                        break;
                    case LOTSQUARE_INDEX:
                        Squares.Add(new LotSquare(index,LOTSQUARE_PRICE));
                        break;
                    default:
                        Squares.Add(new RegularSquare(index));
                        break;
                }
            }
        }
    }
}
