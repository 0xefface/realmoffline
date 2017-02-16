using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room4043 : Room
  {
        public Room4043()
            : base(4043, "South Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 460, 101, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 262, 102, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(177, 65527, 103, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32945, 65480, 103, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32933, 496, 106, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 197, 108, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(102, 637, 317, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 29, 186, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 193, 199, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 285, 198, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 75, 184, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 332, 181, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 540, 181, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 201, 185, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 341, 227, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 514, 196, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 110, 202, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 400, 198, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 62, 116, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 27, 119, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 252, 118, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 399, 118, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32922, 367, 126, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32924, 456, 129, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 354, 222, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(153, 210, 126, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(156, 176, 124, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 226, 182, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 446, 181, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(32944, 406, 101, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 16, 118, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 39, 118, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 119, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 74, 114, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 93, 114, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 158, 123, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 183, 123, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 207, 125, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 224, 125, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 221, 116, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 244, 116, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 268, 117, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 285, 117, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 375, 125, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 396, 125, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 439, 128, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 463, 128, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 482, 128, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 390, 116, 0, 4043));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 414, 116, 0, 4043));
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

