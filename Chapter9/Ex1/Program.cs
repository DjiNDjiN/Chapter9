﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string name;
            name = InputName();
            Console.WriteLine("Hello, {0}!", name);
        }

        private static string InputName()
        {
            string name;
            Console.Write("Input your name ");
            name = Console.ReadLine();
            return name;
        }

    }
}
