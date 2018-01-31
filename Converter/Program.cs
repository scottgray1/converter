using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Title: Converter App");
            Console.WriteLine("Description: Will convert yards to inches");

            Console.WriteLine("Enter yards to convert:");
            int yards = int.Parse(Console.ReadLine());

            int inches = yards * 36;

            Console.WriteLine("Number of inches in " + yards + " yards is " + inches + " inches.");

        }
    }
}
