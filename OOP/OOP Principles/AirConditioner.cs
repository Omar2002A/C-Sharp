using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class AirConditioner : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} Air Conditioner is Cooling.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} Air Conditioner is OFF.");
        }
    }
}
