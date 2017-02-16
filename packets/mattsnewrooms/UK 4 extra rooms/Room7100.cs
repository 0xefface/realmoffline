using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7100 : Room
  {
        public Room7100()
            : base(7100, "Usk Chapel")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.UpLeft;
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 357, 194, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6156, 633, 304, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6150, 489, 202, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6157, 228, 112, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 71, 179, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 82, 196, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 194, 57, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6157, 357, 113, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(38923, 98, 189, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 105, 6, 65419, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6149, 439, 52, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 412, 206, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 474, 206, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6149, 146, 48, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 122, 203, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 105, 181, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 612, 2, 65514, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(38772, 346, 19, 65273, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6005, 10, 8, 65489, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6006, 520, 262, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 60, 8, 65419, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(32949, 516, 260, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 51, 2, 65419, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6006, 139, 3, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 147, 10, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 65532, 92, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 70, 2, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(32949, 271, 194, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 629, 10, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6013, 473, 186, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6014, 484, 9, 65353, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6018, 111, 189, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 490, 188, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6160, 91, 9, 65379, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6150, 620, 322, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 436, 131, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2702, 144, 70, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 208, 9, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2527, 439, 11, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2528, 374, 8, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2529, 283, 46, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(35470, 440, 68, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 147, 136, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2549, 437, 134, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(2558, 146, 133, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 500, 200, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6067, 633, 48, 0, 7100));
          this.AddRoomDecoration(RoomDecoration.FromCode(6082, 65497, 30, 0, 7100));
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

