using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1044 : Room
  {
        public Room1044()
            : base(1044, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32890, 489, 205, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32882, 483, 205, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 319, 320, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 81, 258, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 286, 260, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 483, 262, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(213, 621, 264, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 574, 109, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 150, 113, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 315, 112, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 293, 107, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32953, 272, 106, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 180, 249, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 181, 240, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 209, 250, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 211, 302, 0, 1044));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 184, 301, 0, 1044));
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

