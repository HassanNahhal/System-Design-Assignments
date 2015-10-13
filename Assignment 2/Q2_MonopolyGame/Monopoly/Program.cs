using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            int tmpValue=0;
            int totlalPlayers = 0;
            int totlalPlayerRound = 0;

            Console.WriteLine("*****************  Monopoly Game   *****************");

            //asks for input value of number of players
            do
            {
                SetNumberOfPlayers();
                inputValue = Console.ReadLine();

            } while (!int.TryParse(inputValue, out tmpValue) ||
                (int.Parse(inputValue) < 2 || int.Parse(inputValue) > 8));

            totlalPlayers = int.Parse(inputValue);

            //asks for inpt value of play-round
            do
            {
                SetPlayRound();
                inputValue = Console.ReadLine();

            } while (!int.TryParse(inputValue, out tmpValue) ||
                (int.Parse(inputValue) < 1 || int.Parse(inputValue) > 20));

            totlalPlayerRound = int.Parse(inputValue);

            //Create MonopolyGame Instance and do the play
            MonopolyGame monopolyGame = new MonopolyGame(totlalPlayers, totlalPlayerRound);

            Console.WriteLine("Please enter any key to continue...");
            Console.ReadKey();

        }

        private static void SetNumberOfPlayers()
        {
            Console.WriteLine("Please input the number of players [2 ~ 8].");
        }
        private static void SetPlayRound()
        {
            Console.WriteLine("Please input the number of Play-Round [1 ~ 20].");
        }
    }
}
