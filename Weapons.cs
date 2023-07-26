using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueAdventures.Items
{
    class Weapons : Item
    {
        public int Damage { get; set; }

        public Weapons(int damage, ItemType itemType, string name, float value, int number) : base(name, itemType, number, value)
        {
            Damage = damage;
            itemType = ItemType.Weapon;
        }
    }
}
