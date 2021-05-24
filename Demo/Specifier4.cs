using System;
using Practice1;
namespace Demo
{
     class Specifier4:Specifier1
    {
        static void Main(string[] args)
        {
            Specifier4 s = new Specifier4();
            s.@public();
            s.protectedinternal();
            s.@protected();
            
        }
    }
}
