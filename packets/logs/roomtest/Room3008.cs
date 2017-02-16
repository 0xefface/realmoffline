using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3008 : Room
  {
        public Room3008()
            : base(3008, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(3743, 573, 134, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 440, 113, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 632, 140, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 169, 135, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 575, 137, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 361, 141, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 275, 144, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 59, 129, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 448, 218, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 620, 221, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 593, 245, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 245, 226, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 39, 144, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 601, 245, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 59, 145, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 140, 178, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 208, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 214, 220, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 150, 174, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 424, 322, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 635, 238, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 415, 169, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 279, 167, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 477, 108, 19, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 185, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 380, 184, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 491, 185, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 559, 187, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 616, 184, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 153, 227, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 8, 220, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 7, 212, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 513, 103, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 556, 170, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 582, 106, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 553, 103, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 311, 144, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 515, 129, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 180, 173, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 486, 107, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(110, 536, 106, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 69, 138, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 53, 138, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 134, 133, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 134, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 182, 134, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 253, 143, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 275, 142, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 298, 143, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 317, 143, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 332, 140, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 356, 140, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 377, 140, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 559, 134, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 583, 134, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 602, 134, 0, 3008));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 624, 134, 0, 3008));
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

