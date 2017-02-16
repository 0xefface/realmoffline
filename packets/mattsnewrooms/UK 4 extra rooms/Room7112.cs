using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7112 : Room
  {
        public Room7112()
            : base(7112, "Mabon's Magic")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 367, 44, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 454, 71, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 465, 58, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 280, 20, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 176, 42, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2515, 569, 38, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 164, 60, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 156, 44, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 381, 162, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 522, 203, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 236, 184, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 253, 157, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 539, 176, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 382, 156, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38808, 303, 207, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 99, 65, 11, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 225, 55, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 506, 79, 20, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2627, 381, 73, 18, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6145, 442, 76, 28, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2629, 450, 74, 8, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 328, 82, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 578, 214, 99, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 580, 237, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38808, 348, 205, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 211, 206, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6151, 625, 220, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38919, 669, 168, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6151, 667, 128, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38919, 668, 83, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 389, 212, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 305, 199, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 130, 18, 65371, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6033, 312, 202, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6033, 294, 205, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38801, 335, 205, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 180, 205, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6005, 563, 268, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2694, 141, 114, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6161, 111, 5, 65374, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38808, 263, 205, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(38808, 152, 207, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 128, 200, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(6040, 107, 199, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 160, 202, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 50, 41, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 0, 25, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(32949, 98, 3, 0, 7112));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 245, 235, 0, 7112));
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

