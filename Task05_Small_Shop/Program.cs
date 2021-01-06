using System;

namespace Task05_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            // check and output
            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(quantity * 0.5);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(quantity * 0.4);
                            break;
                        case "Varna":
                            Console.WriteLine(quantity * 0.45);
                            break;
                    }
                break;
                case "water":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(quantity * 0.8);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(quantity * 0.7);
                            break;
                        case "Varna":
                            Console.WriteLine(quantity * 0.7);
                            break;
                    }
                    break;
                case "beer":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(quantity * 1.2);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(quantity * 1.15);
                            break;
                        case "Varna":
                            Console.WriteLine(quantity * 1.1);
                            break;
                    }
                    break;
                case "sweets":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(quantity * 1.45);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(quantity * 1.3);
                            break;
                        case "Varna":
                            Console.WriteLine(quantity * 1.35);
                            break;
                    }
                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(quantity * 1.6);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(quantity * 1.5);
                            break;
                        case "Varna":
                            Console.WriteLine(quantity * 1.55);
                            break;
                    }
                    break;
            }
        }
    }
}
