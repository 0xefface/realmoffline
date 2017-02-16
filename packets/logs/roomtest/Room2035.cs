using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2035 : Room
  {
        public Room2035()
            : base(2035, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 102, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 409, 104, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 516, 123, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 177, 111, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 637, 317, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 281, 218, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 78, 276, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 55, 277, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 269, 225, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 279, 227, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 98, 228, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 303, 228, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 415, 225, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 479, 214, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 438, 218, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 468, 211, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 557, 203, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 519, 111, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 101, 108, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(240, 156, 31, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 275, 230, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 124, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 126, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 442, 125, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 466, 124, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 490, 124, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 514, 124, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 123, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 123, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 581, 124, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 90, 237, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 281, 239, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 395, 240, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 414, 237, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 440, 232, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 463, 225, 0, 2035));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 570, 215, 0, 2035));
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

