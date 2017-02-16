using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5901 : Room
  {
        public Room5901()
            : base(5901, "Knew You")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 341, 42, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 416, 84, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 517, 73, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 390, 15, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 164, 145, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 656, 75, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 434, 201, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 217, 153, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 491, 213, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 583, 205, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 392, 168, 65521, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 60, 257, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 495, 107, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 638, 256, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 395, 92, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2595, 594, 209, 17, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 15, 240, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 408, 187, 18, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 638, 265, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 411, 97, 18, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2596, 511, 112, 18, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 423, 236, 96, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 635, 247, 48, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2728, 429, 203, 65442, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 636, 274, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 614, 243, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 402, 211, 47, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 591, 277, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(32828, 544, 281, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2728, 147, 152, 65440, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 637, 245, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1520, 584, 278, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 602, 52, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1536, 140, 135, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34304, 11, 330, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1537, 168, 115, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1520, 557, 289, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 302, 225, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 637, 286, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 638, 238, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 19, 236, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 128, 264, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1587, 631, 272, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(34355, 549, 267, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1597, 305, 209, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 310, 217, 0, 5901));
          this.AddRoomDecoration(RoomDecoration.FromCode(1597, 335, 221, 0, 5901));
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

