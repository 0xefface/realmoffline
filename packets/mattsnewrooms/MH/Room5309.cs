using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5309 : Room
  {
        public Room5309()
            : base(5309, "Magical Monmouth")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 65, 35, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 121, 44, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 88, 53, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 304, 139, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 74, 138, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 263, 26, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 464, 139, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 317, 22, 65511, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 528, 189, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 376, 168, 65516, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 373, 205, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35485, 477, 204, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 413, 47, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 491, 22, 65450, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2503, 367, 4, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 85, 157, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 472, 28, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 46, 205, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 283, 78, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 104, 205, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 329, 157, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 489, 157, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 183, 60, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 122, 52, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(25, 596, 97, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 65470, 127, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 6, 191, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 65474, 49, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(32877, 65532, 163, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 39, 168, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 581, 2, 65442, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 661, 134, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(184, 603, 128, 0, 5309));
          this.AddRoomDecoration(RoomDecoration.FromCode(2694, 123, 101, 0, 5309));
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

