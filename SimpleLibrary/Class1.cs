﻿using System;

namespace SimpleLibrary
{
    public class Class1
    {
        public void Method1(params int[] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
