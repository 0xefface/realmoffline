using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4056 : Room
  {
        public Room4056()
            : base(4056, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(48, 86, 184, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32817, 636, 325, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32813, 612, 256, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(224, 531, 275, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(1223, 91, 190, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 450, 103, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 36, 102, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 444, 102, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65496, 102, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 0, 123, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 479, 115, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 115, 268, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 66, 179, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 79, 185, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 494, 123, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32921, 51, 126, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 133, 269, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 199, 118, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 580, 131, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 133, 270, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(111, 280, 106, 6, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 33, 125, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 57, 125, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 169, 117, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 189, 117, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 213, 117, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 232, 117, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 486, 121, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 508, 122, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 551, 129, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 321, 225, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 304, 177, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 356, 238, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 323, 182, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 304, 128, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(234, 310, 105, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 305, 108, 0, 4056));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 302, 145, 0, 4056));
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

