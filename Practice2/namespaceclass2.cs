using System;
using System.Collections.Generic;
using System.Text;
using Second;
using sf=Second.Fourth;//alias purpose

using static Practice1.Demo12.Demonamespace;




namespace Practice1
{
    class namespaceclass2
    {

        static void Main(string[] args)
        {

            //Access non-static memebers --way 1
            Second.Sample f = new Second.Sample();
            f.say();

            //Access static memebers--way2
            Second.Sample.demo();

            //using namespace above declare,after simple create object of particular class.
             Sample s = new Sample();
             s.say();
            

            //Nested namespace calling

            // Second.Fourth.Sample12.add(2, 4);
            // Sample12.add(3, 4);

            //using alias name of namespace
            sf.Sample12.add(2, 3);




            //using static main calling

            Message();

            

        }
    }
}
namespace Second
{
    class Sample
    {
        public  void say()
        {
            Console.WriteLine("hello");
        }
        public static void demo()
        {
            Console.WriteLine("good morning");
        }
    }
}

//using Nested namespace
namespace Second
{
    namespace Fourth
    {
        class Sample12
        {
            public static void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
        }

    }
    
}


