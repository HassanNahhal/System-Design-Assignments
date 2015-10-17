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
            MonopolyGame monopoly= new MonopolyGame();
            monopoly.PlayGame();
            Console.ReadKey();
        }
    }
}
