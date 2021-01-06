using System;

namespace Task08_Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string day = Console.ReadLine();
            // check and output
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    {
                        Console.WriteLine("12");
                    }
                    break;
                case "Wednesday":
                case "Thursday":
                    {
                        Console.WriteLine("14");
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    {
                        Console.WriteLine("16");
                    }
                    break;
            }
        }
    }
}
