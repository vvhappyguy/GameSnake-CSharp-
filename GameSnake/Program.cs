﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.WriteLine(sym1);
            Console.ReadLine();
        }
    }
}
