using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8000 : Room
  {
        public Room8000()
            : base(8000, "Filthy Beggar Inn Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 100, 80, 65518, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 497, 39, 30, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 176, 38, 30, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 284, 50, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 593, 114, 100, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 240, 242, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 236, 52, 65497, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 236, 165, 93, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 77, 11, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 509, 87, 65528, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 524, 183, 65516, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 140, 233, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 342, 232, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 463, 309, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 148, 307, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 65522, 64, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 381, 51, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(34896, 141, 234, 64, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 240, 90, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 429, 158, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 10, 184, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 408, 142, 0, 8000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 23, 158, 0, 8000));
          this.AllowCasting = True;
          base.ApplyRoomLayout();
      }
// We do not know these values yet
      public override uint GetNextRoomByExit(RoomExit exit)
      {
          switch (exit)
          {
              case RoomExit.North: return 5043;
              case RoomExit.South: return 5043;
              case RoomExit.East: return 5043;
              case RoomExit.West: return 5043;
              default: return 5043;
           }
          }
      }
  }

