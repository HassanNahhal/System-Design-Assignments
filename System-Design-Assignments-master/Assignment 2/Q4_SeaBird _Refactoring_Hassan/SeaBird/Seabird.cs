using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBird 
{
    class Seabird : Seacraft, IAircraft
    {
        const int TAKEOFF_HEIGHT_M = 200;
        const int INCREASE_SPEED_STEP = 50;
        const int MAX_SPEED = 869;
        const int INCREASE_HIGHT_STEP = 500;
        public bool reachTakeOfArea;
        public bool reachDistination;
        public bool engineIsOn;
        public bool noseIsRaise;
        int speed;
        bool airborne;
        int height = 0;
        // A two-way adapter hides and routes the Target's methods
        //  Use Seacraft instructions to implement this one 
        public void TakeOff()
        {
            while (!Airborne)
                IncreaseRevs();
        }

        //Routes this straight back to the Aircraft
        public int Height
        {
            get { return height; }
        }

        //Creating this method is part of refactoring since it keeps each method performing
        //one specific function, making the IncreaseRevs() method within Seabird shorter
        public void IncreaseHeight()
        {
            //creating named constants for speedThreshold and heightIncreaseAmount
            //is part of refactoring
            const int SPEED_THRESHOLD_KMH = 40;
            const int HEIGHT_INCREASED_AMOUNT_M = 100;

            if (Speed > SPEED_THRESHOLD_KMH)
                height += HEIGHT_INCREASED_AMOUNT_M;
        }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            IncreaseHeight();
        }

        public bool Airborne
        {
            get
            {
                //Creating a named constant for takeOffHeight is part of refactoring
                const int TAKEOFF_HEIGHT_M = 50;
                return height > TAKEOFF_HEIGHT_M;
            }
        }

        ////////////////

        public void TurnEngineOn()
        {
            engineIsOn = true;
            speed = 0;
            height = 0;
            Console.WriteLine("Aircraft Engine is ON");
        }

        public void IncreaseSpeed()
        {
            speed += INCREASE_SPEED_STEP;
            Console.WriteLine("Aircraft increasing speed by " + INCREASE_SPEED_STEP + " Kph");
            Console.WriteLine("Aircraft current speed is " + speed + " Kph");
        }

        public void IncreaseSpeedToMax()
        {
            speed = MAX_SPEED;
            Console.WriteLine("Aircraft increasing speed to the maximum speed ");
            Console.WriteLine("Aircraft current speed is " + speed + " Kph");
        }

        public void ReachTakeOfArea()
        {
            reachTakeOfArea = true;
            Console.WriteLine("Aircraft reached the take off area");
        }

        public void Stop()
        {
            speed = 0;
            height = 0;
            Console.WriteLine("Aircraft stopped");
        }

        public void RaiseNose()
        {
            noseIsRaise = true;
            Console.WriteLine("Aircraft Raised it's Nose");
        }

        public void IncreaseHight()
        {
            height += INCREASE_HIGHT_STEP;
            Console.WriteLine("Aircraft increasing hight by " + INCREASE_HIGHT_STEP + " km");
            Console.WriteLine("Aircraft current hight is " + height + " Km");
        }

        public void Wait()
        {
            Console.WriteLine("Aircraft flying at constant speed and hight");
            System.Threading.Thread.Sleep(10000);
        }

        public void ReachDestination()
        {
            Console.WriteLine("Aircraft reached destination");
            reachDistination = true;
        }

        public void LowerNose()
        {
            Console.WriteLine("Aircraft lowered it's Nose");
            noseIsRaise = false;
        }

        public void DecreaseSpeed()
        {
            speed -= INCREASE_SPEED_STEP;
            Console.WriteLine("Aircraft decreased speed by " + INCREASE_SPEED_STEP + " Kph");
            Console.WriteLine("Aircraft current speed is " + speed + " Kph");
        }

        public void TurnEngineOff()
        {
            engineIsOn = false;
            speed = 0;
            height = 0;
            Console.WriteLine("Aircraft Engine is OFF");
        }
    }
}
