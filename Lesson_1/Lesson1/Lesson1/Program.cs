﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            Console.WriteLine($" Привет {name}, сегодня {DateTime.Now.ToShortDateString()}"); //DZ
            Console.ReadLine();
        }
    }
}
