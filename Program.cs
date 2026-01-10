//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] arr = new int[3, 3];


//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write($"Enter value for [{i},{j}]: ");
//                arr[i, j] = int.Parse(Console.ReadLine());
//            }
//        }


//        Console.WriteLine("\nArray:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(arr[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//part2
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] arr =
//        {
//            {1, 2, 3, 4},
//            {5, 6, 7, 8},
//            {9, 10, 11, 12},
//            {13, 14, 15, 16}
//        };


//        for (int i = 0; i < 4; i++)
//        {
//            int rowSum = 0;
//            for (int j = 0; j < 4; j++)
//                rowSum += arr[i, j];

//            Console.WriteLine($"Sum of row {i}: {rowSum}");
//        }


//        for (int j = 0; j < 4; j++)
//        {
//            int colSum = 0;
//            for (int i = 0; i < 4; i++)
//                colSum += arr[i, j];

//            Console.WriteLine($"Sum of column {j}: {colSum}");
//        }
//    }
//}
////part3
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] arr = new int[5, 5];
//        Random rand = new Random();


//        for (int i = 0; i < 5; i++)
//            for (int j = 0; j < 5; j++)
//                arr[i, j] = rand.Next(1, 51);


//        Console.WriteLine("Array:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//                Console.Write(arr[i, j] + "\t");
//            Console.WriteLine();
//        }


//        for (int i = 0; i < 5; i++)
//        {
//            int max = arr[i, 0];
//            for (int j = 1; j < 5; j++)
//                if (arr[i, j] > max)
//                    max = arr[i, j];

//            Console.WriteLine($"Max in row {i}: {max}");
//        }


//        for (int j = 0; j < 5; j++)
//        {
//            int min = arr[0, j];
//            for (int i = 1; i < 5; i++)
//                if (arr[i, j] < min)
//                    min = arr[i, j];

//            Console.WriteLine($"Min in column {j}: {min}");
//        }
//    }
//}
//part4
using System;

class Program
{
    static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[2];
        jagged[1] = new int[3];
        jagged[2] = new int[4];

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write($"Enter value for row {i}, index {j}: ");
                jagged[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged Array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
                Console.Write(jagged[i][j] + " ");
            Console.WriteLine();
        }
    }
}
//part5
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        int[][] jagged = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter length of row {i}: ");
            int length = int.Parse(Console.ReadLine());
            jagged[i] = new int[length];

            for (int j = 0; j < length; j++)
            {
                Console.Write($"Enter value [{i}][{j}]: ");
                jagged[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged Array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            foreach (int val in jagged[i])
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}
//part6
using System;

class Program
{
    static void Main()
    {
        int[][] jagged = new int[5][];
        Random rand = new Random();

        for (int i = 0; i < 5; i++)
        {
            jagged[i] = new int[i + 1];
            int sum = 0;

            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = rand.Next(1, 101);
                sum += jagged[i][j];
            }

            Console.WriteLine($"Sum of row {i + 1}: {sum}");
        }
    }
}
//part7
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Numbers:");
        foreach (int n in numbers)
            Console.WriteLine(n);
    }
}
//part8
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        while (true)
        {
            Console.Write("Enter number (-1 to stop): ");
            input = int.Parse(Console.ReadLine());

            if (input == -1)
                break;

            numbers.Add(input);
        }

        Console.WriteLine("\nElements:");
        foreach (int n in numbers)
            Console.Write(n + " ");

        int sum = 0, max = numbers[0], min = numbers[0];

        foreach (int n in numbers)
        {
            sum += n;
            if (n > max) max = n;
            if (n < min) min = n;
        }

        Console.WriteLine($"\nAverage: {(double)sum / numbers.Count}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");

        numbers.Sort();
        Console.WriteLine("Sorted:");
        foreach (int n in numbers)
            Console.Write(n + " ");
    }
}



