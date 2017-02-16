using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6412 : Room
  {
        public Room6412()
            : base(6412, "Magic Tomes Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 122, 169, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 284, 175, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 593, 35, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 496, 36, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 400, 27, 65526, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 126, 9, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 313, 37, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 222, 10, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 33, 35, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65502, 409, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 625, 402, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 72, 170, 15, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 334, 176, 65521, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 357, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 140, 78, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 19, 98, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 336, 176, 13, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 186, 267, 40, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 183, 266, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 421, 110, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 50, 124, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 215, 118, 0, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 320, 133, 65533, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 61, 129, 20, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 267, 122, 15, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 372, 142, 15, 6412));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 45, 220, 0, 6412));
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

