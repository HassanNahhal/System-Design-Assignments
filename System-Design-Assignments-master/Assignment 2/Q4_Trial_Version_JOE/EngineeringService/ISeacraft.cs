using System;
using EngineeringService;

namespace EngineeringService
{

    //Adaptee interface
    public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevs();
        void DecreaseRevs();
        void RaiseNose();
        void LowerNose();
    }
}
