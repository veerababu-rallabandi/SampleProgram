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
            

        }
        public void NumberFormat()
        {
            string s = string.Format("{0:C4}", 1232322);
            Console.WriteLine(s);
            Console.WriteLine(string.Format("{0:c}",1232342));

            Console.WriteLine(string.Format("{0:e}",1232323));
            Console.WriteLine(string.Format("{0:E}",12323232));

            Console.WriteLine(string.Format("{0:f3}",12345645));
            Console.WriteLine(string.Format("{0:F}",12345645));

            Console.WriteLine(string.Format("{0:g}",12342422));
            Console.WriteLine(string.Format("{0:G}",123434343));

            Console.WriteLine(string.Format("{0:n}",12345645));
            Console.WriteLine(string.Format("{0:N4}",12345645));

            Console.WriteLine(string.Format("{0:p}",120));
            Console.WriteLine(string.Format("{0:P1}",130));

           

            Console.WriteLine(string.Format("{0:x}",255));
            Console.WriteLine(string.Format("{0:x}",23));


            System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("fr-FR");
            string s1 = string.Format(cul, "{0:p}", 1000);
            Console.WriteLine(s1);
            
        }
        public void customFormat()
        {
            //0 placeholder
            Console.WriteLine(123.ToString("00000"));//00123
            Console.WriteLine(string.Format("{0:0000}",12));//0012

            Console.WriteLine(string.Format("{0:00.00}",1.2));//01.20

            Console.WriteLine(string.Format("{0:0,0}",12345));//12,345
            Console.WriteLine(string.Format("{0:0,0.0}",12345));//12,345.0

            //#--Digit placeholder
            Console.WriteLine(string.Format("{0:##}", 35.5));//36
            Console.WriteLine(string.Format("{0:####.#}",34.45));//34.5
            Console.WriteLine(string.Format("{0:#####-#####}",9705082873));//97050-82873
            Console.WriteLine(string.Format("{0:(##) ###-##}",12345677));//(123) 456-77
            Console.WriteLine(12343.ToString("(##)##-##"));

            //.-->Decimal point

            Console.WriteLine(string.Format("{0:#0.##%}",.186));//18.6%
            Console.WriteLine(string.Format("{0:0.###E+0}",86000));//8.6E+4

            //,-->It servers as both group separator and number scaling specifier.
            Console.WriteLine(string.Format("{0:#,##}",12356));//12,356

            Console.WriteLine(string.Format("{0:(##)###}",9705082873));

            Console.WriteLine(string.Format("{0:#, ,}",1234));

            //%-percentage placeholder
            Console.WriteLine(string.Format("{0:#0.##%}",1.86));

        }
    }
}
