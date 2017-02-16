using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7304 : Room
  {
        public Room7304()
            : base(7304, "Drune Chapel")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 310, 161, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 286, 96, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 438, 63, 65440, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 30, 174, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 605, 7, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 477, 6, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 371, 62, 65440, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 124, 2, 65443, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 54, 1, 65437, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 353, 1, 65441, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 1, 162, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 61, 329, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 111, 105, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2791, 336, 79, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 334, 89, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 301, 2, 65440, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 14, 152, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 142, 106, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 365, 3, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 481, 174, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 372, 174, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 454, 51, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 93, 64, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(35478, 366, 34, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 454, 131, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 91, 100, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 530, 163, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 166, 102, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 438, 9, 65464, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 371, 7, 65464, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 387, 130, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 387, 51, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(46, 522, 153, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(32814, 366, 158, 0, 7304));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 323, 183, 0, 7304));
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

