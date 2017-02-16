using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8306 : Room
  {
        public Room8306()
            : base(8306, "Nosh Shop Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2122, 316, 287, 4, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34890, 333, 177, 32, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34891, 323, 177, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2141, 46, 289, 47, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34908, 579, 247, 40, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 524, 246, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 328, 176, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 593, 117, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 315, 286, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 574, 15, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 607, 33, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 38, 40, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 199, 15, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 111, 42, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 301, 9, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 471, 9, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 414, 19, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 167, 119, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 330, 177, 65, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 431, 178, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 579, 186, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 471, 107, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 17, 95, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 136, 76, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2162, 604, 75, 0, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 644, 118, 10, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2123, 324, 287, 30, 8306));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 112, 288, 0, 8306));
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

