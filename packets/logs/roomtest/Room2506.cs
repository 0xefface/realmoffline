using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2506 : Room
  {
        public Room2506()
            : base(2506, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 83, 119, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 545, 133, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 331, 138, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 426, 141, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 175, 141, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 571, 148, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 247, 140, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 132, 136, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 30, 138, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 503, 144, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 42, 132, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 450, 239, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 142, 253, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 258, 309, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 560, 220, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 271, 310, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 0, 318, 0, 2506));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 142, 254, 0, 2506));
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

