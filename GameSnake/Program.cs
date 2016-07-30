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
            Console.SetBufferSize(80, 25);

            HorizontalLine lineTop = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineBot = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineLeft = new VerticalLine(0, 24, 78, '+');

            lineBot.Draw();
            lineLeft.Draw();
            lineRight.Draw();
            lineTop.Draw();

            point p1 = new point(1, 3, '#');
            p1.Draw();

            Console.ReadLine();
        }
    }
}
