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
            var wateraData = new WaterData();

            var desktopDataDipslay = new DesktopDataDipslay(wateraData);
            var webDataDisplay = new WebDataDisplay(wateraData);
            var mobileDataDisplay = new MobileDataDisplay(wateraData);
            var thirdPartyDisplay = new ThirdPartyDisplay(wateraData);

            wateraData.SetMeasurements(80, 65, 30.4f);
            wateraData.SetMeasurements(82, 70, 29.2f);
            wateraData.SetMeasurements(78, 90, 29.2f);

            // Wait for user
            Console.ReadKey();

        }
    }
}
