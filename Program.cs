using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            circle circle1 = new circle("circle1", 20);
            rectangle r1 = new rectangle("rec1", 5, 6);
            circle1.Method();
            r1.Method();
            Console.WriteLine( " Circle name "+ circle1.Name1);
            Console.WriteLine(" Rectangle name "+ r1.Name1);
            r1._Length1 = 6;
            r1._Length2 = 9;
            circle1.Radius = 10;
            Console.WriteLine("Length 1"+r1._Length1);
            Console.WriteLine("Length 2" + r1._Length2);
            Console.WriteLine("Radius "+circle1.Radius);
            Console.Read();
        }
    }
}
