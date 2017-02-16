using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3041 : Room
  {
        public Room3041()
            : base(3041, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 134, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 370, 134, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 204, 141, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 363, 139, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 146, 129, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 517, 139, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 78, 133, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 506, 235, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 39, 219, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 495, 108, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 555, 289, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 29, 218, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 329, 248, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 192, 216, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 539, 231, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 518, 304, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 314, 266, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 597, 207, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 420, 237, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 504, 224, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 520, 99, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 451, 78, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 513, 143, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 575, 139, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 113, 140, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 273, 136, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 319, 135, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 194, 217, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(229, 65495, 249, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 327, 169, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 571, 171, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 574, 295, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 600, 228, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 131, 296, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 354, 188, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 449, 171, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 599, 187, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 366, 202, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 466, 198, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 541, 197, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 347, 249, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 112, 250, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 272, 184, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 449, 169, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 197, 217, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 61, 133, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 84, 132, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 139, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 130, 139, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 107, 132, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 132, 129, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 156, 129, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 8, 126, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 264, 136, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 287, 136, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 311, 136, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 349, 138, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 373, 138, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 138, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 447, 138, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 137, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 529, 143, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 143, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 143, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 144, 0, 3041));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 140, 0, 3041));
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

