using System;
using System.Diagnostics;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y : ");
            int y = int.Parse(Console.ReadLine());
            double z = 0;
            if (x < 0 && y > 10)
            {
                z = Math.Asinh(x) + 2;
            }
            else if (x > 0 && y <= 1)
            {                
                z = Math.Acosh(x) - y;                
            }
            else
            {
                Console.WriteLine("You enter wrong \"x\" and \"y\"!!!");
            }
            Console.WriteLine("z = " + z);

            //test coment
        }


    }
}
