using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int Num = 1; Num <= 100; Num++)
            {
                if (Num % 15 == 0)
                {
                    Console.WriteLine("Hello GoodBye");
                }
                else if (Num % 5 == 0)
                {
                    Console.WriteLine("GoodBye");
                }
                else if (Num % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else
                {
                    Console.WriteLine(Num);
                }
            }
        }
    }
}