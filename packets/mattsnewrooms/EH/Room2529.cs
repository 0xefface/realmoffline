using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2529 : Room
  {
        public Room2529()
            : base(2529, "East Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 93, 128, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(35511, 559, 134, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(32936, 333, 138, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 458, 140, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 601, 137, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 144, 132, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 90, 140, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 142, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 361, 141, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 263, 139, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 59, 129, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 523, 245, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 595, 210, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 502, 239, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 65, 133, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(157, 37, 177, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 513, 253, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 28, 181, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 154, 180, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 22, 208, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 211, 223, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 148, 179, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 325, 247, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(47, 601, 209, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 264, 185, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 321, 181, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 380, 179, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 490, 182, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 566, 178, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 614, 176, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 260, 353, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 8, 220, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 7, 209, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(93, 334, 104, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(32953, 355, 267, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 61, 162, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 44, 164, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 138, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 101, 139, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 58, 128, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 118, 132, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 142, 131, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 171, 132, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 245, 139, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 139, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 383, 141, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 136, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 430, 140, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 453, 139, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 476, 139, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 524, 133, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 570, 136, 0, 2529));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 625, 137, 0, 2529));
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

