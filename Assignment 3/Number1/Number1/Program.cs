using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade facade = new Facade();

            facade.ContolTheLab();


            facade.GetData(33, 12);
            facade.GetData(15, 45);
            facade.GetData(2, 77);


            // Wait for user
            Console.ReadKey();

        }
    }
}
