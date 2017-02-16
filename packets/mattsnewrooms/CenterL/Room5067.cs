using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5067 : Room
  {
        public Room5067()
            : base(5067, "Nuptials Garden")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.UpLeftRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 506, 26, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 466, 51, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35304, 136, 51, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2536, 530, 51, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 307, 173, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 119, 21, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 382, 178, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32877, 419, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 213, 58, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32877, 596, 56, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(103, 123, 58, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32871, 507, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 620, 92, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 18, 86, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 307, 57, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 231, 72, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 384, 70, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 400, 89, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 224, 83, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 383, 162, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 230, 162, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 400, 179, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 220, 177, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 545, 62, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 80, 62, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 322, 143, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 225, 71, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 403, 74, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(23, 138, 105, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32791, 488, 107, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 497, 267, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 122, 266, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(233, 329, 279, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 234, 318, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 421, 317, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(33001, 327, 280, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 584, 126, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 22, 127, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 652, 160, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 643, 178, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 641, 217, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 279, 179, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 312, 188, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 350, 180, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 363, 179, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 235, 179, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 296, 181, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 636, 177, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 343, 180, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 318, 180, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 419, 179, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 254, 181, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 199, 178, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 272, 183, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(109, 25, 58, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 491, 54, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 567, 52, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 138, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 244, 53, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 368, 54, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 466, 54, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 396, 52, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 170, 56, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 14, 54, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 36, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 536, 53, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 629, 52, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 69, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 107, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 556, 53, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 393, 77, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 377, 62, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 209, 55, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 216, 92, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 236, 64, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 215, 319, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 404, 318, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 474, 136, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 104, 131, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32790, 17, 166, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 65528, 174, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 65530, 212, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 654, 248, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 65530, 247, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 596, 323, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 647, 285, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 65530, 277, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 645, 261, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 557, 341, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2712, 48, 317, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 89, 344, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 126, 127, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 496, 123, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 514, 123, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 101, 125, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 524, 160, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 106, 150, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 76, 162, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 564, 163, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 105, 161, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 538, 144, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 32, 121, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 610, 132, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 329, 174, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 290, 173, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(2956, 247, 175, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(35724, 366, 174, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 119, 159, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 519, 152, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 564, 143, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 92, 149, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 67, 151, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 548, 163, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(32831, 120, 154, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(10, 226, 126, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(10, 387, 127, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(10, 226, 147, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(10, 387, 150, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 236, 161, 0, 5067));
          this.AddRoomDecoration(RoomDecoration.FromCode(5, 380, 162, 0, 5067));
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

