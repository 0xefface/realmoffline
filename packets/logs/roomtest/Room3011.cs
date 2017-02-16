using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3011 : Room
  {
        public Room3011()
            : base(3011, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 288, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 452, 132, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 206, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 370, 130, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 147, 130, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 518, 133, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 86, 128, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 327, 131, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 390, 250, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 495, 108, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 456, 326, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 223, 261, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 25, 208, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 539, 231, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 571, 269, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 168, 328, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 582, 141, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 129, 320, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 356, 244, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 520, 99, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 451, 78, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 457, 143, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 546, 143, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 256, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 302, 130, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 411, 123, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 399, 185, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 249, 183, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 72, 176, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 43, 193, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 161, 202, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 50, 177, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 177, 182, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 254, 203, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 267, 183, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 343, 203, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 418, 186, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 596, 193, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 555, 189, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 68, 127, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 90, 127, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 154, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 252, 128, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 276, 128, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 299, 128, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 325, 128, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 384, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 407, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 428, 129, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 143, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 545, 143, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 144, 0, 3011));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 419, 144, 0, 3011));
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

