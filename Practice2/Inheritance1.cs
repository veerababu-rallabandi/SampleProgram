using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class class1
    {
        //Explicit constructor
        //  public int a;
        public class1(int i)
        {
            Console.WriteLine("I am class1 constructor" + i);
        }
        public void show()
        {
            Console.WriteLine("I am parent Method");
        }
    }
    class Inheritance1:class1
    {
        Inheritance1(int a) : base(a + 2)
        {

            Console.WriteLine("I am child constructor" + a);
        }
        public void show2()
        {
            Console.WriteLine("I am child method");
        }
        static void Main(string[] args)
        {

           // Inheritance1 ei = new Inheritance1(50);


            /*
            //whenever create instance of child class,--child constructor called parent class constructor.
            Inheritance1 ie = new Inheritance1();
            class1 c = new class1();
            c.show1();
            ie.a = 20;
            Console.WriteLine(ie.a);
            ie.show1();
            ie.show2();


            //way-2 calling 
            class1 c1;//c1 is variable of Class1
            Inheritance1 ie2 = new Inheritance1();//ie2 is instance of Inheritance1 class
            c1 = new class1();//normal way

            // c1 is a reference of parent  class created by using child class instance
            c1 = ie2;
            c1.show1();
            c1.a = 45;
            
            Console.WriteLine(c1.a);

            */

        }
    }
}
