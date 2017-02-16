using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5903 : Room
  {
        public Room5903()
            : base(5903, "Magic and More")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 42, 34, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 134, 50, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 105, 61, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 102, 48, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 177, 59, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 275, 32, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 303, 58, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 88, 202, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 599, 289, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 201, 244, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(1522, 118, 216, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 191, 185, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 70, 164, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 157, 178, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2694, 71, 93, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(34291, 598, 319, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 55, 206, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 268, 120, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 24, 207, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 55, 209, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 37, 317, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 202, 189, 21, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 71, 165, 4, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 157, 180, 4, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 135, 208, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 5, 207, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(34288, 65530, 211, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 381, 19, 65436, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 88, 224, 0, 5903));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 144, 242, 0, 5903));
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

