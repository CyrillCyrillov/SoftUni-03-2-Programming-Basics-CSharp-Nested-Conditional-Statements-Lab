using System;

namespace Task09_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string product = Console.ReadLine();
            // check and output
            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    {
                        Console.WriteLine("fruit");
                    }
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    {
                        Console.WriteLine("vegetable");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("unknown");
                    }
                    break;
            }
        }
    }
}
