using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    public class Airline
    {
        private static Airline airlineInstatnce;

        private string name;

        //singleton Design patters
        //only one instance of Airline is allowed
        //lazy intialization
        public static Airline AirlineInstatnce ()
        {
            if ( airlineInstatnce == null )
            {
                airlineInstatnce = new Airline ();
            }

               return airlineInstatnce;
        }

        public Brand Brand
        {
            get
            {
                throw new System.NotImplementedException ();
            }
            set
            {
            }
        }

        public void AddAirline ()
        {
            throw new System.NotImplementedException ();
        }

        public void ViewAirline ()
        {
            throw new System.NotImplementedException ();
        }

        public void UpdateAirline ()
        {
            throw new System.NotImplementedException ();
        }

        public void DeleteAirline ()
        {
            throw new System.NotImplementedException();
        }

        public void AddBrand()
        {
            throw new System.NotImplementedException();
        }

        public void ViewBrand()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBrand()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBrand()
        {
            throw new System.NotImplementedException();
        }
    }
}


