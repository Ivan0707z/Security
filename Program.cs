//Лабараторна робота 1 Заїчко Іван
using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("20 random numbers 0 to 100");
            Console.WriteLine("---");

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(random.Next(0, 101));
                Console.Write("");

            }
            Console.WriteLine("");
        }

    }
}