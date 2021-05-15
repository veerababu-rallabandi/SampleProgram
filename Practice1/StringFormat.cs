using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class StringFormat
    {
        DateTime d = new DateTime(2021, 7, 15);

        public void Method1()
        {
            
            Console.WriteLine(string.Format("{0:D}",d));
        }
        public void Method2()
        {

            TimeSpan t = new TimeSpan(3, 16, 45);

            decimal a = 24.3m;
            decimal b = 45.3m;

            Console.WriteLine(string.Format("Temparature on {0:d}:\n{1,11}:{2} degree" + "(hi)\n{3,11}: degrees (lo)", d, a, t, b));


        }
        public void DateFormat()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(string.Format("{0:d}",d));
            Console.WriteLine("{0:dd}",d);
            Console.WriteLine("{0:ddd}",d);
            Console.WriteLine("{0:dddd}",d);
            Console.WriteLine("{0:D}",d);
            Console.WriteLine("{0:f}", d);
            Console.WriteLine("{0:ff}",d);
            Console.WriteLine("{0:fff}",d);
            Console.WriteLine("{0:ffff}",d);
            Console.WriteLine("{0:F}",d);
            Console.WriteLine("{0:g}",d);
            Console.WriteLine("{0:gg}",d);
            Console.WriteLine("{0:hh}",d);
            Console.WriteLine("{0:HH}",d);
            Console.WriteLine("{0:M}",d);
            Console.WriteLine("{0:mm}", d);
            Console.WriteLine("{0:MM}",d);
            Console.WriteLine("{0:MMM}",d);
            Console.WriteLine("{0:MMMM}",d);
            Console.WriteLine("{0:ss}",d);
            Console.WriteLine("{0:r}",d);
            Console.WriteLine("{0:s}",d);
            Console.WriteLine("{0:t}",d);
            Console.WriteLine("{0:T}",d);
            Console.WriteLine("{0:tt}",d);
            Console.WriteLine("{0:u}",d);
            Console.WriteLine("{0:U}",d);
            Console.WriteLine("{0:y}",d);
            Console.WriteLine("{0:yy}",d);
            Console.WriteLine("{0:yyyy}",d);
            Console.WriteLine("{0:zz}",d);
            Console.WriteLine("{0:zzz}",d);

        }
    }
}
