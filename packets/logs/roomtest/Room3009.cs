using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3009 : Room
  {
        public Room3009()
            : base(3009, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 77, 124, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 309, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 616, 140, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 188, 141, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 574, 137, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 117, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 265, 143, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 390, 141, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 523, 136, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 95, 127, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 28, 125, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 652, 318, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 467, 245, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 37, 213, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 43, 141, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 432, 222, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 311, 248, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 40, 208, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 154, 238, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 209, 238, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 70, 172, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 187, 174, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 318, 172, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 30, 177, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 88, 188, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 33, 192, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 532, 189, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 226, 181, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 366, 188, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 393, 189, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 173, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 439, 172, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 494, 188, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 588, 172, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 191, 174, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 97, 186, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 322, 255, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 586, 187, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 333, 103, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 456, 172, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 587, 172, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 156, 246, 29, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 429, 224, 14, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 439, 233, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 22, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 72, 140, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 135, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 135, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 191, 139, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 337, 137, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 249, 140, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 140, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 385, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 138, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 465, 137, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 487, 137, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 512, 134, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 134, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 134, 0, 3009));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 586, 137, 0, 3009));
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

