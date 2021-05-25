using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public delegate string hellodelegate(string NAME);
   
    class AnonymousDelegate
    {
        
        public static string say(string name)
        {
            return "Hello " + name;
        }
        
       
        static void Main(string[] args)
        {
            
            //Normal calling
            hellodelegate hd1 = new hellodelegate(say);
            Console.WriteLine(hd1.Invoke("veera"));


            //Anonymous Method delegate
            hellodelegate hd = delegate (string name)
            {
                return "hello " + name;
            };

            string s = hd("veerababu");
            Console.WriteLine(s);
            
            

           
           
        }
    }
}
