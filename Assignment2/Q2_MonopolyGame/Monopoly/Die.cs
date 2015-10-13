using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Die
    {
        private int faceValue = 0;
        private static readonly Random random = new Random();

        public int FaceValue
        {
            get{return faceValue;}
        }

        public void Roll() {

            faceValue = random.Next(1, 7);

            Console.WriteLine("Die was rollded.");
            Console.WriteLine("Die face Value: " + faceValue.ToString());
        }
    }
}
