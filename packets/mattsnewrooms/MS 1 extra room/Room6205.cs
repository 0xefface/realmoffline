using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room6205 : Room
  {
        public Room6205()
            : base(6205, "Murias Armorers Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 179, 7, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 77, 13, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2025, 383, 22, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(34989, 58, 172, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2026, 486, 32, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2119, 296, 286, 3, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(34888, 293, 287, 58, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(34907, 654, 185, 12, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 376, 129, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2088, 492, 130, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 596, 48, 20, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 283, 13, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 432, 158, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 434, 87, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 599, 184, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 71, 268, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2137, 149, 371, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2137, 154, 406, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 318, 133, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2109, 289, 286, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(34889, 288, 287, 34, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(34905, 651, 184, 65520, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2137, 19, 269, 13, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2139, 18, 269, 65523, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2138, 433, 158, 16, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 295, 114, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 376, 115, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 492, 116, 0, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 260, 126, 17, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 354, 130, 17, 6205));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 471, 131, 17, 6205));
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

