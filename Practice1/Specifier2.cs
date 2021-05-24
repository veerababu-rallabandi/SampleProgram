using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Specifier2:Specifier1
    {
        static void Main(string[] args)
        {
            Specifier2 s = new Specifier2();
            s.@public();
            s.@protected();
            s.@internal();
            s.protectedinternal();
            s.privateprotected();
            
        }
    }
}
