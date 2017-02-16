using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2041 : Room
  {
        public Room2041()
            : base(2041, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 314, 103, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65532, 104, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 65496, 102, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 1, 118, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 255, 230, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 191, 181, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 259, 218, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 441, 157, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 361, 173, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 256, 207, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 492, 194, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 491, 193, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 235, 7, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 165, 103, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 307, 11, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 547, 123, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 63, 179, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 294, 190, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 555, 155, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 592, 157, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 121, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 560, 120, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 122, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 601, 121, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 177, 188, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 65, 188, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 271, 186, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 357, 182, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 416, 166, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 558, 162, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 593, 164, 0, 2041));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 386, 175, 0, 2041));
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

