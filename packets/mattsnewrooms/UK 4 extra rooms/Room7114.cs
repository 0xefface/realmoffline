using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7114 : Room
  {
        public Room7114()
            : base(7114, "Excellent Weaponry")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 192, 90, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 238, 92, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 542, 77, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 328, 90, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 452, 88, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 629, 267, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(38916, 208, 69, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6148, 339, 70, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(38916, 458, 70, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6148, 551, 70, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 216, 92, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 238, 92, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 552, 94, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 368, 92, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 433, 93, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 207, 195, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 147, 195, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 425, 254, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 384, 125, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6020, 618, 231, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 441, 248, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(35559, 418, 170, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2803, 413, 179, 23, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 187, 253, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6162, 571, 236, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(38774, 135, 257, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6164, 633, 316, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(38932, 532, 237, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(6163, 207, 255, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 221, 210, 29, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 160, 211, 29, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(7907, 540, 261, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 194, 127, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 195, 106, 0, 7114));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 198, 82, 0, 7114));
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

