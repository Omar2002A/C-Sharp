using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTest
{
    sealed class Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Teacher is teaching !");
        }
    }

    class MathTeacher : Teacher
    {

    }
}