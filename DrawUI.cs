using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogueAdventures.Items;
using RogueAdventures.Player1;
using static System.Console;

namespace RogueAdventures.GameUI
{
    class DrawUI
    {
        public DrawUI()
        {

        }

        //Inventory UI
        public void InvUI(List<Weapons> weapons)
        {
            SetCursorPosition(78, 12);
            ForegroundColor = ConsoleColor.Blue;
            Write("Equipment:");
            ResetColor();

            WeaponUI(weapons);
            ArmorUI();
            PotionsUI();
        }

        //Stats UI
        public void StatsUI(Player player)
        {
            //Name
            SetCursorPosition(78, 1);
            ForegroundColor = ConsoleColor.Blue;
            Write("Name:");
            ResetColor();
            Write(player.PName);

            //Health
            SetCursorPosition(78, 2);
            ForegroundColor = ConsoleColor.Blue;
            Write("Health:");
            ResetColor();
            ForegroundColor = ConsoleColor.Red;
            Write(player.Health);

            //Damage
            SetCursorPosition(78, 3);
            ForegroundColor = ConsoleColor.Blue;
            Write("Damage:");
            ResetColor();
            Write(player.Damage);

            //Defense
            SetCursorPosition(78, 4);
            ForegroundColor = ConsoleColor.Blue;
            Write("Armor:");
            ResetColor();
            Write(player.Defence);


            //Gold
            SetCursorPosition(78, 5);
            ForegroundColor = ConsoleColor.Blue;
            Write("Gold:");
            ResetColor();
            ForegroundColor = ConsoleColor.Yellow;
            Write(player.Gold);

        }

        //Message UI
        public void MessageUI(Player player)
        {
            SetCursorPosition(1, 22);
            ForegroundColor = ConsoleColor.Blue;
            Write("Message:");
            ResetColor();
            Write(player.PName + " entered the dungeon");         
        }

        //Weapon UI
        private static void WeaponUI(List<Weapons> weapons)
        {
            SetCursorPosition(78, 13);           
            ForegroundColor = ConsoleColor.Blue;
            Write("Weapon: ");
            ResetColor();
            Write(Equipment.HandEquip.Copper_Sword);
        }

        //Armor UI
        private static void ArmorUI()
        {
            SetCursorPosition(78, 14);
            ForegroundColor = ConsoleColor.Blue;
            Write("Armor: ");
            ResetColor();
            Write(Equipment.BodyEquip.Leather_Armor);
        }

        //Potions UI
        private static void PotionsUI()
        {
            SetCursorPosition(78, 15);
            ForegroundColor = ConsoleColor.Blue;
            Write("Potion: ");
            ResetColor();
            Write(Equipment.Potions.Healing_Potion);
        }
    }
}
