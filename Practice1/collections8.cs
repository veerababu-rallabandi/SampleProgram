using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class parent
    {
        public void demo1()
        {
            Console.WriteLine("demo1 method in parent class");
        }
    }
    class child:parent
    {
        public void demo()
        {
            Console.WriteLine("Demo method in child class");
        }
    }
    class child1:parent
    {
        public void demo2()
        {
            Console.WriteLine("demo2 method in child1 class");
        }
    }
    class class13<T> where T : parent
    {
        public void say()
        {
            Console.WriteLine("hello guys , I am say method in class13 class");
        }
    }
    class collections8
    {
        static void Main(string[] args)
        {

            class13<child> cc14 = new class13<child>();
            cc14.say();

            // class13<child1> cc15 = new class13<child1>();It is error , bcoz child1 cannot inherited to base class i.e parent class.

            class13<child1> cc15 = new class13<child1>();
            cc15.say();
          
        }
    }
}
