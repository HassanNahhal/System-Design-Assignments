using System;
using EngineeringService;

namespace EngineeringService
{
    //Adapter
    public class Seabird : Seacraft, IAircraft
    {
        int nose = 0;
        int height = 0;
        bool engineOn = false;
        bool landingGear = true;

        //Routes this straight back to the Aircraft
        public int Height
        {
            get { return height; }
        }

        public bool Airborne
        {
            get { return Degree > 9; }
        }
        public bool LandingGear
        {
            get { return landingGear; }
            set { landingGear = value; }
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
        public void Start()
        {
            Console.WriteLine("Accelerates the Seabird engine to 10 knots");
            while (Speed < 10)
            {
                base.Speed += Accelerate;
                base.IncreaseRevs();
            }
            Accelerate = 5;
        }
        public void TurnOn()
        {
            Console.WriteLine("Seabird engines are turned on");
            engineOn = true;
        }

        // A two-way adapter hides and routes the Target's methods
        //  Use Seacraft instructions to implement this one 
        public void TakeOff()
        {
            while (!Airborne)
            {
                base.IncreaseRevs();
                if (Speed >= 40)
                {
                    RaiseNose();
                }
            }
            if (Airborne)
            {
                height += 50;
                Accelerate = 10;
            }
        }

        public void Fly(int heightFlyUp)
        {
            while (height < heightFlyUp)
            {
                IncreaseRevs();

                if (height >= 200)
                {
                    landingGear = false;
                    height += 100;
                }
                else
                {
                    height += 50;
                }
            }
            Accelerate = 15;
        }

        public void LandOn()
        {
            while (height > 0)
            {
                if (height > 500)
                {
                    DecreaseRevs();
                    height -= 100;
                }
                else
                {
                    DecreaseRevs();
                }
                if (height <= 100)
                {
                    landingGear = true;
                }
            }
        }

        public void Stop()
        {
            while (Speed > 0)
            {
                base.DecreaseRevs();
            }
            Console.WriteLine("Seabird engines speed reaches 0");
        }

        public void TurnOff()
        {
            Console.WriteLine("Seabird engines are turned off");
            engineOn = false;
        }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.Speed += Accelerate;
            Console.WriteLine("Seabird flying up at height " + height +
                            " metres and speed " + Speed + " knots");
        }

        public override void DecreaseRevs()
        {
            Decelerate = Accelerate;
            if (Speed > 50)
            {
                base.Speed -= Decelerate;
                height -= 50;
            }
            else
            {
                height -= 25;
            }

            Console.WriteLine("Seabird flying up at height " + height +
                            " metres and speed " + Speed + " knots");
        }

        public override void RaiseNose()
        {
            base.RaiseNose();
        }

        public override void LowerNose()
        {

        }
    }
}
