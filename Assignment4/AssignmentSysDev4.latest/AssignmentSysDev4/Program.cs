using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentSysDev4
{
    /// An executive employee may want to create a batch of employee Accounts all at once
    /// Sometimes companies will hire people for lower level jobs in groups so they
    /// can go through orientation and training as a group. 
    class Program
    {

        /// <summary>
        /// This main method will call various classes that demonstrate different design patterns.  These include
        /// Singleton, Facade, Composite, Factory and Strategy.
        /// Airline is Singleton
        /// Adding planes to a Brand uses Factory
        /// Getting a list of possible connecting flights uses Composite
        /// Facade is used to control Employees versus Customers and what they can do.
        /// Tickets use Strategy pattern to reflect the different cancellation policies.  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            

            Employee Executive = new Employee();
           
            Executive.CreateNewEmployeeAccounts();

            Airline AirCanadaLine = new Airline();

            
            Brand AirCanada = new Brand();
            AirCanada.Name = "AirCanada";
            AirCanadaLine.AddBrand(AirCanada);
            //AirCanada.Name = "Air Canada";

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
           AirCanadaExpress.Name = "AirCanadaExpress";
           AirCanadaLine.AddBrand(AirCanadaExpress);
           //AirCanada.Name = "Air Canada";


          // Brand AirCanadaExpress = new Brand();
          // AirCanadaExpress.Name = "Air Canada Express";

           AirCanadaExpress.AddPlanes(6, 15);
           AirCanadaExpress.AddPlanes(7, 16);
           AirCanadaExpress.AddPlanes(8, 25);
           AirCanadaExpress.AddPlanes(9, 21);

           Console.ReadKey();

           //Air Canada Rouge operates 9 Boeing 767-300ER and 20 Airbus A319-100 aircraft.


           Brand AirCanadaRouge = new Brand();
           AirCanadaRouge.Name = "AirCanadaRouge";
           AirCanadaLine.AddBrand(AirCanadaRouge);          

           AirCanadaRouge.AddPlanes(10, 9);
           AirCanadaRouge.AddPlanes(11, 20);

           Console.ReadKey();

           Account Employee = new Account();
           Employee.EmployeeInd = true;

           Employee.ViewAccountInfo(Employee.EmployeeInd);

           Account Customer = new Account();
           Customer.ViewAccountInfo(Customer.EmployeeInd);

           Ticket economyTicket = new Ticket();
           economyTicket.PurchaseDate = DateTime.Now;
           economyTicket.SetCancelStrategy(new EconomyCancel());
           economyTicket.Cancel();           

           Ticket premiumEconomyTicket = new Ticket();
           premiumEconomyTicket.PurchaseDate = DateTime.Now;
           premiumEconomyTicket.SetCancelStrategy(new PremiumEconomyCancel());
           premiumEconomyTicket.Cancel();

           Ticket businessClassTicket = new Ticket();
           businessClassTicket.PurchaseDate = DateTime.Now;
           businessClassTicket.SetCancelStrategy(new BusinessClassCancel());
           businessClassTicket.Cancel();

           Flight newStartFlight = new Flight();
           newStartFlight.FlightNumber = "1";

           Flight possibleConnection1 = new Flight();
           possibleConnection1.FlightNumber = "2";

           Flight possibleConnection2 = new Flight();
           possibleConnection2.FlightNumber = "3";

           CompositeElement root = new CompositeElement("TorontoToLondon");
           
           root.Add(newStartFlight);
           root.Add(possibleConnection1);
           root.Add(possibleConnection2);

           root.Display(2);

           

           Console.ReadKey();

        }
    }
}
