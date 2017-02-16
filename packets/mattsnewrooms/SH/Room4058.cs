using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4058 : Room
  {
        public Room4058()
            : base(4058, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 144, 102, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 534, 114, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 140, 106, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 601, 232, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 550, 233, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 23, 251, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 587, 234, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 512, 235, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 452, 134, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 396, 133, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 366, 122, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 65, 120, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 384, 128, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 153, 131, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 95, 126, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 209, 119, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 116, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 221, 127, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 136, 129, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 145, 131, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 36, 119, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 56, 119, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 79, 118, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 98, 119, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 127, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 127, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 402, 126, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 434, 132, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 132, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 132, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 127, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 129, 128, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 146, 128, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 164, 128, 0, 4058));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 181, 126, 0, 4058));
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

