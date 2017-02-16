using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1678 : Room
{
public Room1678()
: base(1678, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(32936, 319, 138, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 389, 147, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 154, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(32921, 182, 131, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 318, 140, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 240, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(32924, 484, 144, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 74, 131, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 424, 218, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 516, 311, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 388, 284, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 303, 245, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 80, 370, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 495, 326, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(204, 655, 293, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(203, 630, 495, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 582, 258, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 630, 321, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(2951, 531, 157, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 554, 197, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 523, 155, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(157, 265, 255, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 128, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 152, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 176, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 88, 129, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 220, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 290, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 334, 139, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 367, 146, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 391, 146, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 468, 143, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 495, 143, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 517, 155, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 273, 244, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(3, 289, 243, 0, 1678));
this.AddRoomDecoration(RoomDecoration.FromCode(120, 65533, 377, 0, 1678));



base.ApplyRoomLayout();
}
        public override uint GetNextRoomByExit(RoomExit exit)
        {
            switch (exit)
            {
                case RoomExit.North: return 0;
                case RoomExit.South: return 0;
                case RoomExit.East:  return 0;
                case RoomExit.West:  return 0;
                default: return 0;
            }
        }
}
}
