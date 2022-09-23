using System;

namespace Lesson01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temp. celsiais");
            double skaicius1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"kelvin = {skaicius1+273}");
            Console.WriteLine($"farenheit = {skaicius1 * 18/10 +32}");
            Console.ReadLine();

        }
    }
}
