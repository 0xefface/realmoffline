using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4036 : Room
  {
        public Room4036()
            : base(4036, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 102, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 485, 127, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 50, 121, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 408, 220, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 427, 226, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 187, 133, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 324, 136, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 145, 132, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 341, 137, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 96, 137, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 377, 144, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 52, 134, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 552, 139, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 444, 222, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 65532, 316, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 565, 186, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 418, 189, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 131, 195, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 237, 211, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 297, 195, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 561, 201, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(107, 629, 314, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 163, 104, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 261, 194, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 310, 134, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 333, 135, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 354, 136, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 375, 136, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 391, 137, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 87, 136, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 63, 132, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 111, 136, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 141, 131, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 165, 131, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 138, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 554, 138, 0, 4036));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 138, 0, 4036));
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

