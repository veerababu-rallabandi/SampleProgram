using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public struct user123
    {
        public int i;
        public bool a;

        /* Arises error, always default constructor implicitly,but only define 
         * parameterized constructor in structure
        public user123()
        {

        }
        */

        //It is no problem, it is paramterized consturctor.
        public user123(int i,bool a)
        {
            this.i = i;
            this.a = true;
        }
        public void show()
        {
            Console.WriteLine("I am method in structure="+i);
            Console.WriteLine(a);
        }
    }
    class Demo22
    {
        public int a;
        public Demo22(int a)
        {
            this.a = a;
        }

    }
    class Structure
    {
        
         public void Method1()
        {
            
        }
        static void Main(string[] args)
        {

            Demo22 dd = new Demo22(34);//default constructor overrided. use like that new Demo22()--arises error.
            Console.WriteLine(dd.a);
            //way1
            user123 u = new user123();//i=0 automatically assign i=0 default constructor.
            u.show();

            //way2
            user123 u1;
            u1.i= 10;
            u1.a = true;
            u1.show();//--arises error, definitely initialize i in u1.i=10;


            //Way
            //In structure two constructor,default always implicity 
            user123 u2 = new user123();//implicit contructor
            u2.show();
            user123 u3 = new user123(23, true);//explicit constructor.
            u3.show();


            
        }
        
    }
}
