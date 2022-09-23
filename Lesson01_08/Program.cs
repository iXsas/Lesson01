using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace Lesson01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius A, B, C");
            double[] s = { 0, 0, 0 };
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Iveskite {i} skaiciu ir paspauskite enter");
                s[i - 1] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("(A+B)*C: {0}", (s[0] + s[1]) * s[2]);
            Console.WriteLine("bei A*C + B*C:{0}",(s[0] * s[2]) + (s[1] * s[2]));
            Console.ReadLine();

        }
    }
}
