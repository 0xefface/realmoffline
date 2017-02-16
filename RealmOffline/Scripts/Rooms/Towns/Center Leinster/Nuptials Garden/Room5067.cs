using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
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
byte[] roomDecItems = { 0x78, 0x18, 0x00, 0xFA, 0x01, 0x1A, 0x00, 0x00, 0x00, 0xE8, 0x09, 0xD2, 0x01, 0x33, 0x00, 0x00, 0x00, 0xE8, 0x89, 0x88, 0x00, 0x33, 0x00, 0x00, 0x00, 0xE8, 0x09, 0x12, 0x02, 0x33, 0x00, 0x00, 0x00, 0x37, 0x08, 0x33, 0x01, 0xAD, 0x00, 0x00, 0x00, 0x18, 0x80, 0x77, 0x00, 0x15, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x7E, 0x01, 0xB2, 0x00, 0x00, 0x00, 0x6D, 0x80, 0xA3, 0x01, 0x37, 0x00, 0x00, 0x00, 0x6D, 0x00, 0xD5, 0x00, 0x3A, 0x00, 0x00, 0x00, 0x6D, 0x80, 0x54, 0x02, 0x38, 0x00, 0x00, 0x00, 0x67, 0x00, 0x7B, 0x00, 0x3A, 0x00, 0x00, 0x00, 0x67, 0x80, 0xFB, 0x01, 0x37, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x6C, 0x02, 0x5C, 0x00, 0x00, 0x00, 0x0F, 0x80, 0x12, 0x00, 0x56, 0x00, 0x00, 0x00, 0x14, 0x00, 0x33, 0x01, 0x39, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xE7, 0x00, 0x48, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x80, 0x01, 0x46, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x90, 0x01, 0x59, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xE0, 0x00, 0x53, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x7F, 0x01, 0xA2, 0x00, 0x00, 0x00, 0x97, 0x8A, 0xE6, 0x00, 0xA2, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x90, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xDC, 0x00, 0xB1, 0x00, 0x00, 0x00, 0x17, 0x00, 0x21, 0x02, 0x3E, 0x00, 0x00, 0x00, 0x17, 0x80, 0x50, 0x00, 0x3E, 0x00, 0x00, 0x00, 0x16, 0x00, 0x42, 0x01, 0x8F, 0x00, 0x00, 0x00, 0x16, 0x00, 0xE1, 0x00, 0x47, 0x00, 0x00, 0x00, 0x16, 0x80, 0x93, 0x01, 0x4A, 0x00, 0x00, 0x00, 0x17, 0x00, 0x8A, 0x00, 0x69, 0x00, 0x00, 0x00, 0x17, 0x80, 0xE8, 0x01, 0x6B, 0x00, 0x00, 0x00, 0x18, 0x00, 0xF1, 0x01, 0x0B, 0x01, 0x00, 0x00, 0x18, 0x80, 0x7A, 0x00, 0x0A, 0x01, 0x00, 0x00, 0xE9, 0x00, 0x49, 0x01, 0x17, 0x01, 0x00, 0x00, 0x3F, 0x80, 0xEA, 0x00, 0x3E, 0x01, 0x00, 0x00, 0x3F, 0x80, 0xA5, 0x01, 0x3D, 0x01, 0x00, 0x00, 0xE9, 0x80, 0x47, 0x01, 0x18, 0x01, 0x00, 0x00, 0x8B, 0x0B, 0x48, 0x02, 0x7E, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x16, 0x00, 0x7F, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x8C, 0x02, 0xA0, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x83, 0x02, 0xB2, 0x00, 0x00, 0x00, 0x98, 0x0A, 0x81, 0x02, 0xD9, 0x00, 0x00, 0x00, 0x14, 0x00, 0x17, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x14, 0x00, 0x38, 0x01, 0xBC, 0x00, 0x00, 0x00, 0x14, 0x80, 0x5E, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x6B, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xEB, 0x00, 0xB3, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x28, 0x01, 0xB5, 0x00, 0x00, 0x00, 0x16, 0x00, 0x7C, 0x02, 0xB1, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x57, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x3E, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xA3, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xFE, 0x00, 0xB5, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xC7, 0x00, 0xB2, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x10, 0x01, 0xB7, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x19, 0x00, 0x3A, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xEB, 0x01, 0x36, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x37, 0x02, 0x34, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x8A, 0x00, 0x37, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xF4, 0x00, 0x35, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x70, 0x01, 0x36, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xD2, 0x01, 0x36, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x8C, 0x01, 0x34, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xAA, 0x00, 0x38, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x0E, 0x00, 0x36, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x24, 0x00, 0x37, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x18, 0x02, 0x35, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x75, 0x02, 0x34, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x45, 0x00, 0x37, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x6B, 0x00, 0x37, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x2C, 0x02, 0x35, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x89, 0x01, 0x4D, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x79, 0x01, 0x3E, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xD1, 0x00, 0x37, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xD8, 0x00, 0x5C, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xEC, 0x00, 0x40, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xD7, 0x00, 0x3F, 0x01, 0x00, 0x00, 0x3F, 0x00, 0x94, 0x01, 0x3E, 0x01, 0x00, 0x00, 0x18, 0x00, 0xDA, 0x01, 0x88, 0x00, 0x00, 0x00, 0x18, 0x80, 0x68, 0x00, 0x83, 0x00, 0x00, 0x00, 0x16, 0x80, 0x11, 0x00, 0xA6, 0x00, 0x00, 0x00, 0x98, 0x0A, 0xF8, 0xFF, 0xAE, 0x00, 0x00, 0x00, 0x98, 0x8A, 0xFA, 0xFF, 0xD4, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x8E, 0x02, 0xF8, 0x00, 0x00, 0x00, 0x98, 0x0A, 0xFA, 0xFF, 0xF7, 0x00, 0x00, 0x00, 0x98, 0x8A, 0x54, 0x02, 0x43, 0x01, 0x00, 0x00, 0x98, 0x0A, 0x87, 0x02, 0x1D, 0x01, 0x00, 0x00, 0x98, 0x8A, 0xFA, 0xFF, 0x15, 0x01, 0x00, 0x00, 0x98, 0x8A, 0x85, 0x02, 0x05, 0x01, 0x00, 0x00, 0x98, 0x0A, 0x2D, 0x02, 0x55, 0x01, 0x00, 0x00, 0x98, 0x0A, 0x30, 0x00, 0x3D, 0x01, 0x00, 0x00, 0x98, 0x8A, 0x59, 0x00, 0x58, 0x01, 0x00, 0x00, 0x3F, 0x80, 0x7E, 0x00, 0x7F, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xF0, 0x01, 0x7B, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x02, 0x02, 0x7B, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x65, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x0C, 0x02, 0xA0, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x6A, 0x00, 0x96, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x4C, 0x00, 0xA2, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x34, 0x02, 0xA3, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x69, 0x00, 0xA1, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x1A, 0x02, 0x90, 0x00, 0x00, 0x00, 0x0F, 0x80, 0x20, 0x00, 0x79, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x62, 0x02, 0x84, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x49, 0x01, 0xAE, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0x22, 0x01, 0xAD, 0x00, 0x00, 0x00, 0x8C, 0x0B, 0xF7, 0x00, 0xAF, 0x00, 0x00, 0x00, 0x8C, 0x8B, 0x6E, 0x01, 0xAE, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x77, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x07, 0x02, 0x98, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x34, 0x02, 0x8F, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x5C, 0x00, 0x95, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x43, 0x00, 0x97, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x24, 0x02, 0xA3, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x78, 0x00, 0x9A, 0x00, 0x00, 0x00, 0x0A, 0x00, 0xE2, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x83, 0x01, 0x7F, 0x00, 0x00, 0x00, 0x0A, 0x00, 0xE2, 0x00, 0x93, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x83, 0x01, 0x96, 0x00, 0x00, 0x00, 0x05, 0x00, 0xEC, 0x00, 0xA1, 0x00, 0x00, 0x00, 0x05, 0x00, 0x7C, 0x01, 0xA2, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x06, 0x00, 0x01, 0xB7, 0x07, 0x32, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x13, 0x75, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x16, 0x00, 0x33, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x13, 0x51, 0x00, 0x9F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x16, 0x00, 0x34, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x13, 0x2F, 0x02, 0x9C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB7, 0x07, 0x35, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x13, 0xF6, 0x01, 0x79, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x07, 0x36, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x13, 0x83, 0x01, 0xA9, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x07, 0x37, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xCB, 0x13, 0xE5, 0x00, 0xA7, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x95, 0xB8, 0xEC, 0x5D };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
