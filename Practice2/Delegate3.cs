using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{

    //This program is pass anonymous as an argument...
    public delegate void helldelegate(string name);
    class Delegate3
    {
        public static void hello(helldelegate obj, string name)
        {
            name += "hello";
            obj(name);

        }
        static void Main(string[] args)
        {
            hello(delegate (string name) { Console.WriteLine("{0}", name); }, "veeerababu");
        }
    }
}
