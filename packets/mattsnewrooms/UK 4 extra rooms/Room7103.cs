using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7103 : Room
  {
        public Room7103()
            : base(7103, "Close Shave")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.UpRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(2508, 123, 77, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 274, 95, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 337, 96, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2514, 424, 82, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 508, 59, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 196, 260, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6015, 43, 239, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 310, 290, 65397, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2623, 351, 105, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 382, 101, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 37, 76, 65397, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 610, 166, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6165, 0, 188, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 249, 106, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 613, 217, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(38783, 205, 258, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2623, 471, 86, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 373, 109, 22, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6156, 11, 229, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6018, 555, 216, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6014, 584, 190, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6151, 583, 220, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6160, 614, 181, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6160, 635, 180, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 13, 247, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(38912, 496, 89, 21, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(38922, 478, 220, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 231, 285, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(6154, 591, 222, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2728, 101, 147, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 382, 216, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 118, 197, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 399, 189, 0, 7103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 118, 203, 0, 7103));
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

