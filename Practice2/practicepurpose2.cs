using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    static class BCDE
    {
       public  static int a;
         static BCDE()
        {
            Console.WriteLine("I am static default constructor..");
        }
        public static void say()
        {
            Console.WriteLine("I am say method from static class");
        }
    }
    abstract class abstractDemo
    {
        int a=20;
        public abstractDemo()
        {
            Console.WriteLine("I am abstract default constructor"+a);
        }
        abstract public  void Demo();
        public void say()
        {
            Console.WriteLine("I am Non-abstract Method");
        }
       
    }
     class practicepurpose2:abstractDemo
     {
        public override void Demo()
        {
            Console.WriteLine("I am abstract method definintion");
        }
        static practicepurpose2()
        {
            Console.WriteLine("I am static constructor");
        }
        public practicepurpose2()
        {
            Console.WriteLine("I am normal constructors");
        }
        static void Main(string[] args)
        {

            //Normal class but it has static constructor..
            practicepurpose2 pp = new practicepurpose2();
            practicepurpose2 pp1 = new practicepurpose2();
            

            //static class
            BCDE.say();
            BCDE.a = 20;
            Console.WriteLine(BCDE.a);
            Console.WriteLine();
        }
    }
}
