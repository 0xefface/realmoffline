using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2044 : Room
  {
        public Room2044()
            : base(2044, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 418, 103, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 470, 102, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 213, 102, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 334, 103, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 555, 107, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 19, 119, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 5, 321, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 500, 209, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 291, 156, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 12, 335, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 292, 159, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 487, 225, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 507, 208, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 70, 332, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 284, 227, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(33000, 330, 171, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 186, 103, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 246, 118, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 318, 178, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 303, 234, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(235, 399, 103, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 348, 141, 0, 2044));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 371, 118, 0, 2044));
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

