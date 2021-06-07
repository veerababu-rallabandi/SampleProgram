using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class First1
    {
        public void show()
        {
            Console.WriteLine("I am method from first1 class");
        }
    }
    class Second1:First1
    {
        public void show1()
        {
           // base.show();//by using base keyword --It is used to call method from parent class.
            Console.WriteLine("I am method from second1 class");
        }
    }
    class Multilevelinheritance:Second1
    {
        static void Main(string[] args)
        {
            Multilevelinheritance mi = new Multilevelinheritance();
            mi.show();
            mi.show1();
            
        }
    }
}
