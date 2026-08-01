using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public string Name { get; set; }
        private int Age;

        public void SetAge(int age)
        {
            this.Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
        }
    }
}
