using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{

    /*
    class First22
    {
        public virtual void show()
        {
            Console.WriteLine("I am method from First22");
        }
        public  void Demo()
        {
            Console.WriteLine("I am method demo from first22");
        }
        public void Test1()
        {
            Console.WriteLine("I am test method");
        }
    }
   */
    class Demo51
    {
        public Demo51(int a)
        {
            Console.WriteLine(a);
        }
    }
    class Demo123:Demo51
    {
        public  Demo123(int a):base(a)
        {
            Console.WriteLine(a);
        }
    }
     class BCD
    {
        public virtual void Test1()
        {
            Console.WriteLine("Test-1 method from parent class");
        }
        public void Test2()
        {
            Console.WriteLine("Test-2 method from parent class");
        }
        
    }

    class Methodoverriding:BCD
    {
        public override void Test1()
        {
            Console.WriteLine("Test-1 method from child class");
        }
        public new void Test2()
        {
            Console.WriteLine("Test-2 method from child class");
        }
       
        /* using First22 purpose
        public override void show() //Methodoveriding
        {
            Console.WriteLine("I am method from child class");
        }
        public new void Demo()//Methodhiding or shadowing
        {
            Console.WriteLine("I am method Demo from child class");
        }
        public void Test2()
        {
            Console.WriteLine("I am Test2 method from main method");
        }
        */
        static void Main(string[] args)
        {

            /*
            Methodoverriding mo = new Methodoverriding();
            First22 ff = mo;
            ff.show();//INvoke child class Method
            ff.Demo();//Invoke parent class Method
            */

            Methodoverriding mo = new Methodoverriding();//mo is instance of child class
            BCD p = mo;//p is a reference of parent class created by using child class
            p.Test1();//invokes child classes method
            p.Test2();//invokes parent classes method

            Demo123 de12 = new Demo123(50);
            


           
            
        }
    }

}
