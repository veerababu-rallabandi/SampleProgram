using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class Specifier3
    {
       
        static void Main(string[] args)
        {
            Specifier2 s = new Specifier2();
            s.@public();    
            s.@internal();
            s.protectedinternal();
            
        }
    }
}
