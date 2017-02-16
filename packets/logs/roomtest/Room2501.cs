using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2501 : Room
  {
        public Room2501()
            : base(2501, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 297, 136, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 483, 114, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 537, 133, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 507, 132, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 125, 131, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 92, 133, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 292, 131, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 136, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 354, 138, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 140, 137, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 609, 134, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 70, 137, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 468, 136, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 511, 139, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 8, 134, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 214, 137, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 264, 138, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 22, 258, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 610, 266, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 565, 284, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 148, 253, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 328, 248, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 563, 280, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 565, 285, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 18, 259, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 26, 226, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 612, 278, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 43, 248, 62, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32988, 211, 278, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 203, 231, 39, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 619, 267, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 323, 249, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 133, 254, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32879, 336, 301, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 258, 265, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 293, 279, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 122, 252, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 160, 278, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 151, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 127, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 108, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 89, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 73, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 259, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 278, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 295, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 317, 320, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65533, 244, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 264, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65532, 187, 0, 2501));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 65529, 167, 0, 2501));
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

