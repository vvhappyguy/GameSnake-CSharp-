using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Figure
    {
        protected List<point> plist;

        public void Draw()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in plist)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsHit(point point)
        {
            foreach(var p in plist)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
