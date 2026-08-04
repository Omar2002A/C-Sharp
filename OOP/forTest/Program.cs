using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTest
{
    //sealed class Teacher
    //{
    //    public void Teach()
    //    {
    //        Console.WriteLine("Teacher is teaching !");
    //    }
    //}

    //class MathTeacher : Teacher
    //{

    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 10, 3, 4, 9, 1 };

            int min = numbers[0];
            int max = numbers[0];

            int profit = max - min;

            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (Array.IndexOf(numbers, max) > Array.IndexOf(numbers, min) && max - min > profit)
                {
                    profit = max - min;
                }

                
            }

            Console.WriteLine(profit);
        }
    }
}