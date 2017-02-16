using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8021 : Room
  {
        public Room8021()
            : base(8021, "Weapons of Thunder Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 180, 33, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 382, 17, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 310, 175, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 79, 38, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 48, 303, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 463, 27, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 562, 276, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 567, 277, 2, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 570, 277, 65, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2139, 65521, 304, 45, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2043, 147, 145, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2121, 570, 277, 32, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 444, 186, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 385, 83, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 442, 69, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2163, 496, 83, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 13, 62, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 115, 108, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2161, 11, 126, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2120, 445, 191, 60, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 569, 43, 20, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 625, 45, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 28, 163, 0, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 39, 167, 20, 8021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 182, 151, 20, 8021));
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

