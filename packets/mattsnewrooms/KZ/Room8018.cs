using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
 
namespace Scripts.Rooms
{
  public class Room8018 : Room
  {
        public Room8018()
            : base(8018, "Dirty Dagger Pub Lobby")
      { }
      public override void ApplyRoomLayout()
      {
          this.Background = RoomBackground.PavedRoom1;
          this.BlockedRoomExits = BlockedExits.All;
          this.AddRoomDecoration(RoomDecoration.FromCode(2164, 86, 169, 50, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 443, 8, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2028, 174, 8, 8, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2127, 287, 128, 150, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 235, 35, 65475, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2005, 538, 114, 100, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2006, 624, 121, 50, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2103, 234, 237, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2112, 182, 71, 65511, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2128, 178, 78, 1, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2017, 72, 16, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2166, 398, 149, 26, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2221, 65527, 54, 65437, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2241, 337, 235, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2081, 643, 174, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2105, 138, 236, 10, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2029, 350, 51, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2018, 22, 63, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 156, 287, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(34914, 147, 238, 65, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(34913, 169, 237, 70, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 440, 74, 65450, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2082, 357, 80, 65455, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2080, 14, 170, 0, 8018));
          this.AddRoomDecoration(RoomDecoration.FromCode(2599, 487, 290, 0, 8018));
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

