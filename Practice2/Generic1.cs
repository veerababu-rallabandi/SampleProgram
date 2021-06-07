using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{

    //Generic constraints
    public class First111<T> 
    {
        public T add(T a, T b)
        {

            dynamic val1 = a;
            dynamic val2 = b;
            return val1 + val2;

        }


        //public T Max(T a, T b)
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}
    }
    class second123
    {
        public bool compare<T>(T d,T d1)//Generic Method
        {
            if (d.Equals(d1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    //Generic class
    class Third22<T>
    {
        public T message;
        public void say(T name)
        {
            Console.WriteLine($"{message} and {name}");
        }
        //Generice Method
        public void show<T>(T msg)
        {
            Console.WriteLine("Welcome to "+msg);
        }

        //using property with Generic Type

        //private data member
        private T data;
        public T Value
        {

            //using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        

    }

    //Declare Generic delegate
    public delegate T adddelegate<T>(T a, T b);
    
    class Fourth<T>
    {
        
        public T add(T a,T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        public T sub(T a, T b) 
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }
    }
    class Generic1
    {
        static void Main(string[] args)
        {
            First111<int> f = new First111<int>();
            Console.WriteLine(f.add(1, 2));
            First111<string> f1 = new First111<string>();
            Console.WriteLine(f1.add("veerababu","rallabandi"));

            //First111<string> s = new First111<string>();
            //s.say("veerababu", "rallabandi");

            second123 ss = new second123();
            Console.WriteLine(ss.compare<string>("veerababu", "veerababu"));
            Console.WriteLine(ss.compare<int>(40,40));

            //int a = 12;
            //a.Equals(12);
          //  First111<int> f = new First111<int>();
           // Console.WriteLine(f.Max(10, 20));


            //Calling Generic class
            Third22<int> t = new Third22<int>();
            t.message = 12;
            t.say(32);

            //property
            t.Value = 34;
            Console.WriteLine(t.Value);

            Third22<string> tt = new Third22<string>();
            tt.message = "veeerababu";
            tt.say("rallabandi");

            //Generic Method calling
            tt.show<int>(34);
            tt.show<string>("Madhu");

            //calling property
            tt.Value = "veerababu-rallabandi";
            Console.WriteLine(t.Value);


            //Generic Delegate Calling
            Fourth<int> ff = new Fourth<int>();
            adddelegate<int> ad = new adddelegate<int>(ff.add);
            Console.WriteLine(ad(20, 30));
            ad += ff.sub;
            Console.WriteLine(ad.Invoke(23,17));


            
            



        }
    }
}
