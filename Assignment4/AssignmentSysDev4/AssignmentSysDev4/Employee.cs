using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{


   
    public class Employee : Account
    {
        public void AddPlane()
        {
            throw new System.NotImplementedException();
        }

        public void AddClassFlight()
        {
            throw new System.NotImplementedException();
        }

        public void SchedulaFlight()
        {
            throw new System.NotImplementedException();
        }

        public void AddAirCraft()
        {
            throw new System.NotImplementedException();
        }

        public void AddFlight()
        {
            throw new System.NotImplementedException();
        }

        public void CreateEmployeeAccount()
        {
            throw new System.NotImplementedException();            
        }
             


        public void CreateNewEmployeeAccounts()
        {
            //throw new System.NotImplementedException();

            Creator myCreator = new Creator();
            IEmployee Administrator1 = myCreator.FactoryMethod(1);
            Console.WriteLine("New employee 1 has title: " + Administrator1.GetTitle());
            //Console.ReadKey();
            IEmployee Manager1 = myCreator.FactoryMethod(2);
            Console.WriteLine("New employee 2 has title:" + Manager1.GetTitle());
            //Console.ReadKey();
            IEmployee Clerk1 = myCreator.FactoryMethod(3);
            Console.WriteLine("New employee 3 has title: " + Clerk1.GetTitle());
            Console.ReadKey();
        }
    }
}

