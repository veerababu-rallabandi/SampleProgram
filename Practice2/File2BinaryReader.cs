using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{
    class File2BinaryReader
    {
       static string path = @"D:\Practice1\Practice1\Files\Sample.txt";
        public static void write()
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                //creating binary files
                using(BinaryWriter bw=new BinaryWriter(file))
                {
                    bw.Write("veerababu");
                    bw.Write(45);
                    char[] a = {'a','b','d'};
                    bw.Write(a);
                    bw.Close();
                    bw.Dispose();
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Read()
        {
            //
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read)))
            {
                //reading data using read() methods
                Console.WriteLine(br.ReadString());
              //  Console.WriteLine(br.PeekChar());

                Console.WriteLine(br.ReadInt32());
              //  Console.WriteLine(br.PeekChar());//character is available or not ,if not returns -1 value..
                foreach(char i in br.ReadChars(3))
                {
                    Console.WriteLine(i);
                }
               
                br.Close();
                
            }
        }
        static void Main(string[] args)
        {

            write();
            Read();
        }
    }
}
