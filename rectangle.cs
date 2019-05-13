using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class rectangle: IFigure
    {
      
       public int Length1;
        public int Length2;
        public string Obj_Name;
        public rectangle()
        {
           
        }      // 1 конструктор

        public rectangle(string name, int l1, int l2)
        {
            Obj_Name = name;
           
            Length1 = l1;
            Length2 = l2;

        }         // 2 конструктор
        public void Method()
        {
            Console.WriteLine("Length 1 "+Length1);
            Console.WriteLine("Length 2 "+Length2);
          
        }
        public void Perymetr()
        {
            int p = 0;
            p = Length1 * 2 + Length2 * 2;
            Console.WriteLine("Perymetr "+p);
        }
        public void Ploshcha()
        {
            int p = 0;
            p = Length1 * Length2;
            Console.WriteLine("Ploshcha "+p);
        }
        public string Name1
        {
            get
            {
                
                return Obj_Name;
            }
        }
        public int _Length1
        {
            get
            {

                return Length1 ;
            }
            set
            {
                if (value > 0)
                {
                    Length1 = value;
                }
                else Length1 = 0;
            }
        }
        public int _Length2
        {
            get
            {

                return Length2;
            }
            set
            {
                if (value > 0)
                {
                    Length2 = value;
                }
                else Length2 = 0;
            }
        }
    }
}
