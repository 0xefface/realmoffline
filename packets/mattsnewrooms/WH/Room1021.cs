using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1021 : Room
  {
        public Room1021()
            : base(1021, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 1, 111, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 381, 117, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(203, 404, 117, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 425, 118, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32972, 365, 118, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 395, 121, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32877, 250, 316, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 324, 328, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 244, 312, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 168, 320, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 299, 304, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 197, 316, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 351, 116, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 42, 321, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 596, 299, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 626, 286, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 566, 259, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 545, 272, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 479, 261, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 721, 105, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 602, 78, 0, 1021));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 522, 106, 0, 1021));
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

