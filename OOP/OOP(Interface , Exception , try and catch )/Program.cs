using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Interface___Exception___try_and_catch__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();

            //try
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int result = calculator.Add(num1, num2);

            //    Console.WriteLine($"Result = {result}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter numbers only.");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}

            string path = "data.txt";

            //try
            //{
            //    File.WriteAllText(path, "Name: Omar\nAge: 24");

            //    Console.WriteLine("File created successfully.\n");

            //    Console.WriteLine("File Content:");

            //    foreach (string line in File.ReadLines(path))
            //    {
            //        Console.WriteLine(line);
            //    }

            //    File.AppendAllText(path, "\nCountry: Jordan");

            //    Console.WriteLine("\nAfter Appending:");

            //    foreach (string line in File.ReadLines(path))
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            try
            {
                File.WriteAllText(path,@"Name: Omar
Specialization: Computer Engineering
Age: 24
Description:
I am a Computer Engineering graduate.
I enjoy Back-End Development and learning .NET.
I am currently improving my programming skills every day.");


                Console.WriteLine("===== File Content =====\n");

                foreach (string line in File.ReadLines(path))
                {
                    Console.WriteLine(line);
                }

                string content = File.ReadAllText(path);

                int characterCount = 0;

                foreach (char ch in content)
                {
                    if (!char.IsWhiteSpace(ch))
                    {
                        characterCount++;
                    }
                }

                string[] words = content.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("\n========================");
                Console.WriteLine($"Total Characters (without spaces): {characterCount}");
                Console.WriteLine($"Total Words: {words.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
