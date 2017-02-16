using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13102 : Room
  {
        public Room13102()
            : base(13102, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 293, 104, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 104, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 140, 104, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 0, 104, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 424, 136, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 666, 131, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 50, 121, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 175, 239, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 226, 263, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 604, 323, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 135, 155, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 284, 161, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 567, 129, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 212, 130, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 195, 123, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 59, 156, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 332, 170, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 402, 155, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 450, 161, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 585, 178, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 627, 180, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(151, 65475, 175, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 191, 266, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 548, 178, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 102, 153, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 129, 153, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 73, 153, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 51, 154, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 33, 154, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 259, 159, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 289, 159, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 317, 158, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 303, 167, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 326, 167, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 345, 166, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 359, 166, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 365, 153, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 383, 152, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 405, 152, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 420, 158, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 448, 157, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 465, 157, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 485, 157, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 630, 173, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 610, 173, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 543, 171, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 525, 171, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 561, 171, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 577, 171, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(2, 592, 171, 0, 13102));
          this.AddRoomDecoration(RoomDecoration.FromCode(7, 10, 156, 0, 13102));
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

