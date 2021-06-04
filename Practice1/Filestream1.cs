using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{

    class Filestream1
    {
        static void Main(string[] args)
        {
            string path = @"D:\Practice1\sample\Text11.txt";
            Console.WriteLine("hello");

            byte[] bb=UnicodeEncoding.UTF8.GetBytes("veerababu");


            using (FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                if (f.CanWrite)
                {
                    byte[] a = Encoding.UTF8.GetBytes("veerababu rallabandi");
                    f.Write(a, 0, a.Length);
                }

                f.Flush();
                f.Close();


            }
            using (FileStream f=new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                if (f.CanRead)
                {
                    byte[] b = new byte[1024];
                    int x = f.Read(b, 0, b.Length);
                    Console.WriteLine(Encoding.UTF8.GetString(b, 0, x));
                }

                Console.WriteLine(f.Position);
                Console.WriteLine(f.Length);
                Console.WriteLine(f.Name);
               
                
               
            }









                //FileStream fs1=new FileStream(path,FileMode.Open)











            }
    }
}
