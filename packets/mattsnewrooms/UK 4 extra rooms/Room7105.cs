using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7105 : Room
  {
        public Room7105()
            : base(7105, "Training Grounds")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 319, 211, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1586, 201, 185, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1585, 334, 79, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6012, 20, 291, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1596, 154, 113, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6012, 9, 329, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 416, 118, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 233, 117, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 337, 116, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6012, 42, 335, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 229, 145, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 351, 146, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 464, 140, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(34363, 211, 131, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(34363, 493, 165, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6151, 52, 61, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 156, 160, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 281, 166, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 413, 177, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 237, 190, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6012, 618, 320, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1595, 350, 196, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(34354, 534, 156, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(1588, 444, 195, 65526, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 98, 43, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 90, 279, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38772, 531, 283, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38772, 548, 35, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6003, 74, 41, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38771, 573, 40, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6003, 675, 243, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 622, 268, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38772, 1, 263, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6003, 24, 255, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 658, 75, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38772, 65500, 94, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38771, 663, 208, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 102, 63, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 507, 63, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 571, 87, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 564, 255, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 505, 285, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6046, 592, 70, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6014, 15, 99, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6002, 35, 97, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38770, 143, 288, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 43, 343, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 577, 343, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 50, 34, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(7902, 578, 36, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38770, 84, 265, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6004, 12, 72, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38771, 131, 27, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(38771, 475, 26, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6003, 6, 231, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6041, 599, 70, 0, 7105));
          this.AddRoomDecoration(RoomDecoration.FromCode(6041, 39, 100, 0, 7105));
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

