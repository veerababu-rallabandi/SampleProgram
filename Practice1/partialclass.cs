using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
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
    }
    class partialclass
    {
        public void Method1()
        {
            user1 u = new user1("veerababu");
            u.getdetails();
        }
       

    }
}
