using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(
                "Toyota",
                2023,
                "Sedan",
                25000,
                "Corolla",
                "45-12345",
                "White"
            );

            car.StartEngine();

            Console.WriteLine();
            Console.WriteLine(car.GetCarInfo());
            Console.WriteLine();

            car.StopEngine();
        }
    }
}
