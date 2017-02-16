using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7023 : Room
  {
        public Room7023()
            : base(7023, "Stillwater Pub")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 65491, 98, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 375, 32, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 378, 45, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 381, 201, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 473, 10, 65521, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 314, 51, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 468, 121, 70, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 448, 159, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 78, 27, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 180, 37, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 247, 42, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 198, 56, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 150, 42, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 196, 168, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 132, 168, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 259, 169, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2700, 151, 73, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 272, 36, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 138, 199, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 531, 184, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 369, 196, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 546, 25, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 504, 196, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 239, 196, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 164, 197, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 393, 195, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 65518, 26, 65489, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32793, 578, 24, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(32950, 606, 47, 0, 7023));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 662, 29, 0, 7023));
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

