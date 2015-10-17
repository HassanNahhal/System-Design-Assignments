using System;
using EngineeringService;

namespace EngineeringService
{
    // Adaptee   
    public class Seacraft : ISeacraft
    {
        int speed = 0;
        int degree = 0;
        int accelerate = 1;
        int decelerate = 1;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Degree
        {
            get { return degree; }
        }

        public virtual void IncreaseRevs()
        {
            speed += accelerate;
            Console.WriteLine("Seacraft engine increases revs to " + speed + " knots");
        }

        public virtual void DecreaseRevs()
        {
            speed -= decelerate;
            Console.WriteLine("Seacraft engine decreases revs to " + speed + " knots");
        }

        public virtual void RaiseNose()
        {
            degree += 2;
            Console.WriteLine("Seacraft nose rises to " + degree + " degrees");
        }

        public virtual void LowerNose()
        {
            degree -= 2;
            Console.WriteLine("Seacraft nose lowers to " + degree + " degrees");
        }
        public int Accelerate
        {
            get { return accelerate; }
            set { accelerate = value; }
        }
        public int Decelerate
        {
            get { return decelerate; }
            set { decelerate = value; }
        }
    }
}
