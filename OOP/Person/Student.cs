using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Student : Person
    {
        public string Major { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying {Major}");
        }
    }
}
