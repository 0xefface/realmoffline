using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5610 : Room
  {
        public Room5610()
            : base(5610, "Treachery Weapons")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 191, 82, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 231, 87, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 545, 79, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 325, 86, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 450, 86, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 205, 69, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 508, 254, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 339, 70, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(35385, 458, 70, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2617, 551, 70, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2631, 212, 92, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 238, 92, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2634, 552, 94, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 368, 92, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2633, 433, 93, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 263, 195, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 190, 195, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2582, 428, 198, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 257, 259, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 274, 197, 15, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 202, 197, 15, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2597, 441, 202, 15, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(7903, 169, 259, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 195, 252, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2953, 607, 236, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2718, 126, 242, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2955, 575, 230, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(35723, 532, 237, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2954, 160, 256, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(60, 618, 231, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2717, 290, 253, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(35499, 172, 245, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2801, 501, 144, 21, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(2808, 493, 140, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(8, 168, 217, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(12, 163, 215, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(8, 165, 208, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(12, 171, 204, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(12, 167, 198, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(12, 162, 198, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(12, 160, 193, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(12, 156, 189, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(8, 154, 186, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 99, 290, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 547, 287, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(22, 323, 297, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 196, 91, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 182, 106, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 196, 142, 0, 5610));
          this.AddRoomDecoration(RoomDecoration.FromCode(40672, 189, 158, 0, 5610));
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

