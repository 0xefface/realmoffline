using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5208 : Room
  {
        public Room5208()
            : base(5208, "Dog's Breath Inn")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 140, 7, 65437, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 164, 3, 65437, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 626, 26, 65437, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2743, 56, 114, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 435, 7, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 272, 147, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 210, 136, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 547, 218, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 332, 218, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 391, 42, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 559, 42, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 476, 47, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 410, 70, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 489, 68, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 555, 74, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(35468, 336, 182, 20, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 518, 121, 65481, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 349, 114, 65478, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 5, 150, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 184, 124, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 629, 216, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 591, 236, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 657, 201, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 182, 209, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 337, 212, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 358, 207, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 403, 204, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 315, 217, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 65515, 52, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 604, 199, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 352, 200, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 409, 202, 0, 5208));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 156, 203, 0, 5208));
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

