using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7111 : Room
  {
        public Room7111()
            : base(7111, "The Giant's Hammer")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 198, 12, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 225, 17, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 213, 30, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 367, 1, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 603, 125, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 375, 42, 50, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(38777, 615, 202, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6163, 47, 213, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 451, 162, 20, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 254, 278, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 245, 128, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6154, 38, 214, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 244, 143, 20, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6008, 95, 215, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6157, 396, 98, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 623, 194, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 30, 202, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 202, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 185, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 452, 146, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 565, 151, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 278, 23, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(38774, 135, 260, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 620, 143, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 529, 216, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(38776, 542, 261, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 250, 194, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 603, 181, 65500, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(38874, 581, 226, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 577, 212, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 610, 211, 0, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 158, 94, 50, 7111));
          this.AddRoomDecoration(RoomDecoration.FromCode(2792, 172, 60, 0, 7111));
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

