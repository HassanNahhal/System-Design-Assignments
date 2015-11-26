using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class DesktopDataDipslay : IObserver, IDisplay
    {
        private string _quality;
        private WaterData _WaterData;

        public DesktopDataDipslay(WaterData waterData)
        {
            this._WaterData = waterData;
            waterData.RegisterObserver(this);
        }

        public void Update(float temperature, float quality)
        {
            _quality = ComputeQuality(quality);
            Display();
        }

        private String ComputeQuality(float quality)
        {
            string goodQuality;
            if (quality >= 0 && quality < 33)
            {
                goodQuality = "Water is drinkable";
            }

            else if (quality >= 33 && quality < 66)
            {
                goodQuality = "Water is undrinkable ,can be used for watering plants";
            }

            else
            {
                goodQuality = "Water is dirty,should not be used";
            }

            return goodQuality;
        }

        public void Display()
        {
            Console.WriteLine("Desktop Data Dipslay " + _quality + "\n");
        }
    }
}
