using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{

    //This class is Subscriber
    class EventEx1
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            //Event gets binded with delegates
            a.eventOddNumber += new AddTwoNumbers.delegateOddNumber(EventMessage);
            a.lengthevent += new AddTwoNumbers.delegateOddNumber(new EventEx1().Eventmsg);
            
            a.Add();
            a.compare();
        }
        static void EventMessage()
        {
            Console.WriteLine("Event is executed:This is odd number");
        }
        public void Eventmsg()
        {
            Console.WriteLine("Only allow below 6 letter name");
        }
    }
    //This is Publisher Class
    class AddTwoNumbers
    {
        public delegate void delegateOddNumber(); //Declared Delegate     
        public event delegateOddNumber eventOddNumber; //Declared Events
        public event delegateOddNumber lengthevent;

        public void Add()
        {
            int result;
            result = 5 + 10;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (eventOddNumber != null))
            {
                eventOddNumber(); //Raised Event
            }
        }
        public void compare()
        {
            string s = "veera";
            Console.WriteLine(s);
            if (s.Length > 6 && lengthevent!=null)
            {
                lengthevent();
            }
        }
    }

   
}
