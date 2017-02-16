using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7309 : Room
  {
        public Room7309()
            : base(7309, "Weaponry of Drune")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 43, 28, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 119, 54, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 212, 45, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 348, 35, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 166, 201, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2652, 375, 54, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 380, 160, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 124, 60, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 132, 62, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 251, 74, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 271, 203, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 87, 162, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 288, 176, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 87, 157, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 15, 324, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(32794, 544, 261, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 245, 219, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2708, 353, 70, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 460, 22, 65436, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 8, 198, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 88, 201, 119, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2696, 362, 200, 76, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 310, 209, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35484, 380, 197, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 395, 19, 65485, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 615, 191, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(26, 56, 264, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 432, 186, 65437, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 471, 28, 65436, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35726, 414, 302, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 143, 305, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 95, 210, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2958, 141, 208, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 186, 86, 23, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 79, 75, 23, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 363, 187, 0, 7309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 272, 76, 0, 7309));
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

