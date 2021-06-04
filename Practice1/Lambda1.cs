using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public delegate string namedelegate(string s);
    class Lambda1
    {
        static void Main(string[] args)
        {

            //using anonymous method
            namedelegate obj1 = new namedelegate(
                                 delegate(string s)
                                 {
                                     return "hello "+s;
                                 }
                                );

            Console.WriteLine(obj1.Invoke("veerababu"));


            //By using Lambda expression above code

            namedelegate obj2 = s => "hello " + s;
            Console.WriteLine(obj2("madhu"));


            //By using func delegate above code --Lambda+func
            Func<string,string> obj3 = s => "hello " + s;
            Console.WriteLine(obj3("mahesh"));

            //By using Lambda+Action

            Action<string> obj4 = s => Console.WriteLine("welcome to "+s);
            obj4("sampath");


            //By using predicate delegate

            Predicate<string> obj5 = s => s.StartsWith('s');
            Console.WriteLine(obj5("satya"));
            bool r = obj5.Invoke("sampath");
            Console.WriteLine(r);


            List<string> l = new List<string>();
            l.Add("veeru");
            l.Add("sadhumahesh");
            l.Add("suresh");
            string res = l.Find(obj5);
            Console.WriteLine($"Name is {res}");
        }
    }
}
