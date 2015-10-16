using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBird
{
    sealed class Aircraft : IAircraft
    {
        const int TAKEOFF_HEIGHT_M = 200;
        const int INCREASE_SPEED_STEP = 100;
        const int MAX_SPEED = 400;
        const int INCREASE_HIGHT_STEP = 300;
        public bool reachTakeOfArea;
        public bool reachDistination;
        public bool engineIsOn;
        public bool noseIsRaise;
        int speed;
        int height;
        bool airborne;

        public Aircraft()
        {
            height = 0;
            airborne = false;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft takeoff");
            airborne = true;
            height = TAKEOFF_HEIGHT_M; //metres
        }

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
            Console.WriteLine("Aircraft increasing hight by " + INCREASE_HIGHT_STEP + " m");
            Console.WriteLine("Aircraft current hight is " + height + " m");
        }

        public void Wait()
        {
            Console.WriteLine("Aircraft flying at constant speed and hight");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("");
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

        public bool Airborne
        {
            get { return airborne; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Speed
        {
            get { return speed; }
        }
    }
}
