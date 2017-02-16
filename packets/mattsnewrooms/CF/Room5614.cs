using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room5614 : Room
  {
        public Room5614()
            : base(5614, "Isle Park")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.GrassyBlueSky;
          this.BlockedRoomExits = BlockedExits.DownRight;
          this.AddRoomDecoration(RoomDecoration.FromCode(175, 479, 104, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32989, 29, 233, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32978, 361, 125, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(215, 513, 126, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 202, 131, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(211, 288, 123, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32989, 69, 201, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32982, 177, 121, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 434, 124, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(207, 36, 272, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(198, 52, 108, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 45, 136, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 575, 169, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 552, 124, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32989, 97, 174, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(214, 221, 120, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(208, 124, 162, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32980, 292, 271, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32973, 174, 104, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32975, 613, 269, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(210, 461, 271, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 539, 157, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 596, 215, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(221, 566, 182, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32983, 124, 124, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(212, 196, 269, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(200, 202, 142, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(176, 65484, 104, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 473, 275, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 158, 276, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(114, 140, 272, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32875, 661, 314, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(165, 422, 118, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 541, 142, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 72, 125, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(43, 249, 119, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(127, 9, 148, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 246, 206, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 388, 193, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(183, 338, 273, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32880, 67, 164, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(231, 9, 163, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(62, 170, 148, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 98, 270, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(751, 128, 125, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(753, 411, 96, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(201, 13, 195, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(104, 540, 265, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(63, 481, 155, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32883, 220, 144, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 328, 189, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 407, 210, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 265, 191, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(104, 146, 160, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 612, 167, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(61, 469, 153, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 360, 217, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(20, 288, 217, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 576, 145, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32789, 542, 125, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(21, 641, 123, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(115, 245, 235, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(104, 514, 203, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(32788, 327, 200, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 52, 273, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 75, 242, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7900, 315, 143, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 548, 141, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(104, 65530, 233, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 101, 212, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 128, 157, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7901, 620, 317, 0, 5614));
          this.AddRoomDecoration(RoomDecoration.FromCode(7909, 532, 171, 0, 5614));
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

