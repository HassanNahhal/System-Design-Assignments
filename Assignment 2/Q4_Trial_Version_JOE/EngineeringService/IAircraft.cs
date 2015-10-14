using System;
using EngineeringService;

namespace EngineeringService
{
    //ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; }
        void TakeOff();
        int Height { get; }
        bool LandingGear { get; set; }
        bool EngineOn { get; }
        int Nose { get; set; }
        void LandOn();
        void Start();
        void Stop();
        void Fly(int heightFlyUp);
        void TurnOn();
        void TurnOff();
    }
}

/* Output
Experiment 1: test & turn on the aircraft engine
Aircraft engine test finished
Aircraft engines are turned on
Experiment 2: Seabird move to the takeoff area
Accelerates the Seabird engine to 10 knots
Seacraft engine increases revs to 2 knots
Seacraft engine increases revs to 4 knots
Seacraft engine increases revs to 6 knots
Seacraft engine increases revs to 8 knots
Seacraft engine increases revs to 10 knots
Seabird was alined to the takeoff
Seabird waits for a wihile
Experiment 3: Seabird begins takeoff process
Seacraft engine increases revs to 15 knots
Seacraft engine increases revs to 20 knots
Seacraft engine increases revs to 25 knots
Seacraft engine increases revs to 30 knots
Seacraft engine increases revs to 35 knots
Seacraft engine increases revs to 40 knots
Seacraft nose rises to 2 degrees
Seacraft engine increases revs to 45 knots
Seacraft nose rises to 4 degrees
Seacraft engine increases revs to 50 knots
Seacraft nose rises to 6 degrees
Seacraft engine increases revs to 55 knots
Seacraft nose rises to 8 degrees
Seacraft engine increases revs to 60 knots
Seacraft nose rises to 10 degrees
Aircraft took off
Experiment 4: Seabird Flies up till 500 meter height
Seabird flying up at height 50 metres and speed 70 knots
Seabird flying up at height 100 metres and speed 80 knots
Seabird flying up at height 150 metres and speed 90 knots
Seabird flying up at height 200 metres and speed 100 knots
Seabird flying up at height 300 metres and speed 110 knots
Seabird flying up at height 400 metres and speed 120 knots
The Seabird stoped flying up, and continues to fly at 500 metres and 120 knots
Experiment 5: Seabird Flies up once more till 1000 meter height
Seabird flying up at height 500 metres and speed 135 knots
Seabird flying up at height 600 metres and speed 150 knots
Seabird flying up at height 700 metres and speed 165 knots
Seabird flying up at height 800 metres and speed 180 knots
Seabird flying up at height 900 metres and speed 195 knots
The Seabird stoped flying up, and continues to fly at 1000 metres and 195 knots
Experiment 6: Seabird begins landing process
Seabird flying up at height 950 metres and speed 180 knots
Seabird flying up at height 800 metres and speed 165 knots
Seabird flying up at height 650 metres and speed 150 knots
Seabird flying up at height 500 metres and speed 135 knots
Seabird flying up at height 350 metres and speed 120 knots
Seabird flying up at height 300 metres and speed 105 knots
Seabird flying up at height 250 metres and speed 90 knots
Seabird flying up at height 200 metres and speed 75 knots
Seabird flying up at height 150 metres and speed 60 knots
Seabird flying up at height 100 metres and speed 45 knots
Seabird flying up at height 75 metres and speed 45 knots
Seabird flying up at height 50 metres and speed 45 knots
Seabird flying up at height 25 metres and speed 45 knots
Seabird flying up at height 0 metres and speed 45 knots
Experiment 7: The Seabird decreases the speed of engines to 0
Seacraft engine decreases revs to 30 knots
Seacraft engine decreases revs to 15 knots
Seacraft engine decreases revs to 0 knots
Seabird engines speed reaches 0
Experiment 8: Turn off the engines
Seabird engines are turned off
    */
