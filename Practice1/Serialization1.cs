using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //include two namespace

namespace Practice1
{
    [Serializable]  //It is attribute--> It is allow to serializable to this class..
    public class person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
    public class Dataserializer
    {
        public void BinarySerialize(object data,string path)
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            fs = File.Create(path);
            bf.Serialize(fs, path);
            fs.Close();
        }
        public object BinaryDeserialize(string path)
        {
            object obj=null;
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path))
            {
                fs=File.OpenRead(path);
                obj = bf.Deserialize(fs);
                fs.Close();
            }
            return obj;
        }
    }
    class Serialization1
    {
        static void Main(string[] args)
        {
            //person p = new person() {Fname="veerababu",Lname="rallabandi" };
            //string path = @"D:\Practice1\sample\Text.txt";
            //Dataserializer d = new Dataserializer();
            //person pp =null;



            //d.BinarySerialize(p, path);//serialize

            //pp = d.BinaryDeserialize(path) as person;//deserialize
            //  Console.WriteLine(pp.Fname);


            string path= @"D:\Practice1\sample\Text.txt";

            person p = new person() { Fname = "veerababu", Lname = "rallabandi" };

            BinaryFormatter fs = new BinaryFormatter();
            Stream ss = new FileStream(@"D:\Practice1\sample\Text.txt", FileMode.Create, FileAccess.Write);

            fs.Serialize(ss, path);
            ss.Close();

            Stream sb = new FileStream(path, FileMode.Open, FileAccess.Read);
            person pp = (person)fs.Deserialize(sb);

            Console.WriteLine(pp.Fname);
            Console.WriteLine(pp.Lname);
            sb.Close();
            


        }
    }
}
