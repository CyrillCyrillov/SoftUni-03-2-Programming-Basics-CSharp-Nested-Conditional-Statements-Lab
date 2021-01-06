using System;

namespace Task12_Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string city = Console.ReadLine();
            double sell = double.Parse(Console.ReadLine());
            double comision = 0;
            // check and ouput
            switch (city)
            {
                case "Sofia":
                    {
                        if (0 <= sell && sell <= 500)
                        {
                            comision = sell * 0.05;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (500 < sell && sell <= 1000)
                        {
                            comision = sell * 0.07;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (1000 < sell && sell <= 10000)
                        {
                            comision = sell * 0.08;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (sell > 10000)
                        {
                            comision = sell * 0.12;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    break;
                case "Varna":
                    {
                        if (0 <= sell && sell <= 500)
                        {
                            comision = sell * 0.045;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (500 < sell && sell <= 1000)
                        {
                            comision = sell * 0.075;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (1000 < sell && sell <= 10000)
                        {
                            comision = sell * 0.1;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (sell > 10000)
                        {
                            comision = sell * 0.13;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    break;
                case "Plovdiv":
                    {
                        if (0 <= sell && sell <= 500)
                        {
                            comision = sell * 0.055;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (500 < sell && sell <= 1000)
                        {
                            comision = sell * 0.08;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (1000 < sell && sell <= 10000)
                        {
                            comision = sell * 0.12;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else if (sell > 10000)
                        {
                            comision = sell * 0.145;
                            Console.WriteLine($"{comision:F2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
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
