using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5082 : Room
{
public Room5082()
: base(5082, "Bridal Mezzanine")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x66, 0x3F, 0x80, 0x04, 0x01, 0x33, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xFB, 0x00, 0x3A, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x7B, 0x01, 0x42, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x67, 0x01, 0x29, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x68, 0x01, 0x31, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x07, 0x01, 0x29, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x72, 0x01, 0x3A, 0x00, 0x00, 0x00, 0x2E, 0x00, 0xFB, 0x01, 0x54, 0x00, 0x00, 0x00, 0x18, 0x80, 0x6E, 0x00, 0x02, 0x00, 0x00, 0x00, 0xBD, 0x0A, 0x7C, 0x01, 0x2D, 0x00, 0x00, 0x00, 0xBD, 0x8A, 0xF3, 0x00, 0x2B, 0x00, 0x00, 0x00, 0x18, 0x80, 0x47, 0x00, 0x1C, 0x00, 0x00, 0x00, 0x18, 0x00, 0x23, 0x02, 0x17, 0x00, 0x00, 0x00, 0x97, 0x0A, 0xF0, 0x00, 0x23, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x30, 0x01, 0x01, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x36, 0x01, 0x03, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x29, 0x02, 0x6A, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x31, 0x00, 0x34, 0x00, 0x00, 0x00, 0x8D, 0x0B, 0xCE, 0x01, 0xBA, 0x00, 0x00, 0x00, 0x8E, 0x0B, 0xC0, 0x01, 0xB1, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x62, 0x00, 0x33, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x9B, 0x00, 0x32, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0xF9, 0x01, 0x35, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x37, 0x02, 0x37, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x78, 0x02, 0x38, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0xC5, 0x01, 0x36, 0x00, 0x00, 0x00, 0x97, 0x8A, 0x80, 0x01, 0x23, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x03, 0x00, 0x36, 0x00, 0x00, 0x00, 0x16, 0x00, 0x04, 0x01, 0x01, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xB3, 0x01, 0x5B, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x85, 0x01, 0x4D, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xEA, 0x00, 0x4E, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xF5, 0x00, 0x44, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xB9, 0x00, 0x5E, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x9B, 0x01, 0x54, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xD0, 0x00, 0x57, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x5B, 0x02, 0x6B, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x42, 0x02, 0x6C, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xCD, 0x01, 0x60, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x6B, 0x00, 0x6A, 0x00, 0x00, 0x00, 0x3F, 0x80, 0xE8, 0x01, 0x62, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xFE, 0x01, 0x65, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x15, 0x02, 0x67, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x85, 0x00, 0x67, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x9D, 0x00, 0x63, 0x00, 0x00, 0x00, 0x16, 0x00, 0x42, 0x01, 0x99, 0x00, 0x00, 0x00, 0x15, 0x00, 0x23, 0x01, 0xB9, 0x00, 0x00, 0x00, 0x8E, 0x8B, 0xC6, 0x00, 0xB0, 0x00, 0x00, 0x00, 0x8D, 0x8B, 0xA4, 0x00, 0xBA, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x6B, 0x01, 0xB5, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x57, 0x01, 0xB5, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x40, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x32, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x0B, 0x01, 0xB5, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x23, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xF9, 0x00, 0xB8, 0x00, 0x00, 0x00, 0x3F, 0x80, 0x7F, 0x01, 0xB8, 0x00, 0x00, 0x00, 0x16, 0x00, 0x0D, 0x01, 0xA9, 0x00, 0x00, 0x00, 0x16, 0x80, 0x5E, 0x01, 0xAB, 0x00, 0x00, 0x00, 0x15, 0x00, 0x3F, 0x00, 0x45, 0x00, 0x00, 0x00, 0x15, 0x80, 0x37, 0x02, 0x3D, 0x00, 0x00, 0x00, 0x16, 0x00, 0x70, 0x00, 0x01, 0x01, 0x00, 0x00, 0x16, 0x80, 0x1F, 0x02, 0xFB, 0x00, 0x00, 0x00, 0x16, 0x80, 0x38, 0x01, 0x0A, 0x01, 0x00, 0x00, 0xE9, 0x00, 0x24, 0x01, 0x11, 0x01, 0x00, 0x00, 0x2E, 0x00, 0x49, 0x00, 0x62, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x14, 0x00, 0x6D, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x32, 0x02, 0x58, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x6A, 0x02, 0x64, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x26, 0x00, 0x3F, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x66, 0x00, 0x42, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x61, 0x02, 0x3F, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x23, 0x02, 0x40, 0x01, 0x00, 0x00, 0x3C, 0x80, 0xEB, 0x01, 0x43, 0x01, 0x00, 0x00, 0x3C, 0x80, 0xA3, 0x00, 0x41, 0x01, 0x00, 0x00, 0x3C, 0x80, 0xE1, 0x00, 0x40, 0x01, 0x00, 0x00, 0x3C, 0x80, 0xAB, 0x01, 0x40, 0x01, 0x00, 0x00, 0x3C, 0x00, 0x7A, 0x01, 0x41, 0x01, 0x00, 0x00, 0x3F, 0x00, 0x0F, 0x00, 0x77, 0x00, 0x00, 0x00, 0x3F, 0x00, 0xDF, 0x00, 0x53, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x28, 0x00, 0x76, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x54, 0x00, 0x6E, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x41, 0x00, 0x74, 0x00, 0x00, 0x00, 0x3F, 0x00, 0x74, 0x02, 0x6D, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xCC, 0x00, 0x31, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0xA2, 0x01, 0x36, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x85, 0x00, 0x57, 0x00, 0x00, 0x00, 0xE3, 0x1E, 0x3E, 0x00, 0x32, 0x01, 0x00, 0x00, 0xE3, 0x1E, 0x44, 0x02, 0x32, 0x01, 0x00, 0x00, 0xE3, 0x1E, 0xCC, 0x01, 0x32, 0x01, 0x00, 0x00, 0xE3, 0x1E, 0xB6, 0x00, 0x32, 0x01, 0x00, 0x00, 0x16, 0x80, 0xC0, 0x00, 0xAC, 0x00, 0x00, 0x00, 0x16, 0x00, 0xBA, 0x01, 0xA8, 0x00, 0x00, 0x00, 0x15, 0x80, 0x57, 0x01, 0xB9, 0x00, 0x00, 0x00, 0x8B, 0x0B, 0xEA, 0x01, 0xD7, 0x00, 0x00, 0x00, 0x8B, 0x8B, 0x96, 0x00, 0xD9, 0x00, 0x00, 0x00, 0xDF, 0x1E, 0x04, 0x00, 0x76, 0x00, 0x00, 0x00, 0xDF, 0x1E, 0x6D, 0x02, 0x6F, 0x00, 0x00, 0x00, 0x10, 0x00, 0x1D, 0x02, 0x6F, 0x00, 0x00, 0x00, 0x10, 0x80, 0x59, 0x00, 0x70, 0x00, 0x00, 0x00, 0xE4, 0x1E, 0x86, 0x01, 0x45, 0x00, 0x00, 0x00, 0xE4, 0x1E, 0xE7, 0x00, 0x47, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0x16, 0x00, 0x38, 0x4B, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0xDA, 0x13, 0x40, 0x01, 0xC6, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}