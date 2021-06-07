using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Practice1
{
    [Serializable]
    public class person1
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
    class Serialization2
    {
        static void Main(string[] args)
        {

            string path = @"D:\Practice1\sample\Text16.txt";

            person1 p = new person1() { Fname = "veera", Lname = "rallabandi" };

            xmlserialize(typeof(person1), p, path);

            person1 pp;
            pp = (person1)xmldeserialize(typeof(person1), path);

            Console.WriteLine(pp.Fname);
            Console.WriteLine(pp.Lname);

           
        }

        //XML serialization
        public static void xmlserialize(Type datatype,object data,string path)
        {
              XmlSerializer xmls = new XmlSerializer(datatype);
            if (File.Exists(path))
                File.Delete(path);
            TextWriter tw = new StreamWriter(path);
            xmls.Serialize(tw, data);
            tw.Close();

        }
        //XML Deserialization
        public static object xmldeserialize(Type datatype,string path)
        {
            object obj = null;
            XmlSerializer xmls = new XmlSerializer(datatype);
            if (File.Exists(path))
            {
                TextReader tr = new StreamReader(path);
                obj = xmls.Deserialize(tr);
                tr.Close();
            }
            return obj;
        }
    }
}
