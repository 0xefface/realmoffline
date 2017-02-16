using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8112 : Room
  {
        public Room8112()
            : base(8112, "Mabon's Magic Shop Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 78, 102, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 552, 172, 65506, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 68, 285, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 158, 28, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 231, 9, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 328, 50, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 429, 8, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 491, 40, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 180, 155, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2049, 393, 156, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 176, 284, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 325, 180, 65516, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 325, 90, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 558, 104, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 602, 199, 10, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 65533, 194, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 605, 203, 65521, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 330, 161, 90, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 199, 285, 65, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 323, 191, 65526, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2130, 326, 180, 15, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2131, 85, 286, 50, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 190, 405, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 448, 364, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 657, 421, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2556, 13, 166, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 220, 128, 0, 8112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 433, 129, 0, 8112));
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

