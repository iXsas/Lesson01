using System;

namespace Lesson01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\" Labas pasauli!");
            Console.WriteLine("3 + 5 = " + (3 + 5));//performance 3ioje vietoje
            Console.WriteLine($"3 + 5 =  {3 + 5}");//performance 1oje vietoje
            Console.WriteLine("3 + 5 =  {3 + 5}");
            Console.WriteLine(String.Format("7 + 8 =  {0}", 7+8));//2 vietoje performance kiek optimaliau
            Console.ReadLine();
        }
    }
}
