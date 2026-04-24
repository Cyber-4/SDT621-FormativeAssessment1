using System;

namespace StudentMarksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            double total = 0;

            for (int i = 1; i <= 3; i++)
            {
                double mark;
                while (true)
                {
                    Console.Write($"Enter mark for Subject {i}: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out mark))
                    {
                        total += mark;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }
            }

            double average = total / 3.0;

            string result = average >= 50 ? "PASS" : "FAIL";

            Console.WriteLine(); 
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {Math.Round(average, 1)}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")}");

            Console.WriteLine(); 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}