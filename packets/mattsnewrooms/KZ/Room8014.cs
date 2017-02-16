using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8014 : Room
  {
        public Room8014()
            : base(8014, "The Traveller's Union Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 48, 178, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 587, 194, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 590, 36, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 492, 36, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 398, 36, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 125, 9, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 311, 46, 10, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 221, 9, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 39, 36, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 216, 228, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65488, 385, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 724, 369, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 65496, 423, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 394, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 148, 68, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 509, 99, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 18, 90, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65530, 179, 15, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 184, 229, 55, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2148, 65535, 179, 65523, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 639, 195, 65521, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 256, 229, 40, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 637, 195, 15, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 263, 150, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 434, 178, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 375, 153, 0, 8014));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 204, 125, 0, 8014));
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

