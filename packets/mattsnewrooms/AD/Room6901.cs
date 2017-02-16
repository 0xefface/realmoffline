using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6901 : Room
  {
        public Room6901()
            : base(6901, "Knew You Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 507, 187, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 595, 45, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 350, 20, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 447, 22, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 158, 19, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 517, 46, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 254, 20, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 69, 47, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 65534, 59, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 343, 460, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 554, 188, 65523, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 605, 403, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 361, 213, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 558, 188, 45, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 424, 75, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 65454, 232, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2110, 63, 124, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 620, 107, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 252, 81, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 559, 392, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 554, 188, 15, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 334, 128, 0, 6901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 335, 128, 6, 6901));
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

