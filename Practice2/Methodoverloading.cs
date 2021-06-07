using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public partial class user1
    {
        private int age;
        public user1(int a)
        {
            age = a;
        }
    }
    class First
    {

        //Methodoverloading
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    class second //Methodoverriding example
    { 
        public virtual void say()
        {
            Console.WriteLine("I am second class");
        }
    }
    class Third : second
    {
        public override void say()
        {
            Console.WriteLine("I am third class");
        }
    }

    class Methodoverloading
    {
       public void Method1()
        {
            First f = new First();
            f.add(10, 10);
            f.add(20, 10, 21);
        }
        public void Method2()
        {
            Third t = new Third();
            t.say();
        }
    }
}
