using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    public class Account
    {
        private string email;
        private string password;
        private int lName;
        private int fName;
        private int ID;
        private Ticket Ticket;
        private bool employeeInd = false;

        public Ticket Ticket1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public bool EmployeeInd
        {
            get
            {
                return employeeInd;
                //throw new System.NotImplementedException();
            }
            set
            {
                employeeInd = value;
            }
        }

        public void ViewAccountInfo(bool employeeInd)
        {
           //throw new System.NotImplementedException();

            if (employeeInd)
            {
                Facade.CustomerDataView();
                Facade.EmployeeDataView();

            }
            else
            {
                Facade.CustomerDataView();
                
            }

            Console.ReadKey();
        }

        internal class CustomerViewAccount
        {


            internal string AccountData()
            {
                return "Your own account data";
            }

        }

        internal class EmployeeViewAccount
        {
            internal string EmployeeView()
            {
                return "Customer's full account data";
            }

            internal string SimulateCustomerView()
            {
                return "Customer view of account data";
            }

        }



        public static class Facade
        {
            static CustomerViewAccount a = new CustomerViewAccount();
            static EmployeeViewAccount b = new EmployeeViewAccount();

            public static void CustomerDataView()
            {
                Console.WriteLine(a.AccountData());

            }

            public static void EmployeeDataView()
            {
                Console.WriteLine(b.EmployeeView());
                Console.WriteLine(b.SimulateCustomerView());
            }


        }




        public void UpdateAccount()
        {
            throw new System.NotImplementedException();
        }
    }
}


