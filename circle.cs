using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class circle :IFigure
    {
        public int radius;
        public string Obj_Name;
        public circle()
        {

        }      // 1 конструктор

        public circle(string name, int r)
        {
            Obj_Name = name;

            radius = r;

        }         // 2 конструктор
        public void Method()
        {
            Console.WriteLine("Radius " + radius);
            
        }
        public void Perymetr()
        {
            double p = 0;
            p = 2*(3.14)*radius;
            Console.WriteLine("Perymetr " + p);
        }
        public void Ploshcha()
        {
            double p = 0;
            p = 3.14*radius*radius;
            Console.WriteLine("Ploshcha " + p);
        }
        public string Name1
        {
            get
            {

                return Obj_Name;
            }
        }
        public int Radius
        {
            get
            {

                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else radius = 0;
            }
        }
       
    }
}
