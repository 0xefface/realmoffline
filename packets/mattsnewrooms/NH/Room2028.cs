using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2028 : Room
  {
        public Room2028()
            : base(2028, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 372, 103, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 184, 103, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65480, 103, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 498, 115, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 431, 318, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 452, 315, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 368, 315, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 415, 322, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 81, 207, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 411, 161, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 226, 166, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 199, 179, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 218, 172, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 192, 186, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 178, 194, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 181, 204, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 156, 132, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 347, 103, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 457, 106, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 531, 161, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 290, 160, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 641, 162, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 19, 121, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 70, 130, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 94, 130, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 131, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 225, 118, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 151, 122, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 127, 121, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 116, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 411, 116, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 572, 168, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 449, 169, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 326, 168, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 250, 167, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 239, 171, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 227, 177, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 213, 183, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 206, 190, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 196, 197, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 155, 199, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 75, 197, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 337, 140, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 344, 137, 0, 2028));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 341, 114, 0, 2028));
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

