using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class MyClass
    {
         public string Dummy { get; set; } = "I'm dummy property";
        //public string Dummy { get; } = "I'm dummy property";
    }

    class Example
    {
        public Example()
        {
            // Use private setter in the constructor.
            this.Id = new Random().Next();
        }
        public int Id
        {
            get;
            private set;
        }
    }



    class Program
    {
        static void DoWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };

            Console.WriteLine("Square: number of sides is {0}, length of each side is {1}", 
                square.NumSides, square.SideLength);
            Console.WriteLine("Triangle: number of sides is {0}, length of each side is {1}", 
                triangle.NumSides, triangle.SideLength);
            Console.WriteLine("Pentagon: number of sides is {0}, length of each side is {1}", 
                pentagon.NumSides, pentagon.SideLength);

            var myClass = new MyClass();

            Console.WriteLine(myClass.Dummy);

            myClass.Dummy = "test";
            Console.WriteLine(myClass.Dummy);

            Dummy d = new Dummy();
            Console.WriteLine(d.DisplayName);
            Console.WriteLine(d.CompanyName);
            Console.WriteLine(d.RegCode);

            d.DisplayName = "test";
           // d.CompanyName = "cc";
            d.RegCode = "rr";

            Console.WriteLine(d.DisplayName);
            Console.WriteLine(d.CompanyName);
            Console.WriteLine(d.RegCode);

            Example ex = new Example();
            Console.WriteLine(ex.Id);
           // ex.Id = 22;


        }

        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
