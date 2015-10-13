using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class MonopolyGame
    {
        private const int INITIAL_CASH = 2000;
        private int roundCount = 0;
        private Board board = Board.Instance;
        private Die[] dice = { new Die(), new Die() };
        private List<Player> players;
        
        public MonopolyGame(int _numberOfPlayers, int _playRound)
        {
            //Get the number of players by User
            CreatePlayers(_numberOfPlayers);

            //Get the number of play-round by User
            PlayGame(_playRound);
        }

        private void CreatePlayers(int _numberOfPlayers)
        {
            players = new List<Player>(_numberOfPlayers);

            for(int i = 0; i < _numberOfPlayers; i++)
            {
                players.Add(new Player("Player " + (i+1).ToString(), dice, 
                    board, INITIAL_CASH));

                Console.WriteLine(players.ElementAt(i).Name + " was created.");
            }
        }

        public void PlayGame(int _totalRound)
        {
            //play the MonoPoly Game through give total round
            for (int i = 0; i < _totalRound; i++)
            {
                Console.WriteLine("\nPlay Round: " + (i + 1).ToString());
                PlayRound();

                roundCount++;   //counts the play-round
            }
        }

        public void PlayRound()
        {
            //given number of players take turn per each round
            for(int i = 0; i < players.Count; i++)
            {
                Player currentPlayer = players.ElementAt(i);
                Console.WriteLine("\n{0} took turn.\n", currentPlayer.Name);
                currentPlayer.TakeTurn();
            }
        }
    }
}