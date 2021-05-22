using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    interface Iuser1
    {
        
         void add(int a,int b);
    }
    interface Iuser2 : Iuser1
    {
        void sub(int a, int b);
    }

    class Interfacepurpose:Iuser2
    {
     
       
       // void Iuser1.add(int a,int b)//way 2 use definition of interface member.
        public void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void sub(int a,int b)//way 1 use definition interface member
        {
            Console.WriteLine(a-b);
        }
        public void Method1()
        {
            Interfacepurpose Ip = new Interfacepurpose();
            Ip.add(10, 20);
            Ip.sub(20, 10);

            Iuser2 i = Ip;
            i.add(10, 30);
            i.sub(40, 15);
        }
    }
}
