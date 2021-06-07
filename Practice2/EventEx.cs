using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Aa
    {
        
    }
    public delegate void Transform(int x);

    class EventEx
    {
        static void Main(string[] args)
        {

            //in class Aa has delegate --Aa.Transform t;
            Transform t; //create the instance

            t = add;  //point to the function

            t += sub; //two methods till now

            t.Invoke(20); //invoking the delegate --first using multi casting


            Notification obj = new Notification();
            //By using multi cast delegate 

            //  obj.transformevent += user11.xhander;
            //   obj.transformevent = user22.yhander;//remove + symbol ,only user22 object received, only delegate receives user22 reference.


            obj.transformevent += user11.xhander;
            obj.transformevent += user22.yhander; //You can just subscribe or unsubscribe the event by += or -= operators and nothing else.


            obj.Notify(15);
        }
        static void add(int x)
        {
            Console.WriteLine(x+x);
        }
        static void sub(int x)
        {
            Console.WriteLine(x-x);
        }
    }
    class Notification
    {
        public event Transform transformevent; //It is a delegate
        /*whenever use event keyword , it's turn into event 
         * Note: event is could not define alone, pair with delegate. If remove above delegate arises error.
         */

        public void Notify(int x)
        {
            if (transformevent != null)
            {
                //transformevent(x);
                transformevent.Invoke(x);
            }
        }
    }
    class user11
    {
        public static void xhander(int x)  //Notification message method
        {
            Console.WriteLine("Event received by user11 object");
        }
       
    }
    class user22
    {
        public static void yhander(int x)
        {
            Console.WriteLine("Event received by user22 object");
        }
    }
}
