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
    }

    // Target 
    public sealed class Aircraft : IAircraft
    {
        int height;
        bool airborne;
        public Aircraft()
        {
            height = 0;
            airborne = false;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = 200; //metres
        }

        public bool Airborne
        {
            get { return airborne; }
        }

        public int Height
        {
            get { return height; }
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
    //introducing a meaningfully named variable for 
    //the Increase amount is part of refactoring
    int speedIncreaseStep = 10;

    public virtual void IncreaseRevs()
    {
        speed += speedIncreaseStep;
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

    //Creating this method is part of refactoring since it keeps each method performing
    //one specific function, making the IncreaseRevs() method within Seabird shorter
    public void IncreaseHeight()
    {
        //creating named constants for speedThreshold and heightIncreaseAmount
        //is part of refactoring
        int speedThreshold = 40;
        int heightIncreaseAmount = 100;
        if (Speed > speedThreshold)
            height += heightIncreaseAmount;
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
             int takeOffHeight = 50;
             return height > takeOffHeight; }
    }
}

class InventorTest
{
    static void Main()
    {
        // No adapter
        Console.WriteLine("Experiment 1: test the aircraft engine");
        IAircraft aircraft = new Aircraft();
        aircraft.TakeOff();
        if (aircraft.Airborne)
            Console.WriteLine("The aircraft engine is fine, flying at " + aircraft.Height + "metres");

        // Classic usage of an Adapter
        Console.WriteLine("\nExperiment 2: Use the engine in the SeaBird");
        IAircraft seabird = new Seabird();
        seabird.TakeOff(); // and automatically increases speed
        Console.WriteLine("The SeaBird took off");

        // Two-way adapter: using seacraft instructions on an IAircraft object
        // (where they are not in the IAricraft interface)
        Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
        (seabird as ISeacraft).IncreaseRevs();
        (seabird as ISeacraft).IncreaseRevs();
        if (seabird.Airborne)
            Console.WriteLine("Seabird flying at height " + seabird.Height +
                        " metres and speed " + (seabird as ISeacraft).Speed + " knots");
        Console.WriteLine("Experiments successful; the Seabird flies!");

        Console.ReadKey();
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