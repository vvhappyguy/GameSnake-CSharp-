using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yBot, int x, char sym)
        {
           plist = new List<point>();
           for(int y = yTop; y <= yBot; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
