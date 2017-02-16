using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1018 : Room
  {
        public Room1018()
            : base(1018, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Left;
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 98, 350, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 118, 153, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 496, 162, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 419, 316, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 444, 316, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 357, 317, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 322, 331, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 506, 316, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 121, 151, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 533, 161, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 547, 161, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 226, 109, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 68, 151, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(140, 575, 106, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 455, 26, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 169, 361, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 117, 326, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 99, 149, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 195, 116, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 188, 119, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 95, 144, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 75, 145, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 97, 156, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(66, 78, 150, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 21, 319, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65444, 140, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(32834, 54, 119, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65472, 181, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 65464, 265, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 52, 256, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 18, 175, 0, 1018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 14, 364, 0, 1018));
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

