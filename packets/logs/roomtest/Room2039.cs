using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2039 : Room
  {
        public Room2039()
            : base(2039, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 33, 111, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 372, 216, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 188, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 376, 221, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 162, 190, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32943, 384, 104, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 252, 195, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 79, 208, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 346, 172, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 626, 152, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(242, 4, 22, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 297, 104, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 550, 125, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 487, 170, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 193, 208, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 544, 166, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 505, 122, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 527, 122, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 122, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 124, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 598, 124, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 712, 180, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 75, 218, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 227, 202, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 272, 192, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 320, 183, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 454, 178, 0, 2039));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 593, 177, 0, 2039));
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

