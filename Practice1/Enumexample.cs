using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    enum Days
    {
        monday=5,
        tuesday, 
        wednesday,
        thursday,
        friday,
        satursday,
        sunday
    }
    enum week : byte
    {
        first=7,
        second
    }
    class Enumexample
    {
        public void Method1()
        {

            Console.WriteLine("enum are equal: "+Enum.Equals(week.first,Days.monday));

            Console.WriteLine(Days.friday);
            Console.WriteLine((int)Days.monday);

            Console.WriteLine($"first week value is {(int)week.first}");
            Console.WriteLine();

            //return values of enum
            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }
            
            //returns names of enum
            foreach(string i in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(i);
            }

            
            Console.WriteLine(typeof(Days));

            string s=Enum.GetName(typeof(Days), 5);
            Console.WriteLine("value of 5 is"+s);


            //it returns null, if not found value in enum
            Console.WriteLine("value is "+Enum.GetName(typeof(Days),4));

            Console.WriteLine(Enum.Parse(typeof(Days),"monday").GetType());

            byte a = 1;
            //convert to numeric to enumeration memeber
            Console.WriteLine(Enum.ToObject(typeof(week),a).GetType());


            //  Console.WriteLine(Enum.Format(typeof(week),"first",sa));
            object o = 12;
            Console.WriteLine(Enum.TryParse(typeof(week), "first", out o));


            //exist value in enum or not,return true,it is exist otherwise false
            Console.WriteLine("true or false "+Enum.IsDefined(typeof(week),(byte)7));
            Console.WriteLine("true or false "+Enum.IsDefined(typeof(week),"first"));

            Console.WriteLine(Enum.GetUnderlyingType(typeof(week)));

            week f1 = new week();
            week f2 = new week();
            Console.WriteLine("object are equal : "+Enum.ReferenceEquals((object)f1,(object)f2));

            object ou;
            Console.WriteLine(Enum.TryParse(typeof(week),"first",out ou));
            //compare two value in week
            Console.WriteLine((week.first).CompareTo(week.second));
            //d - return corresponding value
            Console.WriteLine("first is {0}",week.first.ToString("d"));


            //
            // Console.WriteLine("Monday is "+Enum.Format(typeof(Days),"monday","d"));
            week w = week.first;
            Console.WriteLine(w.ToString("d"));
            Console.WriteLine(w);




           
            
        }
    }
}
