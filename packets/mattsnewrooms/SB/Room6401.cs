using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6401 : Room
  {
        public Room6401()
            : base(6401, "Perfect Crime Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 373, 162, 65533, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 295, 173, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 593, 35, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 496, 36, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 400, 27, 65526, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 126, 9, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 313, 37, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 222, 10, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 37, 36, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2147, 65502, 409, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(34915, 625, 402, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 190, 141, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(34917, 349, 173, 65521, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2149, 65498, 357, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 65504, 326, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 425, 169, 15, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2106, 528, 339, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(34916, 349, 173, 13, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2153, 66, 257, 40, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 80, 252, 0, 6401));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 241, 144, 15, 6401));
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

