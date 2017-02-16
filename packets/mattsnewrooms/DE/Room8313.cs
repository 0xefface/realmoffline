using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8313 : Room
  {
        public Room8313()
            : base(8313, "Preparatory Prestidigitation Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 83, 169, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 225, 161, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 594, 35, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 497, 36, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 400, 27, 65526, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 126, 9, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 313, 37, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 222, 10, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 33, 35, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65502, 409, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 625, 402, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 37, 170, 65522, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 278, 162, 11, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 357, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 140, 78, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 19, 98, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2041, 50, 123, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 193, 115, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 336, 137, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 264, 126, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 275, 162, 65523, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 178, 270, 40, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 179, 269, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 421, 110, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 350, 181, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 401, 182, 65521, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 466, 224, 0, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 61, 124, 14, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 245, 118, 14, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 316, 129, 14, 8313));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 388, 140, 14, 8313));
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

