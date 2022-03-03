using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
                Console.WriteLine("Odd number");
            else
                Console.WriteLine("An even number");
        }
    }
}
