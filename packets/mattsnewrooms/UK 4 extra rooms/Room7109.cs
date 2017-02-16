using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7109 : Room
  {
        public Room7109()
            : base(7109, "The Best Pick")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 341, 42, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 416, 84, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 513, 73, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 404, 103, 50, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 117, 195, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(38932, 498, 299, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2505, 612, 84, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 454, 320, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2510, 78, 260, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2794, 96, 262, 5, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 158, 201, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2802, 103, 266, 20, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 218, 294, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 636, 270, 48, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 227, 284, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 516, 100, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 201, 208, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(123, 613, 267, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2506, 608, 35, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 588, 212, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 485, 105, 65445, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2548, 541, 105, 42, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 588, 206, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 485, 190, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(2545, 541, 110, 50, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(38920, 191, 222, 0, 7109));
          this.AddRoomDecoration(RoomDecoration.FromCode(6005, 558, 270, 0, 7109));
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

