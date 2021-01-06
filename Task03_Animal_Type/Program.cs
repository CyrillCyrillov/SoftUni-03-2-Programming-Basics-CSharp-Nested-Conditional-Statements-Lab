using System;

namespace Таск03_Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string animal = Console.ReadLine();
            // check and output
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
