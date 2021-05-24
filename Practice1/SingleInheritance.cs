using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Abc
    {
        public void show()
        {
            Console.WriteLine("I am method from parent class");
        }
    }
    class SingleInheritance:Abc
    {
        public void show1()
        {
            Console.WriteLine("I am method from child class");
        }
        static void Main(string[] args)
        {
            SingleInheritance si = new SingleInheritance();
            si.show();
            si.show1();
        }
    }
}
