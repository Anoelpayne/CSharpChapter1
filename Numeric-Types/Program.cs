using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rectangle length: ");
            string recLength = Console.ReadLine();
            double length = double.Parse(recLength);
            Console.WriteLine("Input rectangle width: ");
            string recWidth = Console.ReadLine();
            double width = double.Parse(recWidth);
            Console.WriteLine("The area of the rectangle is: " + length * width);

        }
    }
}
