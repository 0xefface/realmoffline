using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5414 : Room
  {
        public Room5414()
            : base(5414, "Sorcerer's Cauldron")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PlainDirt;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 229, 1, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2607, 39, 168, 20, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2509, 1, 28, 65437, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2952, 619, 353, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 629, 365, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 588, 44, 65500, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2951, 595, 313, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(35466, 127, 132, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 614, 93, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2745, 590, 2, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(35480, 620, 129, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2501, 197, 39, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 298, 49, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2513, 401, 42, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2608, 258, 72, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(35376, 339, 65, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2611, 313, 76, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(2543, 299, 170, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 581, 328, 0, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(154, 624, 36, 65500, 5414));
          this.AddRoomDecoration(RoomDecoration.FromCode(152, 567, 337, 0, 5414));
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

