using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueAdventures.MapGen
{
    class Rectangle
    {
        //Rectangle Walls
        public char verticalWall = (char)124;
        public char horizontalWall = (char)95;
        public char topLeftCorner = (char)95;
        public char topRightCorner = (char)95;
        public char bottomLeftCorner = (char)124;
        public char bottomRightCorner = (char)124;

        int left;
        int right;
        int top;
        int bottom;

        public Rectangle(int left, int right, int top, int bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }

        //Drawing rectangle
        public void DrawingRectangle(MapGenerator myMap)
        {
            for(int x = left + 1; x < right; x++)
            {
                myMap.Draw(x, top, horizontalWall);
                myMap.Draw(x, bottom, horizontalWall);
            }

            for(int y = top + 1; y < bottom; y++)
            {
                myMap.Draw(left, y, verticalWall);
                myMap.Draw(right, y, verticalWall);
            }

            myMap.Draw(left, top, topLeftCorner);
            myMap.Draw(right, top, topRightCorner);
            myMap.Draw(left, bottom, bottomLeftCorner);
            myMap.Draw(right, bottom, bottomRightCorner);
        }
    }
}
