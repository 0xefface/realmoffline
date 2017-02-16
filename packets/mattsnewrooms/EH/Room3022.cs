using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3022 : Room
  {
        public Room3022()
            : base(3022, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 65493, 124, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 559, 126, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 223, 131, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 466, 136, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 618, 135, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 138, 134, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 577, 141, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 271, 133, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 423, 124, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 224, 135, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 495, 127, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 543, 136, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 297, 256, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 14, 256, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 81, 269, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 280, 267, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 363, 105, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 435, 117, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 348, 137, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 355, 239, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 444, 263, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 269, 261, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 608, 209, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 462, 268, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 106, 257, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 29, 218, 23, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 608, 210, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 337, 138, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 359, 129, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 381, 172, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 357, 228, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 365, 170, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 54, 134, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 134, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 194, 135, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 215, 135, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 238, 135, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 489, 136, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 525, 136, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 136, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 562, 137, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 137, 0, 3022));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 626, 133, 0, 3022));
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

