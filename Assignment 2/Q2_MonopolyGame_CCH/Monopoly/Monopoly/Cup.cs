using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    sealed class Cup
    {
        private int faceTotal;
        public int FaceTotal
        {
            get { return faceTotal; }
        }
        private Die[] dice = {new Die(), new Die()};

        private Cup() { }
        private static readonly Cup instance = new Cup();
        public static Cup Instance
        {
            get { return instance; }
        }

        public void Roll()
        {
            faceTotal = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].DieRoll();
                faceTotal += dice[i].FaceValue;
                Console.WriteLine(i + ": Die = " + dice[i].FaceValue);
            }
            Console.WriteLine("Total: " + faceTotal);
        }
    }
}
