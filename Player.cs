using System;
using static System.Console;
using System.Collections.Generic;
using RogueAdventures.Items;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueAdventures.Player1
{
    class Player
    {
        public string PName { get; set; }
        public string PIcon { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }
        public List<PlayerIvnentory> PlayerInv { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor PColor { get; set; }

        public Player(string playerName, int x, int y)
        {
            PName = playerName;

            PIcon = "@";

            PColor = ConsoleColor.DarkYellow;

            PlayerInv = new List<PlayerIvnentory>();

            X = x;
            Y = y;

            Damage = Stats1.Stats.Damage;
            Defence = Stats1.Stats.Defence;
            Health = Stats1.Stats.Health;
            Gold = Stats1.Stats.Gold;
        }

        //Drawing player 
        public void DrawPlayer()
        {
            {
                ForegroundColor = PColor;
                SetCursorPosition(X, Y);
                Write(PIcon);
                ResetColor();

            }
        }
    }
}
