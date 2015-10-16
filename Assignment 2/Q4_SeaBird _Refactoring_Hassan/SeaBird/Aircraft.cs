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
        const int LANDED_HEIGHT_M = 0;
        const int SPEED_STEP = 50;
        const int MAX_SPEED = 200;
        const int TAXI_SPEED = 50;
        const int STOPPING_SPEED = 0;
        const int MAX_HEIGHT = 2000;
        const int MID_HEIGHT = 1000;


        const int INCREASE_HEIGHT_STEP = 300;
        const int NOSE_ANGLE_TAKEOFF = 30;
        const int NOSE_ANGLE_LANDON = -30;
        public bool engineIsOn;
        int speed;
        int height;
        bool airborne;

        //we need to add nose angel too!!!!


        public void TakeOFF()
        {
            TurnEngineOn();
            Accelerate(TAXI_SPEED);
            ReachTakeOfArea();
            Stop();
            WaitForAck();//wait not flying
            IncreaseSpeedToMax();
            RaiseNose(NOSE_ANGLE_TAKEOFF);
            Wait();//to some height
            IncreaseHeight(MID_HEIGHT);
            Wait();
            IncreaseHeight(MAX_HEIGHT);

            
        }

        private void WaitForAck()
        {
            Console.WriteLine("Aircraft is waiting for ack");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("");
        }

        public void LandOn()
        {
            ReachDestination();
            //LowerNose(NOSE_ANGLE_LANDON);
            DecreaseHeight(LANDED_HEIGHT_M);
            Decelerate(TAXI_SPEED);         
            Decelerate(STOPPING_SPEED);
            TurnEngineOff();
        }
        public Aircraft()
        {
            height = 0;
            airborne = false;
        }


        public void TurnEngineOn()
        {
            engineIsOn = true;
            speed = 0;
            height = 0;
            Console.WriteLine("Aircraft Engine is ON");
        }

        public void Accelerate(int targetSpeed)
        {
            if (targetSpeed <= speed)
            {
                Console.WriteLine("Error! Aircraft's target speed is Smaller than current speed ");
                return;
            }

            while (speed < targetSpeed)
            {
                speed += SPEED_STEP;
                Console.WriteLine("Aircraft increasing speed by " + SPEED_STEP + " Kph");
                Console.WriteLine("Aircraft current speed is " + speed + " Kph");
                Wait();
            }
        }

        public void IncreaseSpeedToMax()
        {

            Accelerate(MAX_SPEED);

            Console.WriteLine("Aircraft increasing speed by " + SPEED_STEP + " Kph");
            Console.WriteLine("Aircraft current speed is " + speed + " Kph");
        }

        public void ReachTakeOfArea()
        {
            Console.WriteLine("Aircraft reached the take off area");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("Aircraft stopped");
        }

        public void RaiseNose(int targetAngle)
        {
            Console.WriteLine("Aircraft Raised it's Nose");
            height += (int)((double)speed * (double)targetAngle * 0.1);
            if ((height > TAKEOFF_HEIGHT_M) && (airborne == false))
            {
                airborne = true;
                Console.WriteLine("Aircraft is airbon state");
            }
        }

        public void IncreaseHeight(int targetHeight)
        {
            while (height < targetHeight)
            {
                RaiseNose(NOSE_ANGLE_TAKEOFF);
                Console.WriteLine("Aircraft is increasing its current height ");
            }

            height = targetHeight;
            Console.WriteLine("Aircraft reached target height is " + height + " m");
        }

        public void DecreaseHeight(int targetHeight)
        {
            while (height > targetHeight)
            {
                LowerNose(NOSE_ANGLE_LANDON);
                if (height < targetHeight)
                {
                    height = targetHeight;
                    break;
                }
                Console.WriteLine("Aircraft has decreased its current height to " + height);
            }

            Console.WriteLine("Aircraft reached target height is " + height + " m");
        }

        public void Wait()
        {
            System.Threading.Thread.Sleep(20);
            Console.WriteLine("");
        }

        public void ReachDestination()
        {
            Console.WriteLine("Aircraft reached destination");
        }

        public void LowerNose(int targetAngle)
        {
            Console.WriteLine("Aircraft lowered it's Nose");
            height += (int)((double)speed * (double)targetAngle * 0.1);
  //          Console.WriteLine("Aircraft current height: "+height);
            if ((height <= LANDED_HEIGHT_M) && (airborne == true))
            {
                height = 0;
                airborne = false;
                Console.WriteLine("Aircraft finish landing");
            }
           
        }

        public void Decelerate(int targetSpeed)
        {
            if (targetSpeed >= speed)
            {
                Console.WriteLine("Error! Aircraft's target speed is larger than current speed ");
                return;
            }

            while (targetSpeed < speed)
            {
                speed -= SPEED_STEP;
                Console.WriteLine("Aircraft decreased speed by " + SPEED_STEP + " Kph");
                Console.WriteLine("Aircraft current speed is " + speed + " Kph");
                Wait();
            }

            if (speed == 0)
                Stop();
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
