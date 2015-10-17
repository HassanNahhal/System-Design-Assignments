using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Die
    {
        private const int MAX_NUMBER = 6;
        private const int MIN_NUMBER = 1;
        private int faceValue;
        public  int FaceValue
        {
            get { return faceValue; }
        }
        private Random random = new Random();

        public Die()
        {
            DieRoll();
        }
        public void DieRoll()
        {
             faceValue = random.Next(MIN_NUMBER, MAX_NUMBER);
        }
    }
}
