using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5314 : Room
  {
        public Room5314()
            : base(5314, "The Last Call")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 128, 47, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 154, 50, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 140, 64, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 296, 32, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 608, 142, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 383, 5, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 340, 141, 80, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 227, 174, 20, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 215, 167, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 472, 163, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 160, 157, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 468, 181, 20, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 160, 172, 20, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 257, 82, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 65534, 59, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 191, 71, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 663, 203, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 233, 212, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 85, 206, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 563, 155, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 647, 133, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 189, 70, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 66, 25, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 159, 224, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 603, 226, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 555, 216, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 627, 222, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2808, 376, 123, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 363, 71, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(2797, 362, 136, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 531, 297, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 562, 264, 0, 5314));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 656, 239, 0, 5314));
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

