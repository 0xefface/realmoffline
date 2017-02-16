using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13007 : Room
  {
        public Room13007()
            : base(13007, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 692, 113, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 529, 108, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 430, 122, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 61, 123, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 621, 129, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 340, 246, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 494, 238, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32970, 616, 332, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(230, 549, 253, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 354, 259, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 318, 261, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 362, 258, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 411, 313, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 175, 132, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 65530, 323, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 301, 248, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 661, 157, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 107, 110, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 87, 61, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(32994, 345, 262, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 502, 239, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 308, 259, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 136, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 148, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 160, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 172, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 184, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 195, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 207, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 218, 130, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 633, 151, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 615, 151, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 602, 151, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 290, 111, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 254, 224, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 279, 177, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 284, 156, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 285, 132, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 284, 113, 0, 13007));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 260, 236, 0, 13007));
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

