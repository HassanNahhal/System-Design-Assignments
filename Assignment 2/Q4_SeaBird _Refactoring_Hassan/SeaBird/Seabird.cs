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
        const int RAISE_NOSE_ANGLE_MAX = 90;
        const int RAISE_NOSE_ANGLE_MIN = 0;
        const int TAXI_SPEED = 50;



        public bool reachTakeOfArea;
        public bool reachDistination;
        public bool engineIsOn;
        public bool noseIsRaise;
        int speed;
        bool airborne;
        int height = 0;

        IAircraft aircraft = new Aircraft();

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
        /// <summary>
        /// /////////////////
        /// </summary>
        /// 

        public void LandOn()
        {
            aircraft.LandOn();
        }


        public void TakeOFF()
        {
            aircraft.TakeOFF();
         
        }



    }
}
