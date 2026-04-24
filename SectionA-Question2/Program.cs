using System;

namespace SimpleATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
            Console.WriteLine();

            Console.WriteLine("HI , WHAT IS YOUR NAME?");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"WELCOME {name.ToUpper()}!");

            double balance;
            Console.Write("Enter account balance: ");
            while (!double.TryParse(Console.ReadLine(), out balance) || balance < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
                Console.Write("Enter account balance: ");
            }

            double withdrawal;
            Console.Write("Enter withdrawal amount: ");
            while (!double.TryParse(Console.ReadLine(), out withdrawal) || withdrawal <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number greater than 0.");
                Console.Write("Enter withdrawal amount: ");
            }

            Console.WriteLine();

            if (withdrawal <= balance)
            {
                balance -= withdrawal;
                Console.WriteLine("Withdrawal successful!");

                Console.WriteLine($"Updated Balance: {balance:F2}");
                Console.WriteLine($"Transaction Time: {DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")}");
            }
            else
            {
                Console.WriteLine("Transaction Failed: Insufficient funds.");
            }

            Console.ReadLine();
        }
    }
}