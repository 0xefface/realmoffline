using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3000 : Room
  {
        public Room3000()
            : base(3000, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 280, 136, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 507, 132, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 128, 109, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 296, 131, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 43, 273, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 404, 214, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 190, 226, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(3952, 517, 199, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 628, 144, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 47, 287, 33, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 447, 218, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 191, 232, 9, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 598, 143, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 260, 136, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 34, 115, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 95, 129, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 144, 131, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 511, 139, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 144, 268, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 135, 278, 33, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 624, 270, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 451, 323, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 345, 146, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 459, 154, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 384, 164, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 421, 223, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 551, 252, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 607, 308, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 611, 290, 15, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 539, 82, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 369, 91, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 333, 104, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 575, 271, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(33003, 422, 242, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 45, 289, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 371, 228, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 354, 219, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 345, 211, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 43, 164, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 254, 164, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 311, 168, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 392, 243, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 145, 274, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 201, 240, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 327, 144, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 348, 144, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 361, 144, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 490, 153, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 467, 154, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 418, 152, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 433, 154, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 436, 149, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 463, 148, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 402, 164, 0, 3000));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 374, 164, 0, 3000));
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

