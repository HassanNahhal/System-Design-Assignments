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
}


