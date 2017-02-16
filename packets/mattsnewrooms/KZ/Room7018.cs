using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7018 : Room
  {
        public Room7018()
            : base(7018, "Dirty Dagger Pub")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 49, 1, 65437, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 73, 1, 65437, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 386, 201, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 580, 184, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 504, 7, 65521, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 286, 54, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 498, 113, 70, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 470, 155, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 78, 27, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 180, 37, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 252, 42, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 198, 56, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 150, 42, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 211, 168, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 134, 168, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 286, 168, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2700, 175, 81, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 301, 38, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 405, 27, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 334, 47, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 371, 160, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 65519, 106, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 647, 104, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 551, 185, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 290, 191, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 264, 186, 0, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 37, 17, 65413, 7018));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 128, 196, 0, 7018));
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

