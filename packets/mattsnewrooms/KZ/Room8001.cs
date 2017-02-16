using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8001 : Room
  {
        public Room8001()
            : base(8001, "Grand Gear Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 510, 7, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 296, 44, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 414, 1, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 602, 65, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 188, 2, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 82, 6, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 0, 57, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 64, 192, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 21, 103, 50, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2338, 65462, 117, 50, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2160, 232, 250, 70, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 204, 110, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 206, 141, 50, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 228, 244, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2598, 82, 343, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2600, 523, 311, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 397, 128, 0, 8001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 377, 175, 50, 8001));
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

