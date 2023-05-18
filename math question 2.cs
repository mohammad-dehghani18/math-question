using System;
using System.Runtime.InteropServices;

namespace project
{
    class Test
    {
        public static void Main() 
        {
            Console.WriteLine("please enter x:");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Calc(x);
        }
        private static void Calc(int x)
        {
            double result = Math.Pow(x, 2) + (2 * x) - 4;
            Console.WriteLine("x^2+2x-4 = {0}", result);
        }
    }
}