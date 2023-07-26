using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueAdventures.Items
{
    class Item
    {
        public enum ItemType
        {
            Weapon, Armor, Potions
        }

        public string Name { get; }
        public int Number { get; set; }
        public float Value { get; set; }
        public ItemType ItemTypes { get; set; }

        public Item(string name, ItemType itemType, int number, float value)
        {
            Name = name;
            Number = number;
            Value = value;
            ItemTypes = itemType;
        }
    }
}
