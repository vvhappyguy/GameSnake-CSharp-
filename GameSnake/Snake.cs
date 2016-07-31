using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Snake : Figure   
    {
        Direction direction;

        public Snake(point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            plist = new List<point>();
            for(int i = 0; i < lenght; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }

        internal void Move()
        {
            point tail = plist.First();
            plist.Remove(tail);
            point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }

        public point GetNextPoint()
        {
            point head = plist.Last();
            point nextPoint = new point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey( ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
    }
}
