using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number: ");
            int firstNum,secondNum;
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());


            if (firstNum > secondNum)
                Console.WriteLine("first number greatest than second");
            else if (firstNum == secondNum)
                Console.WriteLine("first number is equal the second");
            else
            {
                Console.WriteLine("Second number greatest than first");
            }
        }
    }
}
