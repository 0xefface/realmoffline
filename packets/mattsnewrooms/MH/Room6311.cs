using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6311 : Room
  {
        public Room6311()
            : base(6311, "Bristle's Bane Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 82, 193, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 589, 191, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 599, 38, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 350, 20, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 158, 19, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 526, 39, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 254, 20, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 74, 46, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 116, 89, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 11, 107, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 65534, 59, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 343, 460, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 185, 422, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 511, 425, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 38, 194, 17, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 391, 283, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 637, 192, 65521, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 605, 104, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 452, 172, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 34, 149, 0, 6311));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 47, 123, 0, 6311));
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

