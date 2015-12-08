using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentSysDev4
{
    /// An executive employee may want to create a batch of employee Accounts al at once
    /// Sometimes companies will hire people for lower level jobs in groups so they
    /// can go through orientation and training as a group. 
    class Program
    {

        static void Main(string[] args)
        {
            

            Employee Executive = new Employee();
           
            Executive.CreateNewEmployeeAccounts();

            Airline AirKitchener = new Airline();
        }
    }
}
