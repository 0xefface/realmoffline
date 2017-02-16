using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8019 : Room
  {
        public Room8019()
            : base(8019, "Dapper Wear Interior")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 346, 60, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 442, 66, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 590, 134, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 502, 120, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 236, 103, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 130, 104, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 40, 104, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 314, 230, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 314, 200, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 192, 170, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 312, 114, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 87, 207, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 85, 134, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 84, 117, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 196, 142, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 88, 164, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 199, 200, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 83, 149, 100, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 81, 235, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2118, 316, 146, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(34886, 202, 173, 100, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2104, 70, 318, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 424, 221, 0, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 422, 142, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2042, 532, 156, 50, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 477, 230, 20, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 475, 181, 100, 8019));
          this.AddRoomDecoration(RoomDecoration.FromCode(2557, 584, 196, 100, 8019));
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

