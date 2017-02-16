using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3016 : Room
  {
        public Room3016()
            : base(3016, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 186, 132, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 200, 135, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 155, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 202, 145, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 51, 144, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 130, 144, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 391, 139, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 464, 218, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 405, 216, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 454, 227, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 522, 213, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 394, 253, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 348, 107, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 283, 135, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 192, 112, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 480, 108, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 294, 126, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 590, 163, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 28, 319, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 319, 265, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 514, 222, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 385, 130, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 543, 160, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 299, 269, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 178, 125, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 252, 126, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 360, 172, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 387, 118, 33, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 345, 131, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 361, 181, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 385, 243, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 143, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 86, 143, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 110, 143, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 143, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 150, 143, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 144, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 144, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 143, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 138, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 422, 139, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 561, 161, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 161, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 161, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 572, 152, 0, 3016));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 17, 143, 0, 3016));
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

