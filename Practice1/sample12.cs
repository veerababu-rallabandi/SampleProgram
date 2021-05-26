using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
     class A
    {
       public A()
        {
            Console.WriteLine("A constructor");
        }
        public virtual void say()
        {
            Console.WriteLine("A method");
        }
    }
    class B:A
    {
        public B():base()
        {
            Console.WriteLine("B constructor");
        }
        public override void say()
        {
            Console.WriteLine("B Method");
        }
    }
    class sample12:A
    {
        
        static void Main(string[] args)
        {
            A a = new A();// A()
            B b = new B();//a and b
            A c = new B();// a b
            a.say();
            b.say();
            c.say();
        }
    }
}
