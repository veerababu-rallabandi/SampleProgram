using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice1
{
    class Directorfile3
    {
       
        static void Main(string[] args)
        {

            //Directory.CreateDirectory(@"E:\sample");
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //foreach (string i in Directory.GetDirectories(@"E:\sample", "*.txt", SearchOption.AllDirectories))
            //{
            //    Console.WriteLine(i);
            //}
            //Directory.Delete(@"E:\sample");  ".*"--directories
            //Directory.Delete(@"D:\Practice1\sample", true);
            
            // IEnumerable<string> di=Directory.EnumerateFileSystemEntries(@"E:\sample2");
            //foreach(string i in di)
            //{
            //    Console.WriteLine(i);
            //}

            IEnumerable<string> s= Directory.EnumerateFileSystemEntries(@"E:\sample2", "?.txt");
            foreach(string i in s)
            {
                Console.WriteLine(i);
            }


            DirectoryInfo dir = new DirectoryInfo(@"E:\sample");
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Exists);
            Console.WriteLine(dir.CreationTime);
            FileAttributes fb=dir.Attributes;
            Console.WriteLine(fb.ToString());

            //Console.WriteLine(dir.CreateSubdirectory(@"E:\sample"));

            IEnumerable<FileSystemInfo> lll=dir.EnumerateFileSystemInfos();
            foreach(FileSystemInfo i in lll)
            {
                Console.WriteLine(i);
            }

            
            Console.WriteLine(dir.Extension);


            //Driver Info
            DriveInfo dd=new DriveInfo(@"E:\");
            Console.WriteLine(dd.Name);
            Console.WriteLine(dd.TotalSize);
            Console.WriteLine(dd.AvailableFreeSpace);
            Console.WriteLine(dd.TotalFreeSpace);
            Console.WriteLine(dd.RootDirectory);
            Console.WriteLine(dd.ToString());

           


           // string source = @"D:\Practice1\Practice1\Files";
           // string Dest = @"D:\Practice1\Practice1\copyfiles";
           // Console.WriteLine(source.Length);

           // Console.WriteLine(Directory.Exists(Dest));
           // //Directory.Delete(@"D:\Practice1\Demofile");

           // //Directory.CreateDirectory(@"D:\Practice1");


           // //Retrieves files from specified directory
           // string[] files=Directory.GetFiles(Dest,"*",SearchOption.AllDirectories);
           // foreach(string i in files)
           // {
           //     Console.WriteLine(i);
           // }

           // //Retrieves directories from specified path
           //string[] dirs= Directory.GetDirectories(Dest);
           // foreach(string i in dirs)
           // {
           //     Console.WriteLine(i);
           // }

           // //retreives directories
           // IEnumerable<string> ll=Directory.EnumerateDirectories(@"E:\");
           // foreach(string i in ll)
           // {
           //     Console.WriteLine($"Directory name: {i}");
           // }


           // //creation of time
           // DateTime t=Directory.GetCreationTime(@"E:\");
           // Console.WriteLine(t);

           // string[] ss=Directory.GetDirectories(@"E:\","*.*");
           // foreach(string i in ss)
           // {
           //     Console.WriteLine(i);
           // }


           // //retrieve root directory.
           //string rootdirectory= Directory.GetDirectoryRoot(@"E:\");
           // Console.WriteLine(rootdirectory);

           // //get files in directories (include subdirectories)
           // foreach(string i in Directory.GetFiles(@"E:\sample"))
           // {
           //     Console.WriteLine(i);
           // }

            

            //try
            //{
            //    var files = Directory.EnumerateFiles(source," *.txt");
            //    IEnumerable<string> l =Directory.EnumerateFiles(source, "*.txt");
            //    foreach(string i in l)
            //    {
            //        string filename = i.Substring(source.Length + 1);
            //        Directory.Move(source, Path.Combine(Dest,filename));
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }
    }
}
