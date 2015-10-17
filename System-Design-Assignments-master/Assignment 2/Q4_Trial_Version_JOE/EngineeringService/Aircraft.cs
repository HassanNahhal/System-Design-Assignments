using System;
using EngineeringService;

namespace EngineeringService
{
    // Target 
    public sealed class Aircraft : IAircraft
    {
        int height;
        int nose;
        bool airborne;
        bool engineOn;
        bool landingGear;

        public Aircraft()
        {
            height = 0;
            airborne = false;
            landingGear = true;
            engineOn = false;
            nose = 0;
        }

        public bool Airborne
        {
            get { return airborne; }
        }

        public bool LandingGear
        {
            get { return landingGear; }
            set { landingGear = value; }
        }

        public int Height
        {
            get { return height; }
        }

        public bool EngineOn
        {
            get { return engineOn; }
        }

        public int Nose
        {
            get { return nose; }
            set { nose = value; }
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = 100; //metres
        }

        public void Fly(int heightFlyUp)
        {
            Console.WriteLine("Aircraft Flies");
            landingGear = false;
            height = 200; //metres
        }

        public void LandOn()
        {
            Console.WriteLine("Aircraft lands on");
            landingGear = true;
        }

        public void Start()
        {
            Console.WriteLine("Aircraft engine test finished");
            engineOn = true;
        }

        public void Stop()
        {
            Console.WriteLine("Aircraft stoped to move");
            engineOn = false;

        }

        public void TurnOn()
        {
            Console.WriteLine("Aircraft engines are turned on");
            engineOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Aircraft engines are turned off");
            engineOn = false;
        }
    }

}
