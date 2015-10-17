using System;
using EngineeringService;

namespace EngineeringService
{
    class InventorTest
    {
        static void Main()
        {
            IAircraft aircraft = new Aircraft();

            Console.WriteLine("Experiment 1: test & turn on the aircraft engine");            
            aircraft.Start();
            aircraft.TurnOn();

            IAircraft seabird = new Seabird();

            Console.WriteLine("Experiment 2: Seabird move to the takeoff area");
            seabird.Start();            
            Console.WriteLine("Seabird was alined to the takeoff");
            Console.WriteLine("Seabird waits for a wihile");

            Console.WriteLine("Experiment 3: Seabird begins takeoff process");
            seabird.TakeOff();
            Console.WriteLine("Aircraft took off");

            Console.WriteLine("Experiment 4: Seabird Flies up till 500 meter height");
            int heightFlyUp = 500;
            seabird.Fly(heightFlyUp);
            if (seabird.Height >= heightFlyUp)
                Console.WriteLine("The Seabird stoped flying up, and continues to fly at " +
                    seabird.Height + " metres and " + (seabird as ISeacraft).Speed + " knots");

            Console.WriteLine("Experiment 5: Seabird Flies up once more till 1000 meter height");
            heightFlyUp = 1000;
            seabird.Fly(heightFlyUp);
            if (seabird.Height >= heightFlyUp)
                Console.WriteLine("The Seabird stoped flying up, and continues to fly at " +
                    seabird.Height + " metres and " + (seabird as ISeacraft).Speed + " knots");

            Console.WriteLine("Experiment 6: Seabird begins landing process");
            seabird.LandOn();

            Console.WriteLine("Experiment 7: The Seabird decreases the speed of engines to 0");
            seabird.Stop();

            Console.WriteLine("Experiment 8: Turn off the engines");
            seabird.TurnOff();

            Console.ReadKey();
        }
    }
}
