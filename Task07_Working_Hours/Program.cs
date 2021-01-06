using Microsoft.VisualBasic;
using System;

namespace Task07_Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            // check and output
            switch (day)
            {
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (time >= 10 && time < 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
            }
        }
    }
}
