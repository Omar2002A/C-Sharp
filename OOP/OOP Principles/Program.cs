using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine(MathUtilities.Square(5));
            //    Console.WriteLine(MathUtilities.SquareRoot(25));
            //    Console.WriteLine(MathUtilities.Max(8, 13));

            //Console.WriteLine($"25°C = {Converter.CelsiusToFahrenheit(25)}°F");
            //Console.WriteLine($"10 km = {Converter.KilometersToMiles(10):F2} miles");

            //VisitorCounter v1 = new VisitorCounter();
            //Console.WriteLine(VisitorCounter.Counter);

            //VisitorCounter v2 = new VisitorCounter();
            //Console.WriteLine(VisitorCounter.Counter);

            //VisitorCounter v3 = new VisitorCounter();
            //Console.WriteLine(VisitorCounter.Counter);

            //Company.CompanyName = "Orange";

            //Company emp1 = new Company();
            //emp1.EmployeeName = "Omar";

            //Company emp2 = new Company();
            //emp2.EmployeeName = "Abdalkareem";

            //Company emp3 = new Company();
            //emp3.EmployeeName = "Ahmad";

            //Console.WriteLine($"{emp1.EmployeeName} works at {Company.CompanyName}");
            //Console.WriteLine($"{emp2.EmployeeName} works at {Company.CompanyName}");
            //Console.WriteLine($"{emp3.EmployeeName} works at {Company.CompanyName}");

            //AddOverloading add = new AddOverloading();

            //Console.WriteLine(add.Add(5, 3));
            //Console.WriteLine(add.Add(5.5, 3.2));
            //Console.WriteLine(add.Add(1, 2, 3));

            //Console.WriteLine("----------------");

            //Animal animal = new Animal();
            //animal.Speak();

            //Cat cat = new Cat();
            //cat.Speak();

            //Dog dog = new Dog();
            //dog.Speak();

            //Console.WriteLine("----------------");

            //Person person = new Person();
            //person.Id = 1;

            //Console.WriteLine($"Person id: {person.Id}");

            //Console.WriteLine("----------------");

            //Rectangle rectangle = new Rectangle(5, 4);

            //Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

            //Console.WriteLine("----------------");


            //WashingMachine machine = new WashingMachine();
            //machine.Brand = "LG";

            //AirConditioner conditioner = new AirConditioner();
            //conditioner.Brand = "Samsung";

            //machine.TurnOn();
            //machine.TurnOff();

            //Console.WriteLine("----------------");

            //conditioner.TurnOn();
            //conditioner.TurnOff();


            //BankAccount account = new BankAccount();
            //account.Deposit(1000);
            //account.Withdraw(300);
            //Console.WriteLine($"Current Balance: {account.Balance}");
            //account.Withdraw(1000);
            //Console.WriteLine($"Current Balance: {account.Balance}");

            
            FullTimeEmployee emp1 = new FullTimeEmployee("Omar", 1200);
            PartTimeEmployee emp2 = new PartTimeEmployee("Ahmad", 80, 10);
            Console.WriteLine($"{emp1.Name} Salary = {emp1.CalculateSalary()}");
            Console.WriteLine($"{emp2.Name} Salary = {emp2.CalculateSalary()}");
        }
    }
}
