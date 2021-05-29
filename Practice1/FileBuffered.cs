using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{
    class FileBuffered
    {
        static void Main(string[] args)
        {
            byte[] b =Encoding.ASCII.GetBytes("veerababu");

            //new Random().NextBytes(b);
            BufferedStream bs = new BufferedStream(File.Open(@"D:\Practice1\Practice1\Files\Sample.txt",FileMode.OpenOrCreate),8);
            bs.Write(b);

            

            //Console.WriteLine(bs.ReadByte());

            //Console.WriteLine(bs.Length);

            //foreach(byte i in b)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine( bs.ReadByte());
            Console.WriteLine(bs.ReadByte());
        }
    }
}
