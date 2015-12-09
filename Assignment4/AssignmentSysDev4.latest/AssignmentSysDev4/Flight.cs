using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    public class Flight
    {
        private string flightNumber;
        private int flightDate;
        private Airport flightDeparture = new Airport ();
        private Airport flightArrival = new Airport ();
        private int flightTime;
        private int numberOfSeats;
        private int PlaneID;
        private FlightClass flightClass = new FlightClass ();

        public FlightClass FlightClass
        {
            get
            {
                throw new System.NotImplementedException ();
            }
            set
            {
            }
        }

        public string FlightNumber 
        {
            get
            {
                return flightNumber;
            }
            set
            {
                flightNumber = value;
            }
        }

        public Airport Airport
        {
            get
            {
                throw new System.NotImplementedException ();
            }
            set
            {
            }
        }

        public void ViewFlight ()
        {
            throw new System.NotImplementedException ();
        }

        public void DeleteFlight ()
        {
            throw new System.NotImplementedException ();
        }

        public void UpdateFlight ()
        {
            throw new System.NotImplementedException ();

        }

        public void AddFlight()
        {
            throw new System.NotImplementedException();
        }

        //Façade Design Pattern 
        public void AddFlightClass()
        {
            //throw new System.NotImplementedException ();
            flightClass.AddNewFlightClass();
        }

        //Facade Design Pattern 
        public void UpdateFlightClass()
        {
            //throw new System.NotImplementedException ();
            flightClass.UpdateFlightClass();
        }

        //Facade Design Pattern 
        public void DeleteFlightClass()
        {
            //throw new System.NotImplementedException ();
            flightClass.DeleteFlightClass();
        }

        //Façade Design Pattern 
        public void UpdateAirport()
        {
            //throw new System.NotImplementedException ();
            Airport.UpdateAirport();
        }

        
    }

    public abstract class FlightAndConnections
    {
        protected string _flightList;

        public FlightAndConnections(string name)
        {
            this._flightList = name;
        }
        public abstract void Add(Flight d);
        public abstract void Remove(Flight d);
        public abstract void Display(int indent);

    }

    class PrimitiveElement : FlightAndConnections
    {
        // Constructor
        public PrimitiveElement(string name)
            : base(name)
        {
        }

        public override void Add(Flight newFlight)
        {
            Console.WriteLine(
              "Cannot add to a PrimitiveElement");
        }

        public override void Remove(Flight wrongFlight)
        {
            Console.WriteLine(
              "Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
              new String('-', indent) + " " + base._flightList);
        }
    }

    class CompositeElement : FlightAndConnections
    {
        private List<Flight> elements =
          new List<Flight>();

        // Constructor
        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(Flight newConnection)
        {
            elements.Add(newConnection);
        }

        public override void Remove(Flight oldConnection)
        {
            elements.Remove(oldConnection);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
              "+ " + base._flightList);

            // Display each child element on this node
            foreach (Flight d in elements)
            {
               // d.Display(indent + 2);
                Console.WriteLine(
             new String('-', indent) + " " + d.FlightNumber);
            }
        }
    }
}


