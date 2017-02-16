using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7102 : Room
  {
        public Room7102()
            : base(7102, "Usk")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.Up;
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 266, 220, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 168, 203, 65486, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38919, 122, 48, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 237, 194, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6164, 142, 54, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 203, 188, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6069, 18, 39, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6164, 92, 37, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 466, 167, 100, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2503, 30, 72, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38914, 81, 157, 50, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 134, 99, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 139, 51, 65386, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38914, 163, 94, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 226, 83, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 181, 102, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 225, 178, 50, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 214, 148, 50, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 489, 5, 65496, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38913, 412, 57, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38913, 349, 3, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 320, 1, 65436, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 256, 5, 65436, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 547, 56, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38913, 423, 56, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2635, 29, 126, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2624, 141, 115, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2622, 213, 105, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2626, 134, 211, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 453, 140, 65496, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 448, 151, 65496, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 43, 202, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 43, 208, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 318, 320, 200, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 291, 96, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6009, 38, 288, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38778, 26, 272, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 155, 251, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(38770, 202, 257, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 628, 4, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6069, 601, 8, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6069, 545, 4, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6069, 514, 10, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 538, 277, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(6005, 629, 135, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 392, 96, 0, 7102));
          this.AddRoomDecoration(RoomDecoration.FromCode(32782, 392, 223, 0, 7102));
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

