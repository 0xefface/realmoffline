using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room3029 : Room
  {
        public Room3029()
            : base(3029, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 311, 123, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 453, 139, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 570, 132, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 200, 156, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 319, 135, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 613, 132, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 380, 133, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 264, 130, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 83, 129, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 325, 247, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 34, 256, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 536, 234, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 582, 295, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 215, 222, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 456, 228, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 385, 258, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 500, 232, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 477, 220, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 426, 318, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 103, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 232, 239, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 413, 275, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 22, 280, 19, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 118, 116, 10, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 155, 116, 10, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 287, 134, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 360, 132, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 309, 134, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 62, 129, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 85, 129, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 109, 129, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 7, 125, 0, 3029));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 272, 129, 0, 3029));
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

