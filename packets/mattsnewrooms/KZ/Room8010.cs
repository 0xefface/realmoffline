using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8010 : Room
  {
        public Room8010()
            : base(8010, "Blood Forge Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 180, 33, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 280, 23, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 381, 17, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 65472, 239, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 79, 39, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 33, 60, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 122, 281, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 491, 26, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 449, 183, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(34887, 446, 184, 33, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 453, 184, 2, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2139, 53, 282, 45, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2117, 267, 91, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 618, 22, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 515, 16, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 177, 206, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 361, 70, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 535, 70, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 608, 200, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(34906, 600, 201, 55, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 179, 126, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 451, 106, 0, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 158, 128, 5, 8010));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 430, 109, 5, 8010));
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

