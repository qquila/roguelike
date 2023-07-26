using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueAdventures.Items
{
    class PlayerIvnentory
    {
        public Item Details { get; set; }
        public int Amount { get; set; }

        public PlayerIvnentory(Item details, int amount)
        {
            Details = details;
            Amount = amount;
        }
    }
}
