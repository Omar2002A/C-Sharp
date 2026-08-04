using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog says: Hawo!");
        }
    }
}
