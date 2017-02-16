using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2054 : Room
  {
        public Room2054()
            : base(2054, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 84, 115, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 568, 124, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 443, 153, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 440, 149, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 130, 223, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 118, 224, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 97, 217, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 257, 272, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 585, 291, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 430, 234, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 518, 235, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 321, 104, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 53, 123, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 262, 46, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 316, 103, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 287, 154, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 123, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 122, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 122, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 83, 123, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 122, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 647, 294, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 715, 277, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 678, 299, 0, 2054));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 587, 297, 0, 2054));
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

