using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5039 : Room
  {
        public Room5039()
            : base(5039, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 552, 44, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2748, 484, 74, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 607, 99, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 587, 72, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 47, 112, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 121, 114, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 181, 114, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 62, 95, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2714, 174, 113, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 110, 283, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 172, 75, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 140, 104, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 12, 139, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 9, 140, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 32, 125, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 75, 126, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 119, 126, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 160, 127, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 199, 128, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 144, 136, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 84, 135, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 182, 135, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 51, 137, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 147, 136, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(64, 113, 138, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 116, 137, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 180, 135, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 82, 141, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 45, 136, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 77, 129, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 541, 286, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 574, 76, 0, 5039));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 97, 128, 0, 5039));
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

