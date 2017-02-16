using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7104 : Room
  {
        public Room7104()
            : base(7104, "The Tub")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(6159, 9, 78, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 271, 72, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 207, 47, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 456, 65, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 481, 66, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 441, 67, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 204, 176, 30, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 347, 196, 49, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 347, 229, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 447, 138, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2641, 494, 130, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 408, 238, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2656, 406, 216, 65526, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2651, 410, 130, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 491, 195, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2654, 487, 100, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6150, 153, 216, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 174, 212, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2649, 426, 234, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2644, 407, 166, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 448, 235, 133, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2648, 447, 233, 58, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 425, 201, 133, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6162, 503, 238, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 447, 224, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 494, 215, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 458, 161, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6163, 435, 251, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 501, 18, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(38927, 47, 41, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 398, 175, 20, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6159, 624, 47, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 398, 225, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 485, 100, 49, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6010, 157, 196, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 538, 244, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2668, 161, 209, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 591, 71, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 342, 239, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2642, 408, 233, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 325, 80, 29, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 601, 226, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 549, 235, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2671, 162, 102, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2670, 293, 218, 60, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2673, 350, 226, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2674, 350, 129, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2676, 154, 184, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2669, 246, 213, 65520, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2663, 204, 207, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2661, 205, 155, 31, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 359, 70, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 288, 81, 19, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 311, 75, 9, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 279, 61, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 259, 82, 42, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(2699, 327, 198, 65, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 74, 54, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 151, 16, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(38774, 124, 284, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 95, 285, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 256, 218, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 274, 233, 0, 7104));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 452, 264, 0, 7104));
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

