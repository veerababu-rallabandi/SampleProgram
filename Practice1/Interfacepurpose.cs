using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    interface Iuser
    {
         void say();
    }
    class Interfacepurpose:Iuser
    {
     
        public void say()
        {
            Console.WriteLine("heeloo");
        }
    }
}
