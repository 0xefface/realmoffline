using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2527 : Room
  {
        public Room2527()
            : base(2527, "The Zoo")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 308, 139, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 393, 144, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 244, 144, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 354, 248, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 152, 230, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 95, 183, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 144, 229, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 28, 255, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 105, 185, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 482, 242, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 130, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 125, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 76, 130, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 168, 138, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 250, 143, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 142, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 405, 143, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 423, 140, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 536, 144, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 571, 148, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 584, 148, 0, 2527));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 623, 143, 0, 2527));
          this.AllowCasting = False;
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

