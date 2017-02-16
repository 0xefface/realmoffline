using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7000 : Room
  {
        public Room7000()
            : base(7000, "Filthy Beggar Inn")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 363, 8, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 197, 169, 20, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 134, 35, 65437, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 74, 198, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 20, 81, 6, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2708, 295, 66, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 592, 37, 65466, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 335, 4, 65470, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 365, 42, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 466, 49, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 572, 42, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 419, 58, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 506, 60, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 470, 73, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2699, 306, 164, 55, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2586, 286, 186, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 354, 161, 65516, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 431, 192, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 447, 164, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 261, 168, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 343, 162, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 174, 215, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 105, 212, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 139, 73, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 626, 39, 65519, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 206, 211, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 134, 204, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 101, 41, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 643, 34, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 30, 62, 0, 7000));
          this.AddRoomDecoration(RoomDecoration.FromCode(164, 83, 66, 0, 7000));
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

