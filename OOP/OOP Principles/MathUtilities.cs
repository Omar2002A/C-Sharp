using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    static class MathUtilities
    {
        public static int Square(int number)
        {
            return number * number;
        }

        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public static int Max(int first, int second)
        {
            return first > second ? first : second;
        } 
    }
}
