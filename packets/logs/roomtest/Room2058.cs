using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2058 : Room
  {
        public Room2058()
            : base(2058, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65464, 104, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 177, 111, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 610, 318, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 42, 295, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 71, 276, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 48, 276, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 81, 296, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 92, 295, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 539, 186, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 79, 115, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 77, 121, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32984, 600, 141, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 423, 112, 0, 2058));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 304, 106, 0, 2058));
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

