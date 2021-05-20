using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class user
    {
        //Default constructor
        public string name;
        public int age;
        public user()
        {
            name = "veerababu";
            age = 22;
        }
        public user(string a,int b)
        {
            name = a;
            age = b;
        }
    }
    class Demo1
    {
        public Demo1()
        {
            Console.Write("welcome ");
        }
        public Demo1(string name) : this()
        {
            Console.Write(name );
        }
        public Demo1(string a,string b) : this(b)
        {
            Console.Write(a);
        }
    }

    class Demo2
    {
        public string name;
        public string loc;
        public Demo2(string x,string y)//parameterized constructor
        {
            name = x;
            loc = y;
        }
        public Demo2(Demo2 d)//It is copy constructor --pass class type object
        {
            name = d.name;
            loc = d.loc;
        }
    }

    class Demo3   //using this static constructor purpose
    { 
        static Demo3()
        {
            Console.WriteLine("I am static constructor");
        }
        public Demo3()
        {
            Console.WriteLine("I am Default");
        }

    }
    class Demo4
    {
        //Private constructor
        private Demo4()
        {
            Console.WriteLine("I am private constructor");
        }

        
        public static string name;
        //parameterized constructor
        public Demo4(string a)
        {
            name = a;
        }
    }



     class Constructor
     {
        public void Method1()
        {
            //Default constructor calling
            user u = new user();

            Console.WriteLine($"default constructor \nName is {u.name}\nage is {u.age}");
            Console.WriteLine();
           
        }
        public void Method2()
        {
            //parameterized constructor. calling
            user u = new user("srinu", 22);
            Console.WriteLine("using parameterized constructor");
            Console.WriteLine(u.name);
            Console.WriteLine(u.age);
            Console.WriteLine();
        }
        public void Method3()
        {
            //constructor overloading
            user u = new user();
            Console.WriteLine("Name is {0}\nage is {1}",u.name,u.age);

            user u1 = new user("ravi", 22);
            Console.WriteLine("Name is {0}\nage is {1}",u1.name,u1.age);
            Console.WriteLine();

        }
        public void Method4()
        {
            //constructor chaining --calling

            Demo1 d = new Demo1("cognine","to");
            Console.WriteLine();

        }
        public void Method5()
        {

            //parameterized constructor calling
            Demo2 d = new Demo2("veerababu","bhimavaram");

            Console.WriteLine($"Name is{d.name} and city is {d.loc}");

            Demo2 d1 = new Demo2(d);//copy constructor calling
            Console.WriteLine( $"Name is {d.name} and city is {d.loc}");
            Console.WriteLine();
        }

        public void Method6()
        {
            //static constructor called automatically

            Demo3 d = new Demo3();
            Demo3 d1 = new Demo3();
            Console.WriteLine();
        }

        public void Method7()
        {
            //calling static constructor
            Demo4 d = new Demo4("veerababu");//calling  parameterized constructor
            Console.WriteLine(Demo4.name);
        }
     }
}
