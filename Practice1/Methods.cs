using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Methods
    {

        //without return type & without arguments
        public void Method1()
        {
            Console.WriteLine("I am method1");
        }
        //without return type & with paramaters
        public void Method2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //with return type & without parameters
        public string Method3()
        {
            return "hello";
        }
        //with return type & with parameters
        public string Method4(string name)
        {
            return "hello " + name;
        }

        //By using ref keyword
        public void Method5(ref int a)
        {
            a += a;
        }
        //By using out keyword
        public void Method6(out int a)
        {
            a = 0;
            a += 10;
        }
        //By using params keyword
        public void Method7(params object[] a)
        {
            foreach(object ele in a)
            {
                Console.WriteLine(ele);
            }
        }
        //By using in keyword
        public void Method8(in int a,ref int b)
        {
            b = a + b;
           
        }
    }
}
