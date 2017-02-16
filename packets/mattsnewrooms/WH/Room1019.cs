using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1019 : Room
  {
        public Room1019()
            : base(1019, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(174, 65514, 104, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 85, 111, 65526, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 264, 145, 50, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 260, 220, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32871, 37, 316, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32830, 342, 154, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 476, 323, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 85, 117, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 320, 152, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 367, 152, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 223, 109, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(113, 225, 106, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32881, 414, 274, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(245, 551, 43, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(32941, 460, 103, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 428, 76, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 560, 166, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 417, 285, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 265, 121, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 296, 281, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 610, 170, 0, 1019));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 244, 164, 0, 1019));
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

