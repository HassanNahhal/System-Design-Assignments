using System;
using EngineeringService;

// Two-way Adapter Pattern Pierre-Henri Kuate and Judith Bishop Aug 2007
// Embedded system for a SeaBird flying plane

namespace EngineeringService
{

    //ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; }
        void TakeOff();
        int Height { get; }
        int Speed { get; }
    }

    // Target 
    public sealed class Aircraft : IAircraft
    {
        const int TAKEOFF_HEIGHT_M = 200;
        const int SPEED_STEP_KMH = 10;
        const int MAX_SPEED_KMH = 500;
        int speed;
        int height;
        bool airborne;
        public Aircraft()
        {
            height = 0;
            speed = 0;
            airborne = false;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = TAKEOFF_HEIGHT_M; //metres
        }

        public void Accelerate()
        {
            Console.WriteLine("Aircraft accelerate");
            speed += SPEED_STEP_KMH;
            if (speed > MAX_SPEED_KMH)
                speed = MAX_SPEED_KMH;
        }

        public void Decelerate()
        {
            Console.WriteLine("Aircraft accelerate");
            speed -= SPEED_STEP_KMH;
            if (speed < 0)
                speed = 0;
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
}  // end of EngineeringService

//Adaptee interface
public interface ISeacraft
{
    int Speed { get; }
    void IncreaseRevs();
}

// Adaptee   
public class Seacraft : ISeacraft
{
    int speed = 0;
    //**Refactoring
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

//Adapter
public class Seabird : Seacraft, IAircraft
{
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
    //**Refactoring
    //Creating this method is part of refactoring since it keeps each method performing
    //one specific function, making the IncreaseRevs() method within Seabird shorter
    public void IncreaseHeight()
    {
        //**Refactoring
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
        get {
             //Creating a named constant for takeOffHeight is part of refactoring
             const int TAKEOFF_HEIGHT_M = 50;
             return height > TAKEOFF_HEIGHT_M; 
        }
    }
}

class InventorTest
{
    //**Refactoring
    //Refactoring Main method using Extract method by
    //TestAirCraftEngine(), TestSeaBirdEngine(), and IncreaseSpeedOfSeaBird(IAircraft seabird)
    //which can reduce the Cyclomatic Complexity to 1 from 3.
    static void Main()
    {
        // No adapter
        TestAirCraftEngine();

        // Classic usage of an Adapter
        IAircraft seabird = TestSeaBirdEngine();

        // Two-way adapter: using seacraft instructions on an IAircraft object
        // (where they are not in the IAricraft interface)
        IncreaseSpeedOfSeaBird(seabird);

        Console.ReadKey();
    }

    private static void TestAirCraftEngine()
    {
        // No adapter
        Console.WriteLine("Experiment 1: test the aircraft engine");
        IAircraft aircraft = new Aircraft();
        aircraft.TakeOff();
        if (aircraft.Airborne)
            Console.WriteLine("The aircraft engine is fine, flying at " + aircraft.Height + "metres");
    }
    private static IAircraft TestSeaBirdEngine()
    {
        // Classic usage of an Adapter
        Console.WriteLine("\nExperiment 2: Use the engine in the SeaBird");
        IAircraft seabird = new Seabird();
        seabird.TakeOff(); // and automatically increases speed
        Console.WriteLine("The SeaBird took off");
        return seabird;
    }
    private static void IncreaseSpeedOfSeaBird(IAircraft seabird)
    {
        Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
        (seabird as ISeacraft).IncreaseRevs();
        (seabird as ISeacraft).IncreaseRevs();
        if (seabird.Airborne)
            Console.WriteLine("Seabird flying at height " + seabird.Height +
                        " metres and speed " + (seabird as ISeacraft).Speed + " knots");
        Console.WriteLine("Experiments successful; the Seabird flies!");
    }
}

/* Output
Experiment 1: test the aircraft engine
Aircraft engine takeoff
The aircraft engine is fine, flying at 200metres

Experiment 2: Use the engine in the SeaBird
Seacraft engine increases revs to 10 knots
Seacraft engine increases revs to 20 knots
Seacraft engine increases revs to 30 knots
Seacraft engine increases revs to 40 knots
Seacraft engine increases revs to 50 knots
The SeaBird took off

Experiment 3: Increase the speed of the Seabird:
Seacraft engine increases revs to 60 knots
Seacraft engine increases revs to 70 knots
Seabird flying at height 300 metres and speed 70 knots
Experiments successful; the Seabird flies!
*/