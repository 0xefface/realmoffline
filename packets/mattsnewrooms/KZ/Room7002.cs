using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7002 : Room
  {
        public Room7002()
            : base(7002, "Pleasure's Fabric")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 435, 151, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 481, 137, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 253, 3, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 97, 205, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 5, 205, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 38, 211, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 110, 161, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 211, 29, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 36, 45, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 140, 37, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 85, 61, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 50, 71, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 218, 54, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2522, 497, 147, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 513, 134, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2691, 196, 98, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 5, 176, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 257, 199, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 274, 194, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(186, 352, 204, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 460, 101, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(94, 335, 1, 65470, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 541, 76, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 240, 188, 0, 7002));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 590, 55, 0, 7002));
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

