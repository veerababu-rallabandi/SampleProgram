using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice1
{
    class Files1
    {
        static void Main(string[] args)
        {
            //string path = "D:\\Practice1\\Practice1";

            //string path1 = @"D:\Practice1\Practice1\Sample.txt";

            //string[] dirs = Directory.GetDirectories(path); //directories

            //string[] dirs1 = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            //foreach(string i in dirs1)
            //{
            //    //display all directories include subdirectories also...
            //    Console.WriteLine(i);

            //}

            ////Getfile --display all files
            //string[] files = Directory.GetFiles(path,"*.*",SearchOption.AllDirectories);

            //foreach (string i in files)
            //{
            //    //Console.WriteLine(i);
            //    //Console.WriteLine(Path.GetFileName(i));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(i));
            //    //Fileinfo
            //    var ff = new FileInfo(i);
            //    Console.WriteLine($"{ff.Length} bytes");



            //}

            ////File.Create(path);
            ////IEnumerable<string> l = new List<string>() { "veerababu is cognine employee"};

            ////File.AppendAllLines(path, l);

            //foreach(string i in dirs)
            //{
            //    Console.WriteLine(i);
            //}

            //if (File.Exists(path1))
            //{
            //    Console.WriteLine("file is exist");
            //    File.CreateText("hello gusy");

            //}
            //else
            //{
            //    Console.WriteLine("file is not exist");
            //}



            ////print char by char
            //string s = File.ReadAllText(path1);
            //foreach(char i in s)
            //{
            //    Console.WriteLine(i);
            //}

            ////Line by line print
            //IEnumerable<string> l = File.ReadLines(path1);
            //foreach (string i in l)
            //{
            //    Console.WriteLine(i);
            //}


            
            string path2= @"D:\Practice1\Files\sample2..txt";
           
            if (File.Exists(path2))
            {
                //  Console.WriteLine("It is exist");
                File.Delete(path2);
            }
            using(FileStream fs=File.Create(path2))
            {

               // File.AppendAllLines(path2,)
               // fs.Write("hello");
            }

            
        }
    }
}
