using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Practicepurpose
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("veerababu");
            l.Add("madhu");
            l.Add("mahesh");
            l.Add("sampath");

            List<int> ll = new List<int>();
            ll.Add(1992);
            ll.Add(1991);
            ll.Add(1997);
            ll.Add(2001);
            ll.Add(2005);

            //IEnumerable<int> ien=(IEnumerable<int>)ll;


            /*
            IEnumerable<int> ien = ll;
            foreach(int i in ien)
            {
                Console.WriteLine(i);
            }

            IEnumerable<string> ienum = l;
            foreach(string s in ienum)
            {
                Console.WriteLine(s);
            }

            IEnumerator<string> ienum1 = l.GetEnumerator();
            while (ienum1.MoveNext())
            {
                Console.WriteLine(ienum1.Current.ToString());
            }*/


            /*by using IEnumerator
            IEnumerator<int> ien = ll.GetEnumerator();
            Iteratebelow2000(ien);
            */
            IEnumerable<int> ien = (IEnumerable<int>)ll;
            Iteratebelow2000(ien);

        }
        static void Iteratebelow2000(IEnumerable<int> o)
        {

             foreach(int i in o)
            {
                Console.WriteLine(i);
                if (i > 2000)
                {
                    Iterateabove2000(o);
                }
            }

            
            /*By using IEnumerator interface
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
                if (Convert.ToInt16(o.Current) < 2000)
                {
                    Iterateabove2000(o);
                }
            }
            */
        }
        static void Iterateabove2000(IEnumerable<int> o)
        {

            foreach(int i in o)
            {
                Console.WriteLine(i);
            }

            /*By using IEnumerator
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
            }
            */
        }
    }
}
