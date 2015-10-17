using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBird
{
    class Seacraft : ISeacraft
    {
        int speed = 0;
        //introducing a meaningfully named variable for 
        //the Increase amount is part of refactoring
        const int SPEED_INCREASED_STEP = 10;

        public virtual void IncreaseRevs()
        {
            speed += SPEED_INCREASED_STEP;
            Console.WriteLine("Seacraft engine increases revs to " + speed + " knots");
        }

        public int Speed
        {
            get { return speed; }
        }
    }
}
