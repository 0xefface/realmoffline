using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8305 : Room
  {
        public Room8305()
            : base(8305, "Pickpocket's Path Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 410, 82, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 588, 153, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 497, 139, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 313, 76, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 198, 119, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 73, 118, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 53, 118, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 75, 225, 65486, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 75, 264, 50, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 75, 302, 150, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 75, 341, 250, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 456, 212, 200, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 76, 243, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2125, 97, 456, 400, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 534, 224, 200, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2129, 72, 276, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 35, 456, 400, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2130, 95, 269, 60, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2130, 55, 268, 60, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(34897, 79, 322, 200, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(34894, 77, 269, 90, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 426, 313, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 403, 208, 100, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 485, 222, 100, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 566, 236, 100, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2111, 647, 250, 100, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 459, 297, 200, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 561, 316, 200, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 664, 333, 200, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 217, 265, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 515, 242, 65486, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2390, 310, 264, 0, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2391, 415, 228, 65486, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 587, 253, 65486, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 637, 261, 65486, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 143, 215, 65486, 8305));
          this.AddRoomDecoration(RoomDecoration.FromCode(2393, 609, 235, 200, 8305));
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

