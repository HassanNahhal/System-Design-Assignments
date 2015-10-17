  using System;

      // Two-Way Adapter Pattern  Pierre-Henri Kuate and Judith Bishop  Aug 2007
      // Embedded system for a Seabird flying plane

    // ITarget interface
    public interface IAircraft {
      bool Airborne {get;}
      void TakeOff(  );
      int Height {get;}
    }

    // Target
    public sealed class Aircraft : IAircraft {
      int height;
      bool airborne;
      public Aircraft(  ) {
        height = 0;
        airborne = false;
    }
    public void TakeOff (  ) {
      Console.WriteLine("Aircraft engine takeoff");
      airborne = true;
      height = 200; // Meters
    }
    public bool Airborne {
      get {return airborne;}
    }
    public int Height {
      get {return height;}
    }
  }

  // Adaptee interface
  public interface ISeacraft {
    int Speed {get;}
    void IncreaseRevs(  );
  }
  // Adaptee implementation
  public class Seacraft : ISeacraft {
    int speed = 0;

    public virtual void IncreaseRevs(  ) {
      speed += 10;
      Console.WriteLine("Seacraft engine increases revs to " + speed + " knots");
    }
    public int Speed {
      get {return speed;}
   }
 }

   // Adapter
   public class Seabird : Seacraft, IAircraft {
     int height = 0;
     // A two-way adapter hides and routes the Target's methods
     // Use Seacraft instructions to implement this one
     public void TakeOff(  ) {
       while (!Airborne)
         IncreaseRevs(  );
     }

     // Routes this straight back to the Aircraft
     public int Height {
       get {return height;}
     }

     // This method is common to both Target and Adaptee
     public override void IncreaseRevs(  ) {
       base.IncreaseRevs(  );
       if(Speed > 40)
           height += 100;
      }

      public bool Airborne {
        get {return height > 50;}
      }
   }

  class Experiment_MakeSeaBirdFly {
    static void Main (  ) {
      // No adapter
      Console.WriteLine("Experiment 1: test the aircraft engine");
      IAircraft aircraft = new Aircraft(  );
      aircraft.TakeOff(  );
      if (aircraft.Airborne) Console.WriteLine(
           "The aircraft engine is fine, flying at "
           +aircraft.Height+"meters");

      // Classic usage of an adapter
      Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");
      IAircraft seabird = new Seabird(  );
      seabird.TakeOff(  ); // And automatically increases speed
      Console.WriteLine("The Seabird took off");

      // Two-way adapter: using seacraft instructions on an IAircraft object
      // (where they are not in the IAircraft interface)
      Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
      (seabird as ISeacraft).IncreaseRevs(  );
      (seabird as ISeacraft).IncreaseRevs(  );
      if (seabird.Airborne)
        Console.WriteLine("Seabird flying at height "+ seabird.Height +
            " meters and speed "+(seabird as ISeacraft).Speed + " knots");
      Console.WriteLine("Experiments successful; the Seabird flies!");
     }
   }/* Output
 Experiment 1: test the aircraft engine
 Aircraft engine takeoff
 The aircraft engine is fine, flying at 200 meters

 Experiment 2: Use the engine in the Seabird
 Seacraft engine increases revs to 10 knots
 Seacraft engine increases revs to 20 knots
 Seacraft engine increases revs to 30 knots
 Seacraft engine increases revs to 40 knots
 Seacraft engine increases revs to 50 knots
 The Seabird took off

 Experiment 3: Increase the speed of the Seabird:
 Seacraft engine increases revs to 60 knots
 Seacraft engine increases revs to 70 knots
 Seabird flying at height 300 meters and speed 70 knots
 Experiments successful; the Seabird flies!
 */