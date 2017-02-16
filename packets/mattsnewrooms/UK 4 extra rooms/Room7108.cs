using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7108 : Room
  {
        public Room7108()
            : base(7108, "Ambrosia of Usk")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 86, 43, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 133, 50, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 112, 61, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 275, 32, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 380, 65523, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6157, 309, 138, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 247, 10, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 348, 166, 80, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6163, 47, 213, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 254, 278, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 97, 149, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 160, 157, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 97, 164, 20, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 160, 172, 20, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 64, 25, 65437, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6154, 38, 214, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 438, 176, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 30, 202, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 9, 202, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 185, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(38774, 135, 260, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6006, 65432, 69, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 176, 62, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 137, 56, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(38776, 65477, 108, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(35559, 259, 264, 150, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 229, 71, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2805, 244, 268, 166, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 364, 204, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 398, 149, 65500, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(38874, 581, 226, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 577, 212, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 610, 211, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 529, 216, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(38777, 615, 202, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6008, 95, 215, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(38774, 439, 4, 0, 7108));
          this.AddRoomDecoration(RoomDecoration.FromCode(6006, 578, 26, 0, 7108));
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

