using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class MonopolyGame
    {
        const int ROUNDS_TOTAL = 40;
        const int PLAYERS_TOTAL = 2;
        Board board = Board.Instance;
        Cup cup = Cup.Instance;
        List<Player> players = new List<Player>();
        public List<Player> Players
        {
            get{return players;}
        }

        public MonopolyGame()
        {
            const int INIT_CASH = 2000; 
            Player p;
            p = new Player("Horse", cup, board, INIT_CASH);
            players.Add(p);
            p = new Player("Cars", cup, board, INIT_CASH);
            players.Add(p);
        }

        public void PlayGame()
        {
            for (int i = 0; i< ROUNDS_TOTAL; i++)
            {
                Console.WriteLine("==========");
                Console.WriteLine("Round:"+i);
                Console.WriteLine("==========");
                PlayRound();
            }
        }

        private void PlayRound()
        {
            foreach (Player player in players)
            {
                if (player.IsInJail)
                {
                    Console.WriteLine(player.Name + " is in Jail Cell. So this turn will be skipped");
                    player.IsInJail = false;
                    continue;
                }
                player.TakeTurn();
                Console.ReadKey();
            }
        }

    }
}
