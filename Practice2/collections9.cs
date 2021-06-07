using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    interface interface12
    {
        void say();
    }
    class class11 : interface12
    {

        public void say()
        {
            Console.WriteLine("I am say methdo");
        }

    }
    class class13
    {

    }
    public class class12<T, U> where T:U
    {
        public void Demo()
        {
            Console.WriteLine("Demo method");
        }
    }
    class collections9
    {
        static void Main(string[] args)
        {
            /*
            In this constraint, there are two type arguments T and U. U can be a interface, 
            abstract class, 
            or simple class. T must inherit or implements the U class.*/

            class12<class11,interface12> cc12 = new class12<class11,interface12>();
            cc12.Demo();
            

        }

    }
}
