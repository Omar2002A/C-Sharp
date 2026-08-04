using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract decimal CalculateSalary();

    }

    class FullTimeEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }

        public FullTimeEmployee(string name, decimal monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee(string name, int hoursWorked, decimal hourlyRate)
        {
            Name = name;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
