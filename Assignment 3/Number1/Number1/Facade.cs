using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class Facade
    {
        private WaterData _waterData;
        private Controller _controller;


        public Facade()
        {
            _waterData = new WaterData();
            _controller = new Controller();

        }

        public void ContolTheLab()
        {
            Console.WriteLine();
            Console.WriteLine("---Controller---");
            _controller.MoveLeft();
            _controller.MoveRight();
            _controller.MoveForward();

        }

        public void GetData(int temperature,float quality)
        {
            Console.WriteLine();

            Console.WriteLine("---WaterData---");

            var wateraData = new WaterData();

            var desktopDataDipslay = new DesktopDataDipslay(wateraData);
            var webDataDisplay = new WebDataDisplay(wateraData);
            var mobileDataDisplay = new MobileDataDisplay(wateraData);
            var thirdPartyDisplay = new ThirdPartyDisplay(wateraData);

            wateraData.SetMeasurements(temperature, quality);


        }
    }
}

