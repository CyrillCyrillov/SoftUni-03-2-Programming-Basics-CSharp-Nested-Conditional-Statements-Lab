using System;

namespace Task10_Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());
            // check and output
            if (number != 0)
            {
                if (number < 100 | number > 200)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
