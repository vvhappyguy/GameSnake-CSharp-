using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(18, 5);
            Console.WriteLine("==============================================");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("Press Any Key to Start!!!");
            Console.ResetColor();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(18, 5);
                    Console.WriteLine("                                                        ");
                    Console.SetCursorPosition(25, 7);
                    Console.WriteLine("                                        ");
                    break;
                }
            }

            Walls walls = new Walls(80, 25);
            walls.Draw();

            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(18, 5);
                    Console.WriteLine("=======================================");
                    Console.SetCursorPosition(30, 7);
                    Console.WriteLine("Game Over!!!");
                    Console.SetCursorPosition(18, 10);
                    Console.WriteLine("=======================================");
                    Console.SetCursorPosition(28, 12);
                    Console.WriteLine("Game by Ivan Dyakin");
                    Console.SetCursorPosition(18, 15);
                    Console.WriteLine("=======================================");
                    Console.SetCursorPosition(25, 17);
                    Console.WriteLine("Press Enter to Close Window!");
                    break;
                    Console.ReadLine();
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                } else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);                    
                }
            }

            Console.ReadLine();
        }
    }
}
