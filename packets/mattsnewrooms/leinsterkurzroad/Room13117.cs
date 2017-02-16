using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room13117 : Room
  {
        public Room13117()
            : base(13117, "Leinster/Kurz Road")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PatchyGrassyBlueSky0;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 277, 104, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 468, 103, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 373, 104, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 22, 104, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 236, 123, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 593, 127, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 100, 119, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 18, 322, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 604, 206, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 464, 225, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(33012, 25, 67, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 454, 107, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(222, 587, 212, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 474, 127, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 498, 129, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 521, 130, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 545, 130, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 569, 129, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 627, 129, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 116, 124, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 140, 124, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 124, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 123, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 123, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 124, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 257, 123, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 280, 122, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 303, 123, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 326, 123, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 350, 121, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 95, 120, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 120, 0, 13117));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 48, 120, 0, 13117));
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

