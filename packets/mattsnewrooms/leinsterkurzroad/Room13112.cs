using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13112 : Room
  {
        public Room13112()
            : base(13112, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 353, 103, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 231, 127, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 407, 228, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 372, 252, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 306, 228, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 317, 251, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 462, 49, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 355, 125, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 0, 144, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 480, 111, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 486, 108, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 53, 141, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 5, 156, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 94, 137, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 106, 133, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 107, 126, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 101, 122, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 97, 100, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 91, 104, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 72, 131, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 49, 131, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 27, 132, 0, 13112));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 132, 0, 13112));
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

