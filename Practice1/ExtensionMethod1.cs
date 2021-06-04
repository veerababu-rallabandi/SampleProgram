using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    
    struct structure
    {
        public void show1()
        {
            Console.WriteLine("I am show1 method in structure");
        }
    }
    sealed class ExtensionMethod1
    {
        public void Demo1()
        {
            Console.WriteLine("I am Demo1 method in ExtensionMethod1 class");
        }
        public void Demo2()//same methodname in ExtensionMethod2 also but only original method -->Demo2() in ExtensionMEthod1 will execute
        {
            Console.WriteLine("I am Demo2 method in ExtensionMethod1 class");
        }
        static void Main(string[] args)
        {
            ExtensionMethod1 ex = new ExtensionMethod1();
            ex.Demo1();
            ex.Demo2();
            ex.Demo3("veerababu");
            Console.WriteLine(Math.Sqrt(9));
            int i = 7;
            Console.WriteLine(i.prime());
             string s = "veerababu rallabandi";
             Console.WriteLine(s.reverse());

             

            //structure purpose
            structure st = new structure();
            st.show1();
            st.show2();

            
            
            

        }
    }
}
