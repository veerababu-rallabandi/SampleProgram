using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{
    //abstract class Text
    //{
    //    int b = 10;
    //    public Text(int a)
    //    {
    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //    }
        
    //}
    class Filetextwriter
    {
        //public Filetextwriter():base(30)
        //{
        //    Console.WriteLine("I am base classse");
        //}

        
        static void Main(string[] args)
        {
            // Filetextwriter fts = new Filetextwriter();

            write();
            read();
        }
        static void write()
        {
            using(TextWriter tw = File.CreateText(@"D:\Practice1\sample\Text4.txt"))
            {
                tw.Write("hello");
                tw.Write("veerababu");
                tw.Write(new StringBuilder("veerababu"));
                Console.WriteLine(tw.NewLine);
                
                tw.Close();
            }
        }
        static void write1()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("veerababu");

           
        }
        static void read1()
        {
           
        }
        static void read()
        {
            using(TextReader tr = File.OpenText(@"D:\Practice1\sample\Text4.txt"))
            {
                if (tr.Peek() > -1)
                {
                    Console.WriteLine(tr.ReadLine());
                    //  Console.WriteLine(tr.Read());
                    // Console.WriteLine(tr.ReadLine());
                    // Console.WriteLine(tr.ReadToEnd());
                    
                }
               
            }
        }
    }
}
