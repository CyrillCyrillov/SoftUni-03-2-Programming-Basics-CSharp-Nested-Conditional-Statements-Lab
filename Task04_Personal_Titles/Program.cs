using System;

namespace Task04_Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            // check and output
            switch (gender)
            {
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                    break;
                case "f":
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
            }
        }
    }
}
