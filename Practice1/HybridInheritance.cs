using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class First11
    {
       public First11(int a)
        {
            Console.WriteLine("I am constrctor from First1 class :"+a);
        }
        public virtual void show()
        {
            Console.WriteLine("I am from first1 class");
        }
    }
    class second1:First11
    {
        public second1(int a):base(a+3)
        {
            Console.WriteLine("I am constructor from second1 classs: "+a);
        }
        public override void show()
        {
            // base.show();
            Console.WriteLine("I am method from second1");
        }

    }
    class HybridInheritance:second1
    {
        public HybridInheritance(int a):base(a+10)
        {
            Console.WriteLine("child class value is"+a);
        }
        static void Main(string[] args)
        {
            HybridInheritance hy = new HybridInheritance(50);
            second1 ss = new second1(10);
            ss.show();
           

        }
    }
}
