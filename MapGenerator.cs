using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueAdventures.MapGen
{
    class MapGenerator
    {
        public int ScreenWidth { get; private set; }
        public int ScreenHeight { get; private set; }

        private char[,] Mbuffer;

        Rectangle Room = new Rectangle(0, 76, 0, 20);
        Rectangle PartOfRoom1 = new Rectangle(60, 45, 15, 20);
        Rectangle PartOfRoom2 = new Rectangle(25, 10, 0, 10);
        Rectangle StatsRect = new Rectangle(77, 110, 0, 10);
        Rectangle EquipRect = new Rectangle(77, 115, 11, 20);
        Rectangle MessageRect = new Rectangle(0, 76, 21, 29);

        //Map creating
        public MapGenerator(int width, int height)
        {
            ScreenHeight = height;
            ScreenWidth = width;
            Mbuffer = new char[width, height];
        }

        //Generating diff consoles on screen
        public void MapGen()
        {
            FillBuffer(' ');
            Room.DrawingRectangle(this);
            PartOfRoom1.DrawingRectangle(this);
            PartOfRoom2.DrawingRectangle(this);
            StatsRect.DrawingRectangle(this);
            EquipRect.DrawingRectangle(this);
            MessageRect.DrawingRectangle(this);
        }

        //Buffer
        private void FillBuffer(char value)
        {
            for(int x = 0; x < ScreenWidth; x++)
            {
                for(int y = 0; y < ScreenHeight; y++)
                {
                    Mbuffer[x, y] = value;
                }
            }
        }

        //Updating screen 
        public void Update()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            StringBuilder u = new StringBuilder();
            for (int y = 0; y < ScreenHeight; y++)
            {
                for (int x = 0; x < ScreenWidth; x++)
                {
                    u.Append(Mbuffer[x, y]);
                }
                u.Append("\n");
            }
            Console.Write(u.ToString());
        }

        //This method checking if player can walk or there is a wall
        public bool IsWalkable(int x, int y)
        {
            if(x < 0 || y < 0)
            {
                return false;
            }
            else
            {
                return Mbuffer[x, y] == ' ';
            }
        }

        //Draw method
        public void Draw(int x, int y, char value)
        {
            if (x >= 0 && x < ScreenWidth && y >= 0 && y < ScreenHeight)
            {
                Mbuffer[x, y] = value;
            }
        }
    }
}
