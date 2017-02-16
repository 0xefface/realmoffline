using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
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
byte[] roomDecItems = { 0x15, 0xD4, 0x09, 0xE5, 0x00, 0x01, 0x00, 0x00, 0x00, 0x2F, 0x0A, 0x27, 0x00, 0xA8, 0x00, 0x14, 0x00, 0xCD, 0x09, 0x01, 0x00, 0x1C, 0x00, 0x9D, 0xFF, 0x88, 0x0B, 0x6B, 0x02, 0x61, 0x01, 0x00, 0x00, 0x87, 0x0B, 0x75, 0x02, 0x6D, 0x01, 0x00, 0x00, 0x9A, 0x00, 0x4C, 0x02, 0x2C, 0x00, 0xDC, 0xFF, 0x87, 0x0B, 0x53, 0x02, 0x39, 0x01, 0x00, 0x00, 0x8A, 0x8A, 0x7F, 0x00, 0x84, 0x00, 0x00, 0x00, 0xB9, 0x0A, 0x66, 0x02, 0x5D, 0x00, 0x00, 0x00, 0xB9, 0x0A, 0x4E, 0x02, 0x02, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x6C, 0x02, 0x81, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xC5, 0x00, 0x27, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x2A, 0x01, 0x31, 0x00, 0x00, 0x00, 0xD1, 0x09, 0x91, 0x01, 0x2A, 0x00, 0x00, 0x00, 0x30, 0x0A, 0x02, 0x01, 0x48, 0x00, 0x00, 0x00, 0x30, 0x8A, 0x53, 0x01, 0x41, 0x00, 0x00, 0x00, 0x33, 0x0A, 0x39, 0x01, 0x4C, 0x00, 0x00, 0x00, 0xEF, 0x09, 0x2B, 0x01, 0xAA, 0x00, 0x00, 0x00, 0x98, 0x00, 0x45, 0x02, 0x48, 0x01, 0x00, 0x00, 0x9A, 0x00, 0x70, 0x02, 0x24, 0x00, 0xDC, 0xFF, 0x98, 0x00, 0x37, 0x02, 0x51, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0xBF, 0x4F, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x26, 0x15, 0xC1, 0x00, 0xCD, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
