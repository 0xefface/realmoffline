using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1031 : Room
  {
        public Room1031()
            : base(1031, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32942, 317, 102, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 327, 214, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 353, 209, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 420, 194, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 87, 260, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 348, 311, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 309, 165, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 314, 172, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 354, 215, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 475, 188, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 109, 249, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 500, 161, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 481, 153, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 126, 154, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 474, 159, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 387, 303, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 434, 190, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 129, 151, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 316, 167, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 89, 255, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 537, 322, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 534, 103, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(33010, 760, 95, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(100, 0, 335, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 397, 105, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 414, 104, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 270, 238, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 239, 237, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 389, 105, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 337, 164, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 264, 195, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 305, 184, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 286, 194, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 384, 140, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 383, 121, 0, 1031));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 330, 160, 0, 1031));
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

