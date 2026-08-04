using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class VisitorCounter
    {
        public static int Counter = 0;

        public VisitorCounter()
        {
            Counter++;
        }
    }
}
