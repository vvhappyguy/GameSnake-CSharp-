﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls( int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upline = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, mapWidth-2, '+');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(rightline);
            wallList.Add(leftline);
        }

        internal bool IsHit( Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
