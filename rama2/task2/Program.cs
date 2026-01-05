//part2
//using System;

//class Program
//{
//    static void Main()
//    {
//        int grade;

//        Console.Write("Enter the student's grade (0-100): ");
//        grade = int.Parse(Console.ReadLine());

//        while (grade < 0 || grade > 100)
//        {
//            Console.Write("Invalid grade. Please enter again (0-100): ");
//            grade = int.Parse(Console.ReadLine());
//        }

//        if (grade >= 90)
//            Console.WriteLine("Grade: A");
//        else if (grade >= 80)
//            Console.WriteLine("Grade: B");
//        else if (grade >= 70)
//            Console.WriteLine("Grade: C");
//        else if (grade >= 60)
//            Console.WriteLine("Grade: D");
//        else
//            Console.WriteLine("Grade: F");
//    }
//}


//part3

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an operation (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        validOperation = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.Write("Do you want to continue? (y/n): ");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 'n' || choice == 'N')
            {
                break;
            }
        }
    }
}


