using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace Lesson01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Iveskite 4 skaicius");
            double[] s={0,0,0,0};
            for (int i = 1; i < 5; i++)
            {   Console.WriteLine($"Iveskite {i} skaiciu ir paspauskite enter");
                s[i-1] = double.Parse(Console.ReadLine());
            }
                  Console.WriteLine("vidrukis: {0}", s.Average());Console.ReadLine();
        }
        
    }
}
