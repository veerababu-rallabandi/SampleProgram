using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    abstract class Demo434
    {
        public abstract void say();
    }
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
        public virtual void hello()
        {

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
        public override void hello()
        {
            Console.WriteLine("i am child hello");
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
            
            Console.WriteLine(string.Format("{0:4}","veerababu"));
        }
    }
}
