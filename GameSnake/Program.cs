using System;
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
            point p1 = new point(1, 3, '*');
            /*p1.x = 1;
            p1.y = 2;
            p1.sym = '*';*/
            p1.Draw();

            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(p1.x, p1.y, p1.sym);*/

            point p2 = new point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
