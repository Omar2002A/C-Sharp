using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "Omar";
            student.SetAge(23);
            student.Major = "Computer Engineering";

            student.PrintInfo();
            student.Study();
        }
    }
}
