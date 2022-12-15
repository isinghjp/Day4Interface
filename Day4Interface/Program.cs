using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Day4Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IA obj = new B();
            obj.Fun1();
            obj.Fun2();
            IB obj1 = new B();
            obj1.Fun1();
            obj1.Fun2();
        }
    }
    interface IA 
    { 
        void Fun1();
        void Fun2();   
    }
    interface IB
    {
        void Fun1();
        void Fun2();
               
    }

    class B : IA, IB
    {
        void IA.Fun1()
        {
            Console.WriteLine("IA.Fun 1");

        }
        void IA.Fun2()
        {
            Console.WriteLine("IA.Fun 2");
        }
        void IB.Fun1()
        {
            Console.WriteLine(" IB.Fun 1");

        }
        void IB.Fun2()
        {
            Console.WriteLine("IB.Fun 2");
        }
    }
}
