using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5312 : Room
  {
        public Room5312()
            : base(5312, "Broker's Best")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 296, 211, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 147, 199, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 626, 26, 65437, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 24, 72, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 453, 7, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 262, 155, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 227, 136, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 196, 130, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 156, 151, 65491, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 391, 42, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 559, 42, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 476, 47, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 414, 156, 80, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 489, 68, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 555, 74, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 415, 200, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 517, 117, 65481, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 360, 111, 65478, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 5, 150, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 33, 114, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 216, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 625, 218, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 377, 205, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 169, 205, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 411, 199, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 571, 207, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 4, 159, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 535, 203, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 88, 52, 0, 5312));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 604, 199, 0, 5312));
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

