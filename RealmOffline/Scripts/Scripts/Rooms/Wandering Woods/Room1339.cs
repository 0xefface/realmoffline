using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;

namespace Scripts.Rooms
{
public class Room1339 : Room
{
public Room1339()
: base(1339, "Wandering Woods")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
this.BlockedRoomExits = BlockedExits.None;
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 77, 124, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(2743, 573, 137, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(168, 342, 138, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 392, 142, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 628, 144, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(154, 174, 140, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 573, 150, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(153, 490, 138, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(32922, 314, 143, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 244, 145, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 524, 145, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 89, 134, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(156, 28, 125, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(48, 33, 253, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(49, 107, 216, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 563, 266, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(115, 576, 267, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(114, 474, 328, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(50, 360, 255, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(32817, 481, 237, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(2952, 214, 218, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(232, 449, 126, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(45, 609, 320, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 263, 144, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 506, 244, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 0, 270, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 584, 335, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 67, 134, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 418, 141, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 394, 141, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 241, 145, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 9, 126, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 329, 142, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 304, 141, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 58, 270, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 85, 213, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 92, 229, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 200, 226, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 192, 228, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 373, 264, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(1223, 482, 234, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 347, 142, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 541, 144, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 518, 145, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 272, 143, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 133, 139, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 157, 139, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(5, 179, 139, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(230, 97, 217, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 257, 196, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 237, 194, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 360, 177, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(32995, 373, 182, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(234, 456, 115, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 407, 152, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(228, 417, 156, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 442, 195, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 495, 246, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 199, 218, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 334, 259, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 24, 262, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 92, 216, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 60, 257, 0, 1339));
this.AddRoomDecoration(RoomDecoration.FromCode(223, 117, 212, 0, 1339));



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
