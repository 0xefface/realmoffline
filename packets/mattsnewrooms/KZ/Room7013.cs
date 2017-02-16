using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7013 : Room
  {
        public Room7013()
            : base(7013, "Kurz Chapel")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 49, 1, 65437, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 73, 1, 65437, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 147, 136, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(45, 7, 183, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2517, 455, 8, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 86, 177, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 178, 6, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 353, 1, 65526, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 270, 1, 65526, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2529, 305, 9, 65496, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 367, 93, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2737, 251, 94, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 270, 175, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2587, 158, 155, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 65, 5, 10, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 10, 177, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 26, 160, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 42, 186, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 286, 147, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 42, 132, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 660, 105, 0, 7013));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 594, 15, 0, 7013));
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

