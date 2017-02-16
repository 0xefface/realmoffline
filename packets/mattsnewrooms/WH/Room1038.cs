using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1038 : Room
  {
        public Room1038()
            : base(1038, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 502, 226, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 543, 227, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 472, 226, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 449, 225, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 474, 228, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 576, 227, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(145, 132, 111, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 567, 218, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 308, 107, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 90, 73, 0, 1038));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 65449, 107, 0, 1038));
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

