using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13000 : Room
  {
        public Room13000()
            : base(13000, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 307, 107, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 598, 161, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32992, 366, 151, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 7, 254, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(33009, 163, 61, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 526, 116, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 2, 317, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 15, 172, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32918, 705, 130, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 506, 157, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 548, 159, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 336, 146, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 389, 147, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 590, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 25, 199, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 261, 190, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 74, 143, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32925, 35, 204, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 218, 140, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 255, 191, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 419, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 407, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 395, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 383, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 371, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 300, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 311, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 323, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 335, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 347, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 359, 145, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 562, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 515, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 527, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 539, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 550, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 574, 158, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 586, 155, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 598, 155, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 609, 155, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 453, 152, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 469, 152, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 486, 152, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 502, 152, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 200, 138, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 216, 138, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 242, 138, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 115, 141, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 103, 141, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 93, 140, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 84, 141, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 74, 141, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 78, 199, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 62, 199, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 45, 199, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 67, 153, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(227, 77, 148, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32996, 154, 161, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 198, 188, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 211, 227, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 126, 166, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 135, 174, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 184, 194, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 212, 201, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 209, 191, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 168, 255, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 287, 249, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32991, 156, 236, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 235, 229, 0, 13000));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 213, 194, 0, 13000));
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

