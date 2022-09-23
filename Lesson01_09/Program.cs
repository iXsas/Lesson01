using System;

namespace Lesson01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{c,0}{c,0}{c,0}\n{c,-1}{c,2}\n{c,-1}{c,2}\n{c,-1}{c,2}\n{c,0}{c,0}{c,0}");
            Console.ReadLine();
        }
    }
}
