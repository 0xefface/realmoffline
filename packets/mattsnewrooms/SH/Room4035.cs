using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4035 : Room
  {
        public Room4035()
            : base(4035, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 117, 111, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 523, 113, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 637, 317, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 255, 219, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 67, 273, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 274, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 478, 235, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 309, 238, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 13, 137, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 33, 119, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 57, 120, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 124, 117, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 550, 125, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 187, 116, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 360, 125, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 25, 140, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 312, 126, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 32, 121, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 547, 214, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 352, 218, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 164, 221, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 42, 225, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 185, 222, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 295, 220, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 412, 219, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 544, 216, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 243, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 101, 224, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 317, 103, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 93, 223, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 113, 116, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 116, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 116, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 115, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 202, 116, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 223, 116, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 333, 124, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 357, 124, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 124, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 395, 124, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 543, 123, 0, 4035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 566, 124, 0, 4035));
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

