using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5066 : Room
  {
        public Room5066()
            : base(5066, "Leinster")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.Right;
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 491, 54, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 486, 38, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 494, 71, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 496, 93, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 496, 112, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 500, 141, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 535, 153, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 503, 215, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 559, 167, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 560, 182, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 499, 147, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 500, 222, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 500, 239, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 500, 256, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 500, 276, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 504, 295, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 507, 312, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(35479, 507, 326, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 58, 119, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 27, 119, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 25, 215, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 100, 117, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 100, 214, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 148, 120, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 200, 229, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 192, 330, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 55, 214, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 195, 216, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 104, 317, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 150, 215, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 200, 117, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 200, 213, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 200, 246, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 200, 264, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 200, 283, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 197, 299, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 196, 315, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 60, 295, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 200, 109, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 206, 93, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 210, 81, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 212, 65, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 212, 50, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(2711, 216, 39, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 28, 18, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 32, 47, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 103, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 29, 7, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 97, 215, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 75, 186, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 97, 263, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 79, 247, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 633, 2, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 650, 53, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 662, 78, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 690, 130, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 239, 301, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 617, 182, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(24, 630, 216, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32792, 621, 271, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 587, 308, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 609, 262, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 62, 62, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 610, 191, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(15, 609, 66, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 583, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 239, 220, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 22, 86, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 84, 81, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 25, 255, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 26, 314, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(32783, 127, 60, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 456, 124, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 458, 148, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 502, 156, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 517, 164, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 456, 136, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 454, 113, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 461, 213, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 460, 202, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 460, 226, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 497, 194, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 517, 175, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 473, 153, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 76, 123, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 13, 124, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 42, 124, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 153, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 128, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 237, 319, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 241, 253, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 239, 241, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 240, 230, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 240, 272, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 236, 310, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 177, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 202, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 225, 121, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 236, 116, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 242, 103, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 241, 91, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 243, 77, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 238, 75, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 245, 64, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 248, 52, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 242, 48, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 249, 41, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 238, 261, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 239, 283, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 241, 292, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 555, 202, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 529, 215, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 454, 102, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 453, 89, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 450, 77, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 449, 64, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 447, 53, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 444, 39, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 459, 242, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 461, 256, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 462, 274, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 463, 287, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 464, 303, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 465, 317, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 502, 131, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 156, 121, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 52, 122, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 535, 146, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 537, 512, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 599, 322, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 143, 517, 0, 5066));
          this.AddRoomDecoration(RoomDecoration.FromCode(7906, 54, 521, 0, 5066));
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

