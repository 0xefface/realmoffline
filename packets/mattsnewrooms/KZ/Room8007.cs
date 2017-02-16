using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8007 : Room
  {
        public Room8007()
            : base(8007, "Barbary Clips Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2107, 161, 159, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2108, 471, 152, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 358, 21, 20, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 455, 16, 20, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2013, 167, 1, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2002, 504, 17, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2001, 263, 20, 20, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 88, 26, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 192, 75, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 107, 88, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2014, 19, 37, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 384, 263, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2142, 262, 354, 65496, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(34910, 361, 398, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2143, 119, 160, 17, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 203, 263, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(34911, 515, 153, 15, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2165, 480, 71, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 597, 171, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 384, 412, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2086, 325, 131, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2087, 307, 134, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 338, 105, 0, 8007));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 248, 109, 0, 8007));
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

