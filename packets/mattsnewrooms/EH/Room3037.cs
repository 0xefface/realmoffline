using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3037 : Room
  {
        public Room3037()
            : base(3037, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 559, 133, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 145, 142, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 579, 150, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 327, 140, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 265, 150, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 376, 136, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 525, 150, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32816, 45, 252, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 142, 222, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 219, 223, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 74, 219, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 512, 247, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 486, 233, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 617, 208, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 338, 124, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 232, 111, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 138, 228, 18, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 226, 224, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 622, 209, 18, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 30, 254, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 565, 112, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 132, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 131, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 124, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 154, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 142, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 152, 140, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 176, 142, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 247, 149, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 269, 149, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 283, 149, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 138, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 138, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 353, 138, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 374, 134, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 387, 134, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 427, 138, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 441, 138, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 465, 138, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 520, 149, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 544, 149, 0, 3037));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 574, 148, 0, 3037));
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

