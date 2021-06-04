using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{

    // where T : struct  -     Type argument must be a value type
    //where T : class -        Type argument must be a reference type
    //where T : new() -        Type argument must have a public parameterless constructor.
    //where T : <base class> - Type argument must inherit from<base class> class.
    //where T : <interface> -  Type argument must implement from<interface> interface.
    //where T :  U -            There are two type arguments T and U.T must be inherit from U.


    //only allow reference type
    class collection<T> where T:class
    {
        
        public void say()
        {
            Console.WriteLine("hello");
        }
        public void say1<X>()where X : struct
        {
            Console.WriteLine("I am struct type");
        }
    }
    //only allow value type
    class class1<T> where T:struct
    {
        public void say()
        {
            Console.WriteLine("Struct type");
        }
    }

    //allow not reference type
    class class2<T>where T:unmanaged
    {
        public void say()
        {
            Console.WriteLine("I am unmanaged");
        }

    }
    class class3<T> where T : new()
    {
        public class3()
        {
            Console.WriteLine("I am  class3 default constructor");
        }      
    }
    class class4
    {
        public class4()
        {
            Console.WriteLine("I am class4 default constructor");
        }
    }

    class class5
    {
        public class5(int a)
        {
            Console.WriteLine("I am default constructor");
        }
    }
    
   
    
    class collections6
    {
        static void Main(string[] args)
        {

            collection<string> cc = new collection<string>();
            cc.say();
            collection<object> cc1 = new collection<object>();
            cc1.say();
            // collection<int> cc5 = new collection<int>();//invalid , it arises error.

            cc1.say1<int>();
           // cc1.say1<string>();//invalid



            class1<int> cc2 = new class1<int>();
            cc2.say();
            class1<float> cc3 = new class1<float>();
            cc3.say();
            //  class1<string> cc4 = new class1<string>();//it error, invalid


            class2<int> cc5 = new class2<int>();
            cc5.say();

           // class3<int> cc6= new class3<int>();
            //  class4<string> cc7 = new class3<string>();

            class3<class4> cc7 = new class3<class4>();
           // class3<class5> cc8 = new class3<class5>(); //invalid(arires error)


            

            



        }
    }
}

