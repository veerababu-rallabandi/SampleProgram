using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    interface interface1
    {
        void Demo();
        void show();
    }
    interface interface2
    {
        void Demo();
        void show();
    }
    class MultipleInheritance:interface1,interface2
    {
        public void Demo()
        {
            Console.WriteLine("Interface method implemented in child class");
        }
        void interface1.show()
        {
            Console.WriteLine("Interface1 show method implemented in child class");
        }
        void interface2.show()//way2 definition
        {
            Console.WriteLine("Interface2 show method implemented in child class");
        }
        public void detail()
        {
            MultipleInheritance mp = new MultipleInheritance();
            interface1 i = mp;
            i.show();
            interface2 j = mp;
            j.show();
        }

    }
}
