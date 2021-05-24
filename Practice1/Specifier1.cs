using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class Specifier1
    {
        public void @public()
        {
            Console.WriteLine("I am public Method");
        }
        private void @private()
        {
            Console.WriteLine("I am private Method");
        }
        protected void @protected()
        {
            Console.WriteLine("I am protected Method");
        }
        internal void @internal()
        {
            Console.WriteLine("I am internal Method");
        }
        protected internal void @protectedinternal()
        {
            Console.WriteLine("I am protected internal Method");
        }
        private protected void @privateprotected()
        {
            Console.WriteLine("I am privateprotected Method");
        }
        static void Main(string[] args)
        {

            Specifier1 s = new Specifier1();
            s.@public();
            s.@private();
            s.@protected();
            s.@internal();
            s.protectedinternal();
            s.privateprotected();

        }
    }
}
