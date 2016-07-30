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

            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);


            Console.ReadLine();
        }
    }
}
