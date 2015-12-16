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
        private bool delinquent = false; 

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

        public bool Delinquent
        {
            get { return delinquent; }
            set
            {
                delinquent = value;
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

        public void ViewAccountInfo(bool employeeInd, bool delinquentStatus)
        {
           //throw new System.NotImplementedException();

            if (employeeInd)
            {
                Facade.CustomerDataView();
                Facade.EmployeeDataView(delinquentStatus);

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
            internal string EmployeeView(bool DelinquentStatus)
            {
                return "Customer's full account data, customer is delinquent: " + DelinquentStatus;
            }

            internal string SimulateCustomerView()
            {
                return "Simulated Customer view of account data";
            }

        }


        /// <summary>
        /// A Facade is used here to allow Employees to see Detailed information about accounts,
        /// while customers have their own view of their account.  This will allow the system
        /// to do things like allowing employees to simulate a customer's view and see data
        /// only to be shared with employees.  
        /// </summary>
        public static class Facade
        {
            static CustomerViewAccount a = new CustomerViewAccount();
            static EmployeeViewAccount b = new EmployeeViewAccount();

            public static void CustomerDataView()
            {
                Console.WriteLine("** Customer's own view of their account**");
                Console.WriteLine(a.AccountData());

            }

            public static void EmployeeDataView(bool DelinquentStatus)
            {
                Console.Write("** Employee View of an account **");
                Console.WriteLine(b.EmployeeView(DelinquentStatus));
                Console.WriteLine(b.SimulateCustomerView());
            }
        }

        public void UpdateAccount()
        {
            throw new System.NotImplementedException();
        }
    }
}


