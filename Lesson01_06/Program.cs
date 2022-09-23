using System;

namespace Lesson01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius1 = int.Parse(Console.ReadLine()), i;
            for (i=1; i<11;i++) { Console.WriteLine($"{skaicius1} kart {i} yra {skaicius1 * i}"); }
            Console.ReadLine();
        }
    }
}
