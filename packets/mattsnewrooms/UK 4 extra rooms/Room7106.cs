using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room7106 : Room
  {
        public Room7106()
            : base(7106, "The Usk Boutique")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.SnowyDesert;
          this.BlockedRoomExits = BlockedExits.None;
          this.AddRoomDecoration(RoomDecoration.FromCode(2516, 150, 16, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6144, 65489, 169, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(38914, 65490, 206, 150, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2524, 47, 192, 150, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 207, 32, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6148, 229, 52, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2525, 412, 32, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6148, 424, 51, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 211, 147, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 388, 204, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 195, 174, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2588, 351, 175, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(38922, 65535, 212, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6018, 470, 198, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2594, 367, 148, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6164, 28, 211, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(38922, 304, 182, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6152, 434, 192, 80, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 421, 191, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 444, 192, 30, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6153, 226, 194, 30, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2715, 193, 193, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6155, 480, 203, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2526, 304, 38, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6148, 321, 54, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2244, 163, 202, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 214, 195, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6157, 314, 129, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(35516, 540, 49, 65469, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6150, 497, 127, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(181, 554, 9, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(182, 543, 114, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(180, 587, 15, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(32949, 544, 30, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(6013, 519, 110, 0, 7106));
          this.AddRoomDecoration(RoomDecoration.FromCode(32784, 141, 224, 0, 7106));
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

