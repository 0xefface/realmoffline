using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4050 : Room
  {
        public Room4050()
            : base(4050, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 94, 102, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 516, 118, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 177, 111, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 264, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 262, 221, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 282, 226, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 68, 262, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 430, 113, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 123, 119, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 503, 128, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 39, 115, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 431, 129, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 141, 120, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 259, 224, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 400, 128, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 225, 101, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 122, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 137, 121, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 161, 120, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 176, 120, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 115, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 117, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 397, 128, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 421, 130, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 130, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 129, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 489, 128, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 510, 129, 0, 4050));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 530, 126, 0, 4050));
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

