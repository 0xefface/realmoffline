using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6909 : Room
  {
        public Room6909()
            : base(6909, "Institute of Warfare Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 44, 177, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 587, 192, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 590, 36, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 492, 36, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 398, 36, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 125, 9, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 311, 46, 10, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 220, 10, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 39, 36, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 222, 229, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65488, 385, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 724, 369, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 65496, 423, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 394, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 148, 68, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 509, 99, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 18, 90, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65528, 178, 15, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 183, 124, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 373, 154, 0, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 193, 230, 50, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 0, 178, 65523, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 639, 193, 13, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 257, 230, 40, 6909));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 637, 193, 65523, 6909));
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

