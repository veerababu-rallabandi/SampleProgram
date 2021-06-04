using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Reflection; // It is used to fetch properties from property..

namespace Practice1
{
    
    //class CustomSerialization : IFormatter
    //{
    //    private Type t;


    //    public CustomSerialization(Type type)
    //    {
    //        t = type;
    //    }
    //    public void serialize(Stream serialization, object o)
    //    {
    //        //Get the list of properties
    //        //Write the type name
    //        //Write thee property names and values

    //        PropertyInfo[] l = t.GetProperties();
    //        StreamWriter sw = new StreamWriter(serialization);
    //        sw.WriteLine(t.Name);
    //        foreach (PropertyInfo i in l)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        sw.Flush();
    //        sw.Close();
    //    }
    //    public object deserialize(Stream serialization)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public object Deserialize(Stream serializationStream)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Serialize(Stream serializationStream, object graph)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //custom serialization and deserialization
    class Serializationcustom
    {
        static void Main(string[] args)
        {

        }
    }
}
