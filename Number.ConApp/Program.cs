using System;

namespace Number.ConApp
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine("Number-App!");

            string input, output;
            long number;

            do
            {
                Console.Write("Geben Sie eine Zahl ein:");
                input = Console.ReadLine();

            } while (long.TryParse(input, out number) == false);


            if (Number.Logic.NumberProperties.IsPerfect(number))
            {
                output = $"{number} ist eine perfekte Zahl";
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                output = $"{number} ist keine perfekte Zahl";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(output);


            if (Number.Logic.NumberProperties.IsPrime(number))
            {
                output = $"{number} ist eine Primzahl";
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                output = $"{number} ist keine Primzahl";
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
