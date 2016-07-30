using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
           plist = new List<point>();
           for(int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }

    }
}
