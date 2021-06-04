using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{
    class StringReaderwriter
    {
        static void Main(string[] args)
        {
           // string path =@"D:\Practice1\sample\Text1.txt";

            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.WriteLine("babu");
                sw.WriteLine("rallabandi");
                sw.Write("city : bhimavaram");

                sw.Flush();
                sw.Close();
            }
            StringReader sr = new StringReader(sb.ToString());
            //StringReader sr1 = new StringReader("veerababu");
            //Console.WriteLine(sr1.ReadLine());
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
