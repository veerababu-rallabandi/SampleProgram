using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class Jumping
    {
        public void jum1()
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public int jum2()
        {
            int i = 0;
            while (i < 3)
            {
                if (i == 2)
                    continue;
                Console.WriteLine(i);
                i += 1;
            }
            return 2;

        }
        public void jum3()
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                    goto loop1;
            }
        loop1: Console.WriteLine("end loop");
        }

    }
}
