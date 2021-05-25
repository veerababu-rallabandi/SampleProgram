using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public delegate void Adddelegate(int x, int y);
    public delegate string saydelegate(string name);
    class Delegate1
    {
        public void add(int a,int b)
        {
            Console.WriteLine($"Addition is { a + b}");
        }
        public static string say(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            //Delegate1 ddd = new Delegate1();

            Adddelegate ad = new Adddelegate(new Delegate1().add);
            ad(10, 20);
            ad.Invoke(14, 2);//by using invoke method

            saydelegate sd = new saydelegate(say);// no need to instance of class bcoz it is static method
            Console.WriteLine(sd("veerababu"));
            Console.WriteLine(sd.Invoke("veera"));
        }
    }
}
