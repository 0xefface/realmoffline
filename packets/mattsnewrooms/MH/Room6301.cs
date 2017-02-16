using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6301 : Room
  {
        public Room6301()
            : base(6301, "Mixers and Makers Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 83, 169, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 225, 161, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 594, 35, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 497, 36, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 400, 27, 65526, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 126, 9, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 313, 37, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 222, 10, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 33, 35, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65502, 409, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 625, 402, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 37, 170, 65522, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 278, 162, 11, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 357, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 140, 78, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 19, 98, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 57, 110, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 245, 108, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 317, 120, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 392, 131, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 275, 162, 65523, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 178, 270, 40, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 179, 269, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 421, 110, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 350, 181, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 401, 182, 65521, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 466, 224, 0, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 59, 110, 6, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 208, 108, 6, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 281, 121, 6, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 355, 131, 6, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 37, 184, 30, 6301));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 409, 189, 50, 6301));
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

