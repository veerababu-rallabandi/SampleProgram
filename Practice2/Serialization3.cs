using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Practice1
{
    [Serializable]
    class person3
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
    class Serialization3
    {
        static void Main(string[] args)
        {
            person3 pp3 = new person3() { Fname = "madhu", Lname = "mahesh" };


            //serialization using DatacontractJSonSerializer in JSON Format.
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(person3));
            MemoryStream ms = new MemoryStream();
            ds.WriteObject(ms, pp3);
            ms.Position = 0;

            StreamReader sr = new StreamReader(ms);

            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
            ms.Close();

            

            using (MemoryStream b = new MemoryStream(Encoding.Unicode.GetBytes(s)))
            {
                //Deserialization in json using DataContractJsonSerializer

                //DataContractJsonSerializer dd = new DataContractJsonSerializer(typeof(person3));

                person3 pp = ds.ReadObject(b) as person3;
                Console.WriteLine(pp.Fname);
                Console.WriteLine(pp.Lname);

            }


        }
    }
}
