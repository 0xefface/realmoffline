using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8113 : Room
  {
        public Room8113()
            : base(8113, "Fashion Delights Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 108, 102, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 390, 123, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 255, 145, 50, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 328, 211, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 135, 204, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 8, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 75, 205, 45, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 517, 343, 65, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 326, 295, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 514, 342, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 152, 342, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 152, 343, 65, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 332, 212, 65, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 190, 154, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 382, 151, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 230, 127, 0, 8113));
          this.AddRoomDecoration(RoomDecoration.FromCode(2555, 422, 124, 0, 8113));
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

