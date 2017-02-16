using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6404 : Room
  {
        public Room6404()
            : base(6404, "Luscious Locks Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 350, 4, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 461, 28, 30, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 159, 5, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 519, 49, 30, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 254, 4, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 70, 33, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 152, 82, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 25, 104, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 0, 45, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 343, 460, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 282, 463, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 228, 499, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 280, 451, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 228, 419, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 594, 179, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 74, 180, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 26, 181, 65524, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 505, 160, 47, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 477, 63, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 68, 92, 65506, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 328, 76, 65506, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 70, 117, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 329, 100, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 457, 159, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 27, 181, 18, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 273, 247, 0, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2124, 272, 248, 35, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 279, 248, 4, 6404));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 405, 8, 0, 6404));
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

