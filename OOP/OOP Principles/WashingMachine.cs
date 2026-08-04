using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} Washing Machine is now ON.");
        }
        
        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} Washing Machine is now OFF.");
        }
    }
}
