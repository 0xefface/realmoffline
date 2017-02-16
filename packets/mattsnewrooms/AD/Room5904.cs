using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5904 : Room
  {
        public Room5904()
            : base(5904, "Asgard General Goods")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 479, 7, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(34289, 162, 119, 65476, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 687, 175, 32, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 609, 218, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 165, 175, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 522, 295, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 438, 142, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 500, 206, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 217, 180, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2621, 766, 146, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 240, 139, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 595, 233, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 457, 38, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 243, 136, 65527, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 621, 283, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(35012, 494, 203, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(35369, 630, 186, 32, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 422, 2, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2542, 441, 137, 65527, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2624, 228, 38, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 314, 19, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 222, 16, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2601, 282, 84, 32, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 284, 214, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 508, 217, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 652, 241, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 622, 307, 0, 5904));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 622, 314, 0, 5904));
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

