using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    class AddOverloading
    {
        public int Add(int number1,  int number2)
        {
            return number1 + number2;
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
    }
}
