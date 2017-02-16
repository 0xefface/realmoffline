using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8302 : Room
  {
        public Room8302()
            : base(8302, "Curses N Cures Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 261, 385, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 333, 160, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 126, 305, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2020, 170, 28, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 243, 6, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 346, 50, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 421, 8, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2008, 484, 40, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65529, 379, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(34904, 702, 378, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 21, 175, 20, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 336, 161, 20, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2110, 56, 168, 0, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(34901, 45, 171, 20, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(34901, 67, 198, 50, 8302));
          this.AddRoomDecoration(RoomDecoration.FromCode(2133, 88, 194, 50, 8302));
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

