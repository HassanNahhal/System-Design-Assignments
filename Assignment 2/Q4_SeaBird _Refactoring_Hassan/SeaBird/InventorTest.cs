using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBird
{
    class InventorTest
    {
        //Refactoring Main method using Extract method by
        //TestAirCraftEngine(), TestSeaBirdEngine(), and IncreaseSpeedOfSeaBird(IAircraft seabird)
        //which can reduce the Cyclomatic Complexity to 1 from 3.
        static void Main()
        {
            // No adapter
            TestAirCraftEngine();
            /*
            // Classic usage of an Adapter
            IAircraft seabird = TestSeaBirdEngine();

            // Two-way adapter: using seacraft instructions on an IAircraft object
            // (where they are not in the IAricraft interface)
            IncreaseSpeedOfSeaBird(seabird);
            */
            Console.ReadKey();
        }

        private static void TestAirCraftEngine()
        {

            IAircraft aircraft = new Aircraft();
            aircraft.TakeOFF();
            aircraft.LandOn();
            /*
            const int MIN_SPEED_TO_LAND = 100;
            const int MAX_HIGHT = 1100;
            IAircraft aircraft = new Aircraft();
            aircraft.TurnEngineOn();
            
            aircraft.Accelerate();
            aircraft.ReachTakeOfArea();
            aircraft.Stop();
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine();

            aircraft.IncreaseSpeedToMax();
            aircraft.RaiseNose();
            aircraft.TakeOff();
            aircraft.Wait();

            while (aircraft.Height < MAX_HIGHT)
            {
                aircraft.IncreaseHeight();
                aircraft.Wait();
            }

            aircraft.ReachDestination();
            aircraft.LowerNose();
            while(aircraft.Speed>MIN_SPEED_TO_LAND)
            {
                aircraft.Decelerate();
                aircraft.Wait();
            }
            
            aircraft.Stop();
            aircraft.TurnEngineOff();
            */
            /*
            // No adapter
            Console.WriteLine("Experiment 1: test the aircraft engine");
            IAircraft aircraft = new Aircraft();
            aircraft.TakeOff();
            if (aircraft.Airborne)
                Console.WriteLine("The aircraft engine is fine, flying at " + aircraft.Height + "metres");
                */
        }
        private static IAircraft TestSeaBirdEngine()
        {
            // Classic usage of an Adapter
            Console.WriteLine("\nExperiment 2: Use the engine in the SeaBird");
            IAircraft seabird = new Seabird();
            //seabird.TakeOff(); // and automatically increases speed
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
}
