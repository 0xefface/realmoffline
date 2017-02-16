using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13008 : Room
  {
        public Room13008()
            : base(13008, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 289, 109, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1222, 570, 281, 23, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 318, 262, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 569, 267, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 45, 28, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 521, 124, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 317, 89, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 437, 144, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 435, 150, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 140, 156, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 621, 134, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(228, 284, 215, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32998, 84, 241, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 151, 238, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 114, 321, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 36, 223, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 385, 174, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 0, 339, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32919, 65515, 150, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(168, 176, 141, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 371, 174, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32995, 418, 166, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 541, 165, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 595, 168, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 104, 239, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 596, 268, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 104, 153, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 116, 153, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 127, 153, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 587, 133, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 599, 133, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 610, 133, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 621, 133, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 633, 133, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 4, 144, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 22, 144, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 382, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 399, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 417, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 435, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 453, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 471, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 487, 143, 0, 13008));
          this.AddRoomDecoration(RoomDecoration.FromCode(223, 326, 206, 0, 13008));
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

