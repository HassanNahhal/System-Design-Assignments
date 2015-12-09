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

            Brand AirCanada = new Brand();
            AirCanada.Name = "Air Canada";

            //Brand Air Canada has 19 Boeing 777-300ER, 6 Boeing 777-200LR, 8 Airbus A330-300, 22 Boeing 787-9, and 15 Boeing 787-8 aircrafts

          
           AirCanada.AddPlanes(1, 19);           

           Console.ReadKey();
          
           AirCanada.AddPlanes(2, 6);
           AirCanada.AddPlanes(3, 8);
           AirCanada.AddPlanes(4, 22);
           AirCanada.AddPlanes(5, 15);

           Console.ReadKey();

          // Air Canada Express operates 15 Embraer E175, 16 Bombardier CRJ705, 25 Bombardier CRJ200, and 21 Bombardier Q400

           Brand AirCanadaExpress = new Brand();
           AirCanadaExpress.Name = "Air Canada Express";

           AirCanadaExpress.AddPlanes(6, 15);
           AirCanadaExpress.AddPlanes(7, 16);
           AirCanadaExpress.AddPlanes(8, 25);
           AirCanadaExpress.AddPlanes(9, 21);

           Console.ReadKey();

           //Air Canada Rouge operates 9 Boeing 767-300ER and 20 Airbus A319-100 aircraft.

           Brand AirCanadaRouge = new Brand();
           AirCanadaRouge.Name = "Air Rouge";

           AirCanadaExpress.AddPlanes(10, 9);
           AirCanadaExpress.AddPlanes(11, 20);

           Console.ReadKey();

        }
    }
}
