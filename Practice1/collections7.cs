using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    interface interface11
    {
        void say();
    }
    class DEMO<T>where T:interface11
    {

    }
    class class9
    {
        public void say()
        {
            Console.WriteLine("I am classs 9");
        }
    }
    class class10:interface11
    {
        public void say()
        {
            Console.WriteLine("good morning");
        }
    }
    class collections7
    {
        static void Main(string[] args)
        {
            DEMO<class10> cc9 = new DEMO<class10>();
            //DEMO<class9> cc10=new DEMO<class9>

        }
    }
}
