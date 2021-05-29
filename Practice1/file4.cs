using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice1
{
    class file4
    {
        static void Main(string[] args)
        {
            string path = @"D:\Practice1\sample\Text1.txt";
            Console.WriteLine("hello");

            string[] a = {"veerababu--rallabandi" };
            IEnumerable<string> l = a;
            

           // File.AppendAllLines(path,l);

            //File.AppendAllText(path, "we are cognine employees");

            // File.WriteAllText(path, "I am veerababu");

           // StreamWriter sw=File.AppendText(@"D:\Practice1\sample\Text3.txt");
          //  sw.WriteLine("madhu");

            StreamReader sr = File.OpenText(@"D:\Practice1\sample\Text3.txt");

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }

            //  File.Copy(Path.Combine(@"D:\Practice1\sample\Text1.txt"), Path.Combine(@"D:\Practice1\sample\Text4.txt"));

            File.Copy(@"D:\Practice1\sample\Text4.txt", @"D:\Practice1\sample\Text1.txt",true);

            FileStream fs=File.Create(@"D:\Practice1\sample\Text5.txt");
            StreamWriter se=File.CreateText(@"D:\Practice1\sample\Text1.txt");

            //  File.Create(@"D:\Practice1\sample\Text6.txt", 43);
            //  File.Create(@"D:\Practice1\sample\Text7.txt", 12, FileOptions.RandomAccess);

            //Encrypt file and -- decrypt same file

            //  File.Encrypt(@"D:\Practice1\sample\Text1.txt");

            //Decrypt
            // File.Decrypt(@"D:\Practice1\sample\Text1.txt");


            //    Console.WriteLine(File.ReadAllText(@"D:\Practice1\sample\Text1.txt"));

           // File.CreateText(@"D:\Practice1\sample\Text10.txt");
            File.Delete(@"D:\Practice1\sample\Text10.txt");

            FileAttributes aa= File.GetAttributes(@"D:\Practice1\sample\Text1.txt");
            Console.WriteLine(aa);

            //Console.WriteLine(File.GetCreationTime(@"D:\Practice1\sample\Text1.txt"));
            //Console.WriteLine(File.GetCreationTimeUtc(@"D:\Practice1\sample\Text1.txt"));
            //DateTime dd = DateTime.Now;
            //File.SetCreationTime(@"D:\Practice1\sample\Text7.txt",dd);

            //Console.WriteLine(File.GetCreationTime(@"D:\Practice1\sample\Text11.txt"));

            //read lines from file.
            foreach (string i in File.ReadAllLines(@"D:\Practice1\sample\Text3.txt"))
            {
                Console.WriteLine(i);
            }

            //read line from file
            foreach(string i in File.ReadLines(@"D:\Practice1\sample\Text4.txt"))
            {
                Console.WriteLine(i);
            }
            //try { 
            //string sor = @"D:\Practice1\sample\Text2.txt";
            //string dor = @"D:\Practice1\sample\Text8.txt";
            //string back = @"D:\Practice1\sample\Text9.txt";

            //File.Replace(sor,dor,back);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //File.WriteAllBytes(@"D:\Practice1\sample\Text9.txt", new byte[] { 1, 2, 0 });
            //byte[] bb=File.ReadAllBytes(@"D:\Practice1\sample\Text9.txt");
            //foreach(byte i in bb)
            //{
            //    Console.WriteLine(i);
            //}


            IEnumerable<string> ss = new string[] { "veerababu" };
            File.WriteAllLines(@"D:\Practice1\sample\Text9.txt",ss);
            // File.WriteAllLines(@"D:\Practice1\sample\Text9.txt", new string[] { "veerababu-rallabandi" });


            //FileInfp

            FileInfo ff = new FileInfo(@"D:\Practice1\sample\Text9.txt");

            //Fileinfo properties
            Console.WriteLine(ff.FullName);
            Console.WriteLine(ff.Name);
            Console.WriteLine(ff.Length);
            Console.WriteLine(ff.DirectoryName);
            Console.WriteLine(ff.Directory);
            Console.WriteLine(ff.Exists);

            //FileInfo methods

             StreamWriter sww=ff.AppendText();
            sww.WriteLine("i am from bhimavaram");

            StreamReader srr = new StreamReader(@"D:\Practice1\sample\Text10.txt");
            Console.WriteLine(srr.ReadToEnd()); 




            ////try
            //{
            //    string name = @"D:\Practice1\sample\Text1.txt";
            //    Encrypt
            //    Console.WriteLine("Encrpt" + name);
            //    EncryPt(name);

            //    Decrypt
            //    Console.WriteLine("Decrypt" + name);
            //    DecryPt(name);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //if (!File.Exists(path))
            //{
            //    //create a file and write data to file.
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine("hello");
            //        sw.WriteLine("good morning guys");
            //        sw.WriteLine(10);

            //    }
            //    Console.WriteLine("file is exist");
            //}

            ////open the file to read from specified path
            //using(StreamReader sr = File.OpenText(path))
            //{
            //    Console.WriteLine("hiil");
            //    string s;
            //    while ((s=sr.ReadLine())!= null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

        }
        //public static void EncryPt(string name)
        //{
        //    File.Encrypt(name);

        //}
        public static void DecryPt(string name)
        {
            File.Decrypt(name);
        }
    }
}
