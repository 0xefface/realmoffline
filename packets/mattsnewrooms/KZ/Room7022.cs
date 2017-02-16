using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7022 : Room
  {
        public Room7022()
            : base(7022, "Battling Mage")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 330, 21, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 145, 164, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 101, 150, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 67, 144, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 25, 160, 65486, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(35375, 523, 164, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2521, 574, 152, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2504, 345, 18, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 630, 318, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 49, 1, 65437, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 146, 241, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 582, 2, 65437, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 590, 2, 65437, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2694, 424, 165, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2547, 226, 197, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2553, 243, 170, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 143, 243, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 275, 1, 65478, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 50, 128, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2713, 92, 127, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 603, 119, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(149, 621, 71, 0, 7022));
          this.AddRoomDecoration(RoomDecoration.FromCode(150, 94, 31, 0, 7022));
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

