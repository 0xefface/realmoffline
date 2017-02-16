using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13115 : Room
  {
        public Room13115()
            : base(13115, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 294, 104, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 469, 105, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 140, 104, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 278, 142, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 130, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 170, 251, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 416, 238, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 116, 262, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 468, 229, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 141, 268, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 138, 272, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 545, 117, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 184, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 201, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 218, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 234, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 252, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 270, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 287, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 304, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 322, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 340, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 358, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 376, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 391, 141, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 548, 129, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 132, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 593, 132, 0, 13115));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 617, 132, 0, 13115));
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

