using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    // All mobiles, players, Mob, NPC's
    public class GameMobile : GameEntity
    {
        public bool IsMob;
        public List<GameItem> Inventory;


    }
}
