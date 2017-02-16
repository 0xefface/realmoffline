using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room2049 : Room
  {
        public Room2049()
            : base(2049, "North Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.Down;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 306, 104, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2742, 493, 113, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 184, 124, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 54, 178, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 527, 190, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 45, 172, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 287, 295, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(241, 417, 46, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 532, 191, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 388, 275, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 448, 280, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 523, 188, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 49, 198, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 62, 190, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 341, 281, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 306, 127, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 282, 128, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 258, 127, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 233, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 209, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 187, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 163, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 139, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 115, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 91, 125, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 71, 124, 0, 2049));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 706, 263, 0, 2049));
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

