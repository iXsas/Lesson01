using System;

namespace Lesson01_05
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
       
            Console.WriteLine("Iveskite pirma skaiciu");
            string input1=Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu");
            string input2 = Console.ReadLine();
            Console.WriteLine($"{input1} ir {input2}");
            int skaicius1 = int.Parse(input1); int skaicius2 = int.Parse(input2);
            Console.WriteLine($"daugyba {skaicius1*skaicius2} dalyba sveika dalis {skaicius1 / skaicius2} suma {skaicius1 + skaicius2} atimtis {skaicius1 - skaicius2} ");
            Console.ReadLine();
        }
    }
}
