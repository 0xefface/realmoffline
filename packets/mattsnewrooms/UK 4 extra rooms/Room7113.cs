using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7113 : Room
  {
        public Room7113()
            : base(7113, "Fashion Delights")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 124, 35, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 214, 64, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 300, 62, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 442, 45, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 337, 71, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 221, 51, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 160, 40, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 201, 66, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 174, 62, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2628, 251, 74, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 362, 206, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 178, 163, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 379, 179, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 178, 157, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 102, 206, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(38922, 467, 218, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(38922, 376, 238, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6159, 65530, 3, 65400, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6067, 34, 8, 65451, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(38933, 521, 209, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6154, 173, 83, 65419, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 451, 198, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 468, 171, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2652, 472, 54, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2653, 495, 59, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6020, 387, 236, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2799, 201, 143, 45, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2807, 186, 137, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6162, 40, 205, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 45, 200, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 21, 192, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 78, 191, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(6014, 523, 205, 0, 7113));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 248, 241, 0, 7113));
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

