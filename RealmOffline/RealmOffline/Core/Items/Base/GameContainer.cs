using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public class GameContainer : GameWearable
    {
        public List<GameItem> Items;

        public GameContainer()
        {
            Items = new List<GameItem>();
        }


    }
}
