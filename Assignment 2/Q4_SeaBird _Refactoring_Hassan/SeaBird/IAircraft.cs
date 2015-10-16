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
        void TakeOff();
        int Height { get; }
        int Speed { get; }
        void TurnEngineOn();
        void IncreaseSpeed();
        void IncreaseSpeedToMax();
        void ReachTakeOfArea();
        void Stop();
        void RaiseNose();
        void IncreaseHight();
        void Wait();
        void ReachDestination();
        void LowerNose();
        void DecreaseSpeed();
        void TurnEngineOff();

    }
}
