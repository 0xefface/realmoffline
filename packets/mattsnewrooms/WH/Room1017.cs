using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room1017 : Room
  {
        public Room1017()
            : base(1017, "West Havenwood")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(32890, 261, 287, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(204, 118, 151, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(202, 88, 153, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 148, 273, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 127, 196, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 145, 265, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 166, 182, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 33, 181, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 368, 198, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 205, 178, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 484, 204, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 36, 195, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 78, 152, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 114, 147, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 253, 277, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 479, 225, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(112, 210, 197, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 97, 140, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2716, 230, 292, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32959, 613, 213, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32958, 561, 137, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32964, 559, 136, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 516, 199, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32993, 283, 187, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 289, 194, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 541, 214, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(33008, 552, 17, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(232, 512, 125, 20, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(226, 592, 202, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 339, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(173, 175, 102, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 321, 100, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 232, 89, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 0, 84, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 65511, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 402, 105, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(142, 514, 106, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 589, 197, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 637, 258, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 641, 83, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(225, 255, 185, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32999, 61, 177, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(185, 257, 288, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 628, 234, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 498, 154, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 515, 121, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 542, 101, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 550, 119, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 563, 138, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 577, 154, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 591, 173, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 551, 133, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 540, 114, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 566, 152, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 578, 168, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(1, 595, 191, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 630, 241, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 260, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 279, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 299, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 642, 317, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(3, 607, 204, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 492, 106, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 471, 106, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 449, 104, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 426, 104, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 403, 104, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 379, 104, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 355, 104, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 35, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 59, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 82, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 11, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 106, 103, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(32957, 636, 247, 0, 1017));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 593, 159, 0, 1017));
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

