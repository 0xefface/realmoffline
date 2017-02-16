using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6908 : Room
  {
        public Room6908()
            : base(6908, "The Fashion Statement Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 93, 113, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 468, 343, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 208, 223, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 56, 238, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 49, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 1, 239, 45, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 469, 344, 63, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2136, 150, 224, 45, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 207, 123, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 407, 123, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 227, 105, 65516, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 427, 105, 65516, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 324, 84, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 205, 0, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 331, 205, 64, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 330, 206, 2, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 330, 206, 33, 6908));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 609, 117, 0, 6908));
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

