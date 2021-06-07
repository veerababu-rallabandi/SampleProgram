using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{

    /*
    public partial class user1
    {
        private string name;
        public user1(string name)
        {
            this.name = name;
        }
        public static void say()
        {
             int a;

        }
    }
    public partial class user1
    {
        public void getdetails()
        {
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Age is {age}");
        }
    }*/


    public partial class user2 
    {
        public void Method1()
        {
            Console.WriteLine("I am partial class 1");
        }
       
    }
    public partial class user2
    {
        public void Method2()
        {
            Console.WriteLine("I am partial class 2");
        }
        
    }
    public partial class Home
    {
        partial void Get();
       public Home()
        {
            Get();
        }
         partial void Get()
        {
            Console.WriteLine("I am partial method");
        }
    }


    class partialclass
    {

        
        public void Method1()
        {

            /*
            user1 u = new user1("veerababu");
            u.getdetails();
            */

            //calling partial class

            user2 u = new user2();
            u.Method1();
            u.Method2();
            u.Method3();
        }
        
       

    }
}
