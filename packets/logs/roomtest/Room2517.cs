using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2517 : Room
  {
        public Room2517()
            : base(2517, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 542, 135, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 351, 138, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 336, 147, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 539, 145, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 125, 140, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 476, 143, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 25, 166, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 406, 138, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 45, 146, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 277, 141, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 625, 143, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 181, 143, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 364, 327, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 404, 255, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 605, 321, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 404, 245, 65522, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 15, 327, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 157, 223, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 47, 180, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 347, 100, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 134, 119, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 7, 261, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 52, 181, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 371, 263, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 400, 236, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 485, 305, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 165, 224, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 91, 298, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 74, 298, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 616, 227, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 211, 209, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 44, 174, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 133, 251, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 79, 205, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 223, 254, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 347, 255, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 546, 255, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 84, 249, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 131, 241, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 631, 302, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 641, 256, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 640, 238, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 6, 206, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65532, 223, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 240, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65530, 264, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 5, 169, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65532, 150, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 94, 138, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 117, 139, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 177, 142, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 198, 142, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 258, 141, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 282, 140, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 303, 138, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 315, 147, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 339, 147, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 430, 138, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 469, 141, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 485, 141, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 517, 144, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 541, 145, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 565, 144, 0, 2517));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 622, 142, 0, 2517));
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

