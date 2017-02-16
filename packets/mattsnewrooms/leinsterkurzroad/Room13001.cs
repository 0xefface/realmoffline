using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13001 : Room
  {
        public Room13001()
            : base(13001, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35510, 108, 109, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 512, 113, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 309, 106, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 480, 320, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 288, 115, 65458, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 396, 321, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(33014, 12, 20, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 658, 168, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 145, 104, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 161, 111, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(33013, 58, 28, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 27, 190, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 309, 142, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 19, 145, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 445, 136, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 625, 152, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 640, 174, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 201, 146, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 179, 148, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 81, 142, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 585, 293, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(32990, 610, 262, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 4, 188, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 16, 188, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 28, 188, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 40, 188, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 52, 188, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 124, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 113, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 102, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 93, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 81, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 69, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 57, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 251, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 263, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 275, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 287, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 299, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 311, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 323, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 335, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 347, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 359, 138, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 464, 133, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 452, 133, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 440, 133, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 429, 133, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 416, 133, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 595, 170, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 612, 170, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 630, 170, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 574, 146, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 592, 146, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 610, 146, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 628, 146, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 544, 120, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 561, 120, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 579, 120, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 597, 120, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 162, 146, 0, 13001));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 184, 146, 0, 13001));
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

