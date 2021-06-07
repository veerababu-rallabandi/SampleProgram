using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Generic2
    {
        public void add<T>(T a,T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x+y);
        }
        public void sub<T>(T a,T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x+y);
        }
        public bool compare(object a,object b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Generic2 g = new Generic2();
            Console.WriteLine(g.compare(12,32));
            Console.WriteLine(g.compare(12.3f,23.3));//In this not type safe
            g.add<int>(12, 30);
            g.sub<float>(12.3f, 32.4f);

            //Generic<int> g=new Generic2<int>();//not required to pass to every method.
        }
    }
}
