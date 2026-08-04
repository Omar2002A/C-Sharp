using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    abstract class Appliance
    {
        public string Brand { get; set; }
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
