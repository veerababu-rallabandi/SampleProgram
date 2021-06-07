using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Dynamic
    {
        public int age;
        public string name;

        public void printdetails()
        {
            Console.WriteLine("Hello");
        }
    }
    class Dynamickeyword
    {
        public static void print(dynamic value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            print(123);
            print("veerababu");
            print(23.3d);

        //    dynamic obj = new Dynamic();
          //  obj.dummy();  //actually no dummy method in Dynamic class.


            dynamic a = 10;
            
            Console.WriteLine("{0} {1}",a, a.GetType());

            dynamic s = "veerababu";
            Console.WriteLine("{0} {1}",s, s.GetType());
        }
    }
}
