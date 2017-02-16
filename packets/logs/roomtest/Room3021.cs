using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3021 : Room
  {
        public Room3021()
            : base(3021, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 491, 139, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 240, 136, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 497, 139, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 615, 144, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 143, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 207, 139, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 303, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 388, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 448, 136, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 74, 131, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 32, 204, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 248, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 610, 321, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 274, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 151, 248, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(50, 104, 182, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 137, 244, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 427, 223, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 105, 185, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 585, 255, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 54, 234, 23, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 99, 192, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 349, 255, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 177, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 200, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 274, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 297, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 223, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 320, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 141, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 398, 141, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 140, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 485, 141, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 509, 139, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 533, 141, 0, 3021));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 445, 140, 0, 3021));
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

