using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{
    class Filestreamwriter
    {
        static void Main(string[] args)
        {
            string path = @"D:\Practice1\sample\Text8.txt";

            write();
            read();
            write1();
            write2();
            //using(StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine(10);
            //    sw.WriteLine("veerababu");
            //    sw.Flush();
            //    sw.Close();
            //}
            //string[] a = File.ReadAllLines(path);
            //foreach(string i in a)
            //{
            //    Console.WriteLine(i);
            //}

        }
        public static void write2()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Practice1\sample\Text.txt"))
            {
                // sw.WriteLine(true);
                // byte[] b = Encoding.UTF8.GetBytes("veeru");


                //sw.WriteLine(new char[] { 'a', 'b' });
                // sw.WriteLine(b);

                //string s = string.Format("{0}\n{1}", "veerababu", "rallabandi");
                //sw.WriteLine(s,)

               
                sw.Close();
            }
            using(StreamReader sr=new StreamReader(@"D:\Practice1\sample\Text.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
        }
        public static void write1()
        {
            StreamReader sr = new StreamReader(@"D:\Practice1\sample\Text9.txt");
            char[] c = new char[6];
            Console.WriteLine(sr.Read(c, 0, c.Length));
           // sr.Close();
            Console.WriteLine(c);

            sr.DiscardBufferedData();
            sr.BaseStream.Seek(3, SeekOrigin.Begin);//return current position starts.
            
            Console.WriteLine(sr.ReadToEnd());
           
        }
        public static void write()
        {
            StreamWriter sw = new StreamWriter(@"D:\Practice1\sample\Text8.txt");

            if (sw.Equals(StreamWriter.Null))
            {
                Console.WriteLine("Itt is null file");
            }
            
            sw.WriteLine("Hello world");
            sw.Close();
        }
        public static void read()
        {
            StreamReader sr = new StreamReader(@"D:\Practice1\sample\Text8.txt");

            //if (sr.Peek() > -1)
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}
            //Console.WriteLine(sr.Peek());
            //Console.WriteLine(sr.ReadToEnd());



            //By using Read() print character by character
            //while(sr.Peek()>=0)
            //{
            //    Console.WriteLine((char)sr.Read());
            //}

            char[] fin = new char[6];
            sr.Read(fin, 0, fin.Length);
            Console.WriteLine(fin);
            sr.Close();


            //text contains -- veerababu..
            StreamReader sr1 = new StreamReader(@"D:\Practice1\sample\Text7.txt");
            //Console.WriteLine(sr1.ReadLine());

            Console.WriteLine(sr1.ReadToEnd());

            //char[] fine = new char[13];
            //sr1.ReadBlock(fine, 0, fine.Length - 7);//6 letter print--veerab
            //Console.WriteLine(fine);
        }
    }
}
