﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    count++;
                }
                catch 
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
