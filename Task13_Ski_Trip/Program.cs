using System;

namespace Task13_Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double price = 0;
            // check and output
            switch (typeOfRoom)
            {
                case "room for one person":
                    {
                        price = (days-1) * 18;
                    }
                    break;
                case "apartment":
                    {
                        if (days < 10)
                        {
                            price = ((days - 1) * 25) * 0.7;
                        }
                        else if (10 <= days && days <= 15)
                        {
                            price = ((days - 1) * 25) * 0.65;
                        }
                        else if (days > 15)
                        {
                            price = ((days - 1) * 25) * 0.50;
                        }
                    }
                    break;
                case "president apartment":
                    {
                        if (days < 10)
                        {
                            price = ((days - 1) * 35) * 0.9;
                        }
                        else if (10 <= days && days <= 15)
                        {
                            price = ((days - 1) * 35) * 0.85;
                        }
                        else if (days > 15)
                        {
                            price = ((days - 1) * 35) * 0.80;
                        }
                    }
                    break;
            }
            switch (evaluation)
            {
                case "positive":
                    {
                        price = price * 1.25;
                    }
                    break;
                case "negative":
                    {
                        price = price * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
