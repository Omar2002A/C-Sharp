using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {
        private string make;
        private int year;
        private string type;
        private double price;
        private string model;
        private string plateNo;
        private string color;

        public Car(string make, int year, string type, double price, string model, string plateNo, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.plateNo = plateNo;
            this.color = color;
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine Started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped.");
        }

        public string GetCarInfo()
        {
            return $"Make      : {make}\n" +
                   $"Model     : {model}\n" +
                   $"Year      : {year}\n" +
                   $"Type      : {type}\n" +
                   $"Price     : {price}\n" +
                   $"Plate No. : {plateNo}\n" +
                   $"Color     : {color}";
        }
    }
}
