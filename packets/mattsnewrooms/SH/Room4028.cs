using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4028 : Room
  {
        public Room4028()
            : base(4028, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 581, 102, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 177, 111, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 248, 224, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 78, 276, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 55, 280, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 225, 223, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 270, 227, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 552, 139, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 213, 102, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 458, 138, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 138, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 506, 138, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 410, 129, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 431, 129, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 522, 127, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 546, 127, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 128, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 126, 0, 4028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 609, 126, 0, 4028));
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

