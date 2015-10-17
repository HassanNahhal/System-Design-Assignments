using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBird
{
    interface IAircraft
    {
        bool Airborne { get; }
        void TakeOFF();
        int Height { get; }
        int Speed { get; }
        void LandOn();

    }
}
