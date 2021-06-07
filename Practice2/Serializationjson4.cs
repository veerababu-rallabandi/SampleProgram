using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace Practice1
{
    class product
    {
        public string name { get; set; }
        public int age { get; set; }
        public int[] array { get; set; }
    }

   
    class Serializationjson4
    {
        static void Main(string[] args)
        {
            product p = new product() { name = "veerababu", age = 22,array=new int[3] { 2, 3, 4 } };
            
            string output = JsonConvert.SerializeObject(p);

           


            product obj = JsonConvert.DeserializeObject<product>(output);
            Console.WriteLine(obj);


            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.array[0]);
           
            foreach(int i in obj.array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
