using System;
using System.Collections.Generic;
using System.Text;
using System.IO;          //
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Practice1
{
    
    class Serializationjson
    {
        static void Main(string[] args)
        {
            string path = @"D:\Practice1\sample\Text17.txt";


            //json serilization
            JsonSerializer js = new JsonSerializer();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter sw = new StreamWriter(path);
            
            JsonWriter jw = new JsonTextWriter(sw);


           // person3 p = new person3() { Fname = "veeerababu", Lname = "rallabandi" };
            js.Serialize(jw, new person3() { Fname = "veeeeeeeee", Lname = "rallabandi" });
          
            jw.Close();
            sw.Close();

            //jsonDeserialization

           // JObject obj = null;

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                JsonReader jr = new JsonTextReader(sr);
              //  obj = js.Deserialize(jr) as JObject;

                person3 ppp = js.Deserialize<person3>(jr);
                jr.Close();
                sr.Close();

                Console.WriteLine(ppp.Fname);
                Console.WriteLine(ppp.Lname);
            }
          // person3 pppp= obj.ToObject(typeof(person3)) as person3;
           

          

           
        }
    }
}
