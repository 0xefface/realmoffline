using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6414 : Room
  {
        public Room6414()
            : base(6414, "Sorcerer's Cauldron Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 435, 242, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 147, 42, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 13, 176, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 435, 243, 30, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 262, 252, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 307, 68, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 408, 227, 150, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 501, 238, 150, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 646, 83, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 544, 78, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 50, 42, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 16, 60, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 232, 69, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 567, 312, 0, 6414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 24, 181, 20, 6414));
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

