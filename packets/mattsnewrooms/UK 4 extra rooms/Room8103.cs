using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8103 : Room
  {
        public Room8103()
            : base(8103, "Close Shave Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 82, 193, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 589, 191, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 599, 38, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 350, 20, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 158, 19, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 526, 39, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 254, 20, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 74, 46, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 116, 89, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 11, 107, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 65534, 59, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 343, 460, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 185, 422, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 511, 425, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 38, 194, 17, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 391, 283, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 637, 192, 65521, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 605, 104, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 452, 172, 0, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2047, 27, 140, 65516, 8103));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 43, 132, 0, 8103));
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

