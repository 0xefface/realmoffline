using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5900 : Room
  {
        public Room5900()
            : base(5900, "The Pig and Kettle")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 37, 31, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 87, 39, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2502, 60, 49, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 55, 58, 10, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2602, 121, 54, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2520, 231, 20, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 230, 151, 100, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 499, 187, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 65532, 230, 65516, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 23, 195, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 120, 266, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 416, 151, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2792, 323, 111, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 335, 31, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(35370, 383, 154, 100, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 434, 31, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2796, 288, 122, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2593, 83, 174, 19, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 361, 193, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2592, 157, 154, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2581, 70, 165, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 143, 149, 65522, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2580, 402, 149, 65522, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(34288, 110, 201, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(1521, 36, 193, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(34289, 390, 192, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(34305, 468, 198, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 471, 180, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(34353, 511, 272, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 137, 225, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(2710, 284, 66, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(16, 432, 223, 0, 5900));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 359, 223, 0, 5900));
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

