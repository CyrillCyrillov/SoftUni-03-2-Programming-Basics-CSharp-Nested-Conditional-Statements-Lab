using System;
using System.Diagnostics.CodeAnalysis;

namespace Task11_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;
            // chek and output
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    {
                        switch (fruit)
                        {
                            case "banana":
                                {
                                    Console.WriteLine($"{quantity * 2.5:F2}");
                                }
                                break;
                            case "apple":
                                {
                                    Console.WriteLine($"{quantity * 1.2:F2}");
                                }
                                break;
                            case "orange":
                                {
                                    Console.WriteLine($"{quantity * 0.85:F2}");
                                }
                                break;
                            case "grapefruit":
                                {
                                    Console.WriteLine($"{quantity * 1.45:F2}");
                                }
                                break;
                            case "kiwi":
                                {
                                    Console.WriteLine($"{quantity * 2.70:F2}");
                                }
                                break;
                            case "pineapple":
                                {
                                    Console.WriteLine($"{quantity * 5.5:F2}");
                                }
                                break;
                            case "grapes":
                                {
                                    Console.WriteLine($"{quantity * 3.85:F2}");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("error");
                                }
                                break;
                        }
                        break;
                    }
                case "Saturday":
                case "Sunday":
                    {
                        switch (fruit)
                        {
                            case "banana":
                                {
                                    Console.WriteLine($"{quantity * 2.7:F2}");
                                }
                                break;
                            case "apple":
                                {
                                    Console.WriteLine($"{quantity * 1.25:F2}");
                                }
                                break;
                            case "orange":
                                {
                                    Console.WriteLine($"{quantity * 0.90:F2}");
                                }
                                break;
                            case "grapefruit":
                                {
                                    Console.WriteLine($"{quantity * 1.60:F2}");
                                }
                                break;
                            case "kiwi":
                                {
                                    Console.WriteLine($"{quantity * 3.00:F2}");
                                }
                                break;
                            case "pineapple":
                                {
                                    Console.WriteLine($"{quantity * 5.60:F2}");
                                }
                                break;
                            case "grapes":
                                {
                                    Console.WriteLine($"{quantity * 4.20:F2}");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("error");
                                }
                                break;
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("error");
                    }
                    break;
            }
        }
    }
}
