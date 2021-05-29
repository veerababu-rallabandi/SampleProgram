using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice1
{
    class File2Binary
    {
        static void Main(string[] args)
        {
            Encoding ascii = Encoding.ASCII;
            string filename = @"D:\Practice1\Practice1\Files\Sample.txt";

            using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Create),ascii))
            {
                bw.Write(10);
                bw.Write(97);
                
            }
            using(BinaryReader br=new BinaryReader(File.Open(filename, FileMode.Open)))
            {
               
                int i = br.ReadInt32();
                Console.WriteLine(i);
                Console.WriteLine(br.ReadBoolean());




            }
        }
    }
}
