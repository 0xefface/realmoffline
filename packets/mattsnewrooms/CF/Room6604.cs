using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6604 : Room
  {
        public Room6604()
            : base(6604, "Clip N Crop Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 103, 184, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 350, 20, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 521, 40, 30, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 158, 19, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 254, 20, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 69, 47, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 155, 96, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 35, 117, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 65534, 59, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 343, 460, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 218, 406, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 351, 408, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2554, 527, 105, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 365, 280, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 77, 122, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 593, 188, 15, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 331, 114, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 426, 21, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 413, 167, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 65, 117, 65516, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 320, 109, 65516, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 475, 95, 65516, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2048, 474, 132, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 315, 142, 0, 6604));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 61, 150, 0, 6604));
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

