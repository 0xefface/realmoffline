using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6207 : Room
  {
        public Room6207()
            : base(6207, "The Emperor's Clothes Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 93, 113, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 468, 343, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 212, 220, 65534, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 56, 238, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 1, 239, 45, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 471, 344, 63, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 150, 224, 45, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 207, 123, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 407, 123, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 227, 105, 65516, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 427, 105, 65516, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 324, 84, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 205, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 331, 205, 64, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 337, 207, 2, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 330, 206, 33, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 609, 117, 65534, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 228, 138, 0, 6207));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 427, 139, 0, 6207));
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

