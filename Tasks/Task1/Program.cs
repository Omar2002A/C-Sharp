using System;

namespace Learn
{
    internal class Program
    {
        // =========================================================
        // Basic Tasks
        // =========================================================

        // Task 1: Print name and age
        public static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"My name is {name} and I am {age} years old");
        }

        // Task 2: Check if a number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Task 3: Read and print the same string
        public static void PrintSameString(string text)
        {
            Console.WriteLine($"You entered: {text}");
        }

        // =========================================================
        // If Statements Tasks
        // =========================================================

        // Task 4: Check positive, negative, or zero
        public static void CheckNumberSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        // Task 5: Check leap year
        public static void CheckLeapYear(int year)
        {
            if ((year % 400 == 0) ||
                (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        // Task 6: Check pass or fail
        public static void CheckPassOrFail(double grade)
        {
            if (grade >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        // Task 7: Find the largest number
        public static void FindLargestNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is the largest number.");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine($"{secondNumber} is the largest number.");
            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }
        }

        // Task 8: Check divisibility by 3 and 5
        public static void CheckDivisibleByThreeAndFive(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"{number} is divisible by 3 and 5.");
            }
            else
            {
                Console.WriteLine($"{number} is not divisible by 3 and 5.");
            }
        }

        // Task 9: Check vowel or consonant
        public static void CheckVowelOrConsonant(char letter)
        {
            letter = char.ToLower(letter);

            if (!char.IsLetter(letter))
            {
                Console.WriteLine("Invalid input. Please enter a letter.");
            }
            else if (
                letter == 'a' ||
                letter == 'e' ||
                letter == 'i' ||
                letter == 'o' ||
                letter == 'u')
            {
                Console.WriteLine($"{letter} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{letter} is a consonant.");
            }
        }

        // Task 10: Determine age category
        public static void CheckAgeCategory(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }

        // =========================================================
        // Switch Statements Tasks
        // =========================================================

        // Task 11: Print day name
        public static void PrintDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }

        // Task 12: Print month name
        public static void PrintMonthName(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }
        }

        // Task 13: Calculator using operator
        public static void BasicCalculator(
            double firstNumber,
            double secondNumber,
            char operation)
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine(
                        $"Result = {firstNumber + secondNumber}");
                    break;

                case '-':
                    Console.WriteLine(
                        $"Result = {firstNumber - secondNumber}");
                    break;

                case '*':
                    Console.WriteLine(
                        $"Result = {firstNumber * secondNumber}");
                    break;

                case '/':
                    if (secondNumber != 0)
                    {
                        Console.WriteLine(
                            $"Result = {firstNumber / secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

        // Task 14: Categorize grade
        public static void CategorizeGrade(char grade)
        {
            grade = char.ToUpper(grade);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                    Console.WriteLine("Very Good");
                    break;

                case 'C':
                    Console.WriteLine("Good");
                    break;

                case 'D':
                    Console.WriteLine("Pass");
                    break;

                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
        }

        // Task 15: Print message based on number
        public static void PrintNumberMessage(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("You selected option one.");
                    break;

                case 2:
                    Console.WriteLine("You selected option two.");
                    break;

                case 3:
                    Console.WriteLine("You selected option three.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        // Task 16: Even or odd using switch
        public static void CheckEvenOrOddUsingSwitch(int number)
        {
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;

                default:
                    Console.WriteLine("Odd");
                    break;
            }
        }

        // Task 17: Check login role
        public static void CheckLoginRole(string role)
        {
            switch (role.ToLower())
            {
                case "admin":
                    Console.WriteLine("Welcome Admin.");
                    break;

                case "user":
                    Console.WriteLine("Welcome User.");
                    break;

                case "guest":
                    Console.WriteLine("Welcome Guest.");
                    break;

                default:
                    Console.WriteLine("Invalid role.");
                    break;
            }
        }

        // Task 18: Menu-driven program
        public static void DisplayMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected View Profile.");
                    break;

                case 2:
                    Console.WriteLine("You selected Settings.");
                    break;

                case 3:
                    Console.WriteLine("You selected Help.");
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Invalid menu option.");
                    break;
            }
        }

        // =========================================================
        // Advanced If Statements
        // =========================================================

        // Advanced If Task 1: Employee performance and bonus
        public static void CalculateEmployeeBonus(
            double rating,
            double salary)
        {
            double bonusPercentage;
            string performanceLevel;

            if (rating >= 90 && rating <= 100)
            {
                performanceLevel = "Excellent";
                bonusPercentage = 0.20;
            }
            else if (rating >= 75)
            {
                performanceLevel = "Very Good";
                bonusPercentage = 0.15;
            }
            else if (rating >= 60)
            {
                performanceLevel = "Good";
                bonusPercentage = 0.10;
            }
            else
            {
                performanceLevel = "No bonus";
                bonusPercentage = 0;
            }

            double bonusAmount = salary * bonusPercentage;

            Console.WriteLine($"Performance: {performanceLevel}");
            Console.WriteLine($"Bonus percentage: {bonusPercentage * 100}%");
            Console.WriteLine($"Bonus amount: ${bonusAmount}");
        }

        // Advanced If Task 2: University admission
        public static void CheckUniversityAdmission(
            double gpa,
            bool passedEnglishTest,
            bool hasSpecialRecommendation)
        {
            if ((gpa >= 85 && passedEnglishTest) ||
                hasSpecialRecommendation)
            {
                Console.WriteLine(
                    "The student is eligible for university admission.");
            }
            else
            {
                Console.WriteLine(
                    "The student is not eligible for university admission.");
            }
        }

        // Advanced If Task 3: Shipping cost
        public static void CalculateShippingCost(double weight)
        {
            if (weight <= 0)
            {
                Console.WriteLine("Invalid weight.");
            }
            else if (weight <= 1)
            {
                Console.WriteLine("Delivery cost: $5");
            }
            else if (weight <= 5)
            {
                Console.WriteLine("Delivery cost: $10");
            }
            else if (weight <= 10)
            {
                Console.WriteLine("Delivery cost: $20");
            }
            else
            {
                Console.WriteLine("Delivery cost: $50");
                Console.WriteLine("Warning: Heavy package");
            }
        }

        // Advanced If Task 4: Login system
        public static void CheckLogin(
            string username,
            string password,
            int failedAttempts)
        {
            const string correctUsername = "admin";
            const string correctPassword = "1234";

            if (failedAttempts > 3)
            {
                Console.WriteLine("Account locked.");
            }
            else if (
                username == correctUsername &&
                password == correctPassword)
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }

        // =========================================================
        // Advanced Switch Statements
        // =========================================================

        // Advanced Switch Task 1: Restaurant menu
        public static void RestaurantMenu(int itemNumber)
        {
            switch (itemNumber)
            {
                case 1:
                    Console.WriteLine("Burger - $5");
                    break;

                case 2:
                    Console.WriteLine("Pizza - $8");
                    break;

                case 3:
                    Console.WriteLine("Pasta - $7");
                    break;

                case 4:
                    Console.WriteLine("Salad - $4");
                    break;

                default:
                    Console.WriteLine("Invalid menu item.");
                    break;
            }
        }

        // Advanced Switch Task 2: University grading system
        public static void UniversityGrade(char grade)
        {
            grade = char.ToUpper(grade);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                    Console.WriteLine("Very Good");
                    break;

                case 'C':
                    Console.WriteLine("Good");
                    break;

                case 'D':
                    Console.WriteLine("Pass");
                    break;

                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
        }

        // Advanced Switch Task 3: ATM system
        public static void AtmSystem(
            int choice,
            double balance,
            double amount)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Current balance: ${balance}");
                    break;

                case 2:
                    if (amount > 0)
                    {
                        balance += amount;
                        Console.WriteLine(
                            $"Deposit successful. New balance: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount.");
                    }

                    break;

                case 3:
                    if (amount <= 0)
                    {
                        Console.WriteLine("Invalid withdrawal amount.");
                    }
                    else if (amount <= balance)
                    {
                        balance -= amount;

                        Console.WriteLine(
                            $"Withdrawal successful. New balance: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }

                    break;

                case 4:
                    Console.WriteLine("Thank you for using the ATM.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        // Advanced Switch Task 4: Calculator using menu choices
        public static void CalculatorUsingChoice(
            int choice,
            double firstNumber,
            double secondNumber)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        $"Result = {firstNumber + secondNumber}");
                    break;

                case 2:
                    Console.WriteLine(
                        $"Result = {firstNumber - secondNumber}");
                    break;

                case 3:
                    Console.WriteLine(
                        $"Result = {firstNumber * secondNumber}");
                    break;

                case 4:
                    if (secondNumber != 0)
                    {
                        Console.WriteLine(
                            $"Result = {firstNumber / secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid operation choice.");
                    break;
            }
        }

        // =========================================================
        // Main Method
        // =========================================================

        static void Main(string[] args)
        {

            // =====================================================
            // Basic Task 1
            // =====================================================

            //string name;
            //int age;

            //Console.Write("Enter your name: ");
            //name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //PrintNameAndAge(name, age);


            // =====================================================
            // Basic Task 2
            // =====================================================

            //int number;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //if (IsEven(number))
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}


            // =====================================================
            // Basic Task 3
            // =====================================================

            //string text;

            //Console.Write("Enter text: ");
            //text = Console.ReadLine();

            //PrintSameString(text);


            // =====================================================
            // If Task 4
            // =====================================================

            //int number;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //CheckNumberSign(number);


            // =====================================================
            // If Task 5
            // =====================================================

            //int year;

            //Console.Write("Enter a year: ");
            //year = Convert.ToInt32(Console.ReadLine());

            //CheckLeapYear(year);


            // =====================================================
            // If Task 6
            // =====================================================

            //double grade;

            //Console.Write("Enter student grade: ");
            //grade = Convert.ToDouble(Console.ReadLine());

            //CheckPassOrFail(grade);


            // =====================================================
            // If Task 7
            // =====================================================

            //int firstNumber;
            //int secondNumber;

            //Console.Write("Enter the first number: ");
            //firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //secondNumber = Convert.ToInt32(Console.ReadLine());

            //FindLargestNumber(firstNumber, secondNumber);


            // =====================================================
            // If Task 8
            // =====================================================

            //int number;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //CheckDivisibleByThreeAndFive(number);


            // =====================================================
            // If Task 9
            // =====================================================

            //char letter;

            //Console.Write("Enter a character: ");
            //letter = Convert.ToChar(Console.ReadLine());

            //CheckVowelOrConsonant(letter);


            // =====================================================
            // If Task 10
            // =====================================================

            //int age;

            //Console.Write("Enter your age: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //CheckAgeCategory(age);


            // =====================================================
            // Switch Task 11
            // =====================================================

            //int dayNumber;

            //Console.Write("Enter day number from 1 to 7: ");
            //dayNumber = Convert.ToInt32(Console.ReadLine());

            //PrintDayName(dayNumber);


            // =====================================================
            // Switch Task 12
            // =====================================================

            //int monthNumber;

            //Console.Write("Enter month number from 1 to 12: ");
            //monthNumber = Convert.ToInt32(Console.ReadLine());

            //PrintMonthName(monthNumber);


            // =====================================================
            // Switch Task 13
            // =====================================================

            //double firstNumber;
            //double secondNumber;
            //char operation;

            //Console.Write("Enter the first number: ");
            //firstNumber = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //secondNumber = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operation (+, -, *, /): ");
            //operation = Convert.ToChar(Console.ReadLine());

            //BasicCalculator(firstNumber, secondNumber, operation);


            // =====================================================
            // Switch Task 14
            // =====================================================

            //char grade;

            //Console.Write("Enter grade (A, B, C, D, F): ");
            //grade = Convert.ToChar(Console.ReadLine());

            //CategorizeGrade(grade);


            // =====================================================
            // Switch Task 15
            // =====================================================

            //int number;

            //Console.Write("Enter a number from 1 to 3: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //PrintNumberMessage(number);


            // =====================================================
            // Switch Task 16
            // =====================================================

            //int number;

            //Console.Write("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //CheckEvenOrOddUsingSwitch(number);


            // =====================================================
            // Switch Task 17
            // =====================================================

            //string role;

            //Console.Write("Enter role (Admin, User, Guest): ");
            //role = Console.ReadLine();

            //CheckLoginRole(role);


            // =====================================================
            // Switch Task 18
            // =====================================================

            //int choice;

            //Console.WriteLine("1. View Profile");
            //Console.WriteLine("2. Settings");
            //Console.WriteLine("3. Help");
            //Console.WriteLine("4. Exit");

            //Console.Write("Enter your choice: ");
            //choice = Convert.ToInt32(Console.ReadLine());

            //DisplayMenu(choice);


            // =====================================================
            // Advanced If Task 1
            // =====================================================

            //double rating;
            //double salary;

            //Console.Write("Enter employee rating: ");
            //rating = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter employee salary: ");
            //salary = Convert.ToDouble(Console.ReadLine());

            //CalculateEmployeeBonus(rating, salary);


            // =====================================================
            // Advanced If Task 2
            // =====================================================

            //double gpa;
            //bool passedEnglishTest;
            //bool hasSpecialRecommendation;

            //Console.Write("Enter GPA: ");
            //gpa = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Passed English test? (true/false): ");
            //passedEnglishTest =
            //    Convert.ToBoolean(Console.ReadLine());

            //Console.Write("Has special recommendation? (true/false): ");
            //hasSpecialRecommendation =
            //    Convert.ToBoolean(Console.ReadLine());

            //CheckUniversityAdmission(
            //    gpa,
            //    passedEnglishTest,
            //    hasSpecialRecommendation);


            // =====================================================
            // Advanced If Task 3
            // =====================================================

            //double weight;

            //Console.Write("Enter package weight in kg: ");
            //weight = Convert.ToDouble(Console.ReadLine());

            //CalculateShippingCost(weight);


            // =====================================================
            // Advanced If Task 4
            // =====================================================

            //string username;
            //string password;
            //int failedAttempts;

            //Console.Write("Enter username: ");
            //username = Console.ReadLine();

            //Console.Write("Enter password: ");
            //password = Console.ReadLine();

            //Console.Write("Enter failed attempts: ");
            //failedAttempts =
            //    Convert.ToInt32(Console.ReadLine());

            //CheckLogin(username, password, failedAttempts);


            // =====================================================
            // Advanced Switch Task 1
            // =====================================================

            //int itemNumber;

            //Console.WriteLine("1. Burger - $5");
            //Console.WriteLine("2. Pizza - $8");
            //Console.WriteLine("3. Pasta - $7");
            //Console.WriteLine("4. Salad - $4");

            //Console.Write("Select an item: ");
            //itemNumber = Convert.ToInt32(Console.ReadLine());

            //RestaurantMenu(itemNumber);


            // =====================================================
            // Advanced Switch Task 2
            // =====================================================

            //char grade;

            //Console.Write("Enter grade (A, B, C, D, F): ");
            //grade = Convert.ToChar(Console.ReadLine());

            //UniversityGrade(grade);


            // =====================================================
            // Advanced Switch Task 3
            // =====================================================

            //int choice;
            //double balance = 1000;
            //double amount = 0;

            //Console.WriteLine("1. Check Balance");
            //Console.WriteLine("2. Deposit Money");
            //Console.WriteLine("3. Withdraw Money");
            //Console.WriteLine("4. Exit");

            //Console.Write("Enter your choice: ");
            //choice = Convert.ToInt32(Console.ReadLine());

            //if (choice == 2 || choice == 3)
            //{
            //    Console.Write("Enter amount: ");
            //    amount = Convert.ToDouble(Console.ReadLine());
            //}

            //AtmSystem(choice, balance, amount);


            // =====================================================
            // Advanced Switch Task 4
            // =====================================================

            //int choice;
            //double firstNumber;
            //double secondNumber;

            //Console.Write("Enter the first number: ");
            //firstNumber = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //secondNumber = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("1. Addition");
            //Console.WriteLine("2. Subtraction");
            //Console.WriteLine("3. Multiplication");
            //Console.WriteLine("4. Division");

            //Console.Write("Enter operation choice: ");
            //choice = Convert.ToInt32(Console.ReadLine());

            //CalculatorUsingChoice(
            //    choice,
            //    firstNumber,
            //    secondNumber);
        }
    }
}