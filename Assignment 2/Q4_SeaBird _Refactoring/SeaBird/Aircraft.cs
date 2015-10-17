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
        const int SPEED_STEP = 20;
        const int MAX_SPEED = 200;
        const int TAXI_SPEED = 40;
        const int STOPPING_SPEED = 0;
        const int MAX_HEIGHT = 2000;
        const int MID_HEIGHT = 1000;

        const int INCREASE_HEIGHT_STEP = 300;
        const int NOSE_ANGLE_TAKEOFF = 30;
        const int NOSE_ANGLE_LANDON = -30;
        const int MIN_ANGLE_NOSE = -60;
        const int MAX_ANGLE_NOSE = 80;
        public bool engineIsOn;
        int speed;
        int height;
        int angleNose;
        bool airborne;
        public Aircraft()
        {
            height = 0;
            angleNose = 0;
            speed = 0;
            airborne = false;
        }

        public void TakeOFF()
        {
            TurnEngineOn();
            Accelerate(TAXI_SPEED);
            ReachTakeOfArea();
            Stop();
            WaitForAck();
            IncreaseSpeedToMax();
            RaiseNose(NOSE_ANGLE_TAKEOFF);
            Wait();
            IncreaseHeight(MID_HEIGHT);
            Wait();
            IncreaseHeight(MAX_HEIGHT);
        }

        private void WaitForAck()
        {
            Console.WriteLine("\nAircraft is waiting for ack\n");
            System.Threading.Thread.Sleep(2000);
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


        private void TurnEngineOn()
        {
            engineIsOn = true;
            speed = 0;
            height = 0;
            Console.WriteLine("\nAircraft Engine is ON\n\n");
        }

        private void Accelerate(int targetSpeed)
        {
            if (targetSpeed <= speed)
            {
                Console.WriteLine("Error! Aircraft's target speed is Smaller than current speed ");
                return;
            }

            while (speed < targetSpeed)
            {
                speed = speed + SPEED_STEP;
                if (speed > targetSpeed) speed = targetSpeed;
                Console.WriteLine("Aircraft increasing speed by " + SPEED_STEP + " km/h");
                Console.WriteLine("Aircraft current speed is " + speed + " km/h");
                Wait();
            }
            Console.WriteLine("Aircraft reached target speed: " + speed + " km/h");
            Console.WriteLine("Aircraft maintains speed: " + speed + " km/h");
        }

        private void IncreaseSpeedToMax()
        {
            Accelerate(MAX_SPEED);
            Console.WriteLine("Aircraft reached MAX speed: " + MAX_SPEED + " km/h");
        }

        private void ReachTakeOfArea()
        {
            Console.WriteLine("Aircraft reached the take off area");
        }



        private void RaiseNose(int targetAngle)
        {
            if (targetAngle < MAX_ANGLE_NOSE)
            {
                angleNose = targetAngle;
                Console.WriteLine("Aircraft's Nose Angle: " + angleNose);
                height += (int)((double)speed * (double)targetAngle * 0.05);
                if ((height > TAKEOFF_HEIGHT_M) && (airborne == false))
                {
                    airborne = true;
                    Console.WriteLine("\nAircraft goes into airborne state\n");
                }
            }
            else
            {
                Console.WriteLine("Error! Angle will maintains its state: " + angleNose);
            }
        }

        private void IncreaseHeight(int targetHeight)
        {
            while (height < targetHeight)
            {
                RaiseNose(NOSE_ANGLE_TAKEOFF);
                if (height > targetHeight)
                {
                    height = targetHeight;
                }
                Console.WriteLine("Aircraft has increased its current height to " + height + " m");
            }
            Console.WriteLine("Aircraft reached target height is " + height + " m");
            RaiseNose(0);
            Console.WriteLine("Aircraft maintains its height " + height + " m\n");
        }

        private void LowerNose(int targetAngle)
        {
            if (targetAngle > MIN_ANGLE_NOSE)
            {
                angleNose = targetAngle;
                Console.WriteLine("Aircraft's Nose Angle: " + angleNose);
                height += (int)((double)speed * (double)targetAngle * 0.05);
                if ((height <= LANDED_HEIGHT_M) && (airborne == true))
                {
                    height = 0;
                    airborne = false;
                    Console.WriteLine("Aircraft was just landed\n");
                }
            }
            else
            {
                Console.WriteLine("Error! Angle will maintain its state: " + angleNose);
            }
           
        }

        private void DecreaseHeight(int targetHeight)
        {
            while (height > targetHeight)
            {
                LowerNose(NOSE_ANGLE_LANDON);
                if (height < targetHeight)
                {
                    height = targetHeight;
                }
                Console.WriteLine("Aircraft has decreased its current height to " + height + " m");
            }
            if (airborne == true)
            { 
                Console.WriteLine("Aircraft reached target height is " + height + " m");
                LowerNose(0);
                Console.WriteLine("Aircraft maintains its height " + height + " m\n");
            }
        }

        private void Wait()
        {
            System.Threading.Thread.Sleep(20);
            Console.WriteLine("");
        }

        private void ReachDestination()
        {
            Console.WriteLine("\n\nAircraft reached near destination\n\n");

        }

        private void Stop()
        {
            speed = 0;
            Console.WriteLine("Aircraft stopped");
        }

        private void Decelerate(int targetSpeed)
        {
            if (targetSpeed >= speed)
            {
                Console.WriteLine("Error! Aircraft's target speed is larger than current speed ");
                return;
            }

            while (speed > targetSpeed)
            {
                speed -= SPEED_STEP;
                if (speed < targetSpeed) speed = targetSpeed;
                Console.WriteLine("Aircraft decreased speed by " + SPEED_STEP + " km/h");
                Console.WriteLine("Aircraft current speed is " + speed + " km/h");
                Wait();
            }
            if (speed == 0)
            { 
                Stop();
            }
            else 
            { 
                Console.WriteLine("Aircraft reached target speed: " + speed + " km/h");
                Console.WriteLine("Aircraft maintains speed: " + speed + " km/h");
            }
            
        }

        private void TurnEngineOff()
        {
            engineIsOn = false;
            speed = 0;
            height = 0;
            Console.WriteLine("\n\nAircraft Engine is OFF\n\n");
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
