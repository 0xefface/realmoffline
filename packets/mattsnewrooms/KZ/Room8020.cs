using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8020 : Room
  {
        public Room8020()
            : base(8020, "Mirror N Gear Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 312, 2, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 432, 2, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 550, 2, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 196, 2, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 95, 3, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 65522, 3, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 637, 2, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2101, 98, 222, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2102, 545, 223, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 323, 279, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 220, 104, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 98, 104, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 426, 104, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 558, 104, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 199, 151, 50, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 77, 151, 50, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 537, 151, 50, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 405, 151, 50, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2160, 326, 286, 70, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2140, 39, 230, 50, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(34909, 604, 229, 50, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 324, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 239, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 413, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 152, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 69, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 9, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 498, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 580, 148, 0, 8020));
          this.AddRoomDecoration(RoomDecoration.FromCode(2395, 656, 148, 0, 8020));
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

