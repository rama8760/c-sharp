//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a string:");
//        string text = Console.ReadLine();

//        Console.WriteLine("enter: " + text);
//    }
//}

//part2
//using System;

//class Program
//{
//    static void Main()
//    {
//        double number = 9.9;
//        string name = "rama";
//        char letter = 'A';
//        bool isStudent = true;
//        int age = 23;
//        const int year = 2025;

//        Console.WriteLine(number);
//        Console.WriteLine(name);
//        Console.WriteLine(letter);
//        Console.WriteLine(isStudent);
//        Console.WriteLine(age);
//        Console.WriteLine(year);
//    }
//}
//part3



//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] cars = { "BMW",  "Honda", "Ford" };

//        Console.WriteLine("Cars:");
//        Console.WriteLine(cars[0]);
//        Console.WriteLine(cars[1]);
//        Console.WriteLine(cars[2]);


//        Console.WriteLine(cars.Length);
//    }
//}




//part4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("first name:");
//        string firstName = Console.ReadLine();

//        Console.WriteLine(" last name:");
//        string lastName = Console.ReadLine();

//        Console.WriteLine("Input birth:");
//        int year = int.Parse(Console.ReadLine());

//        Console.WriteLine(firstName + " " + lastName + " " + year);
//    }
//}


//prt5
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];

        Console.WriteLine("Input 10 elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("element - " + i + " : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Elements: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
