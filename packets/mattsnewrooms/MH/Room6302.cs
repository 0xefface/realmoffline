using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6302 : Room
  {
        public Room6302()
            : base(6302, "Clothes and More Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 108, 102, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2116, 390, 123, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 247, 143, 50, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 331, 204, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 135, 204, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 405, 128, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 209, 127, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 75, 205, 45, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 517, 343, 65, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 326, 293, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 514, 342, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 152, 342, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 152, 343, 65, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 324, 205, 64, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 227, 110, 65516, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 436, 112, 65516, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 317, 50, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 222, 9, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 230, 144, 0, 6302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 427, 144, 0, 6302));
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

