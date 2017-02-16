using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7006 : Room
  {
        public Room7006()
            : base(7006, "Spiked Glove Armory")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 160, 12, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 65499, 186, 20, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 14, 226, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 478, 35, 65436, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 559, 284, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 64, 213, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 4, 231, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 477, 148, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2695, 179, 117, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 214, 37, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 315, 46, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 419, 39, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 251, 65, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 362, 64, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 312, 70, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 320, 166, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 8, 238, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 51, 233, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 20, 247, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 566, 289, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 472, 14, 65396, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2546, 321, 167, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2544, 396, 160, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2541, 386, 153, 65516, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(49, 265, 216, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 272, 220, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 292, 209, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 250, 210, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 125, 170, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 335, 170, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 342, 10, 65466, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 608, 90, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 552, 31, 65476, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 552, 16, 65476, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 48, 199, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 77, 280, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 59, 237, 0, 7006));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 6, 275, 0, 7006));
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

