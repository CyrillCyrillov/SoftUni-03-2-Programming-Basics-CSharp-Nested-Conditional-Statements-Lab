using System;

namespace Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());
            // check and output
            if (number == 0)
            {
               Console.WriteLine("No");
            }
            else if (number < -100 | number > 100)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
