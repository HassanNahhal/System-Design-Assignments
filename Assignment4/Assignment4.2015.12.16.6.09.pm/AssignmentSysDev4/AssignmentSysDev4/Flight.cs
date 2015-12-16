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
        public string name;
        private FlightClass flightClass = new FlightClass ();

        public virtual void Add(Flight newFlight) {}
        public virtual void Remove(Flight newFlight) { }

        public virtual void Display(int indent) { }
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
           
            flightClass.AddNewFlightClass();
        }

        //Facade Design Pattern 
        public void UpdateFlightClass()
        {
           
            flightClass.UpdateFlightClass();
        }

        //Facade Design Pattern 
        public void DeleteFlightClass()
        {
           
            flightClass.DeleteFlightClass();
        }

        //Façade Design Pattern 
        public void UpdateAirport()
        {
           
            Airport.UpdateAirport();
        }

        
    }
    
    /// <summary>
    /// Flights can be primitive elements within the use of the
    /// composite pattern.  This is because we wish to make lists
    /// of flights that offer alternative connections based on
    /// times, stopover times, etc. so customers have choices.
    /// </summary>
    class PrimitiveElement : Flight {
        // Constructor
        public PrimitiveElement(Flight newFlight)
            : base()
        {
            this.name = newFlight.name;
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
              new String('-', indent) + " " + base.name);
        }
    }

    /// <summary>
    /// Flights can also be used as Composite elements because one flight
    /// might be 'fixed', i.e. the customer has a narrow window of possible
    /// departure times at some point in their journey, but the primitive elements
    /// added to the list of the Composite element will be flights that are 
    /// possible connections.  The Composite pattern is used here because
    /// it allows for this kind of things, i.e. having a list of items with
    /// associated branches or 'leaf' items, and having the data grouped
    /// this way for flights will allow the system to show alternative
    /// flights to complete a journey.  
    /// </summary>
    class CompositeElement : Flight
    {
        private List<Flight> elements =
          new List<Flight>();

        // Constructor
        public CompositeElement(Flight baseFlight)
            : base()
        {
            this.name = baseFlight.name;
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
              "+ " + base.name);

            // Display each child element on this node
            foreach (Flight d in elements)
            {
                
                d.Display(indent + indent);
              
            }
        }
    }
}


