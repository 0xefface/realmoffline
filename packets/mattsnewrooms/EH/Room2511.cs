using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2511 : Room
  {
        public Room2511()
            : base(2511, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 319, 138, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 327, 140, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 388, 146, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 354, 248, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(35720, 573, 259, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 575, 260, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 153, 254, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 100, 182, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 143, 238, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 105, 185, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(121, 683, 323, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 74, 131, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 171, 139, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 205, 138, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 220, 138, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 254, 136, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 300, 140, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 321, 139, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 390, 145, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 454, 138, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 478, 138, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 510, 144, 0, 2511));
          this.AddRoomDecoration(RoomDecoration.FromCode(6, 533, 144, 0, 2511));
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

