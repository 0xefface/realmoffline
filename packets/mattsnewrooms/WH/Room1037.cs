using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1037 : Room
  {
        public Room1037()
            : base(1037, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 116, 219, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 554, 158, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 113, 213, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 400, 318, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 448, 331, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 124, 223, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 318, 333, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(243, 103, 45, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 195, 103, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 600, 107, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 504, 106, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 541, 105, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 292, 174, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 381, 102, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 349, 116, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 245, 235, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 281, 231, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 326, 131, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 305, 137, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 286, 157, 0, 1037));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 266, 196, 0, 1037));
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

