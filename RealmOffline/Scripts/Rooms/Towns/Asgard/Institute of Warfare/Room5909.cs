using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5909 : Room
{
public Room5909()
: base(5909, "Institute of Warfare")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x39, 0xC5, 0x09, 0x87, 0x00, 0x1D, 0x00, 0x00, 0x00, 0x15, 0x0A, 0xA0, 0x01, 0x82, 0x00, 0xEC, 0xFF, 0xD8, 0x09, 0x15, 0x01, 0x10, 0x00, 0x00, 0x00, 0xC8, 0x09, 0x7D, 0x01, 0x25, 0x00, 0x32, 0x00, 0x15, 0x0A, 0x66, 0x00, 0x87, 0x00, 0xEC, 0xFF, 0xD9, 0x09, 0x62, 0x02, 0x78, 0x00, 0x00, 0x00, 0x35, 0x8A, 0x33, 0x02, 0x7F, 0x00, 0x00, 0x00, 0x96, 0x0A, 0x6A, 0x01, 0x2F, 0x00, 0x00, 0x00, 0x14, 0x0A, 0xC8, 0x00, 0x86, 0x00, 0xEC, 0xFF, 0x36, 0x8A, 0x70, 0x02, 0x45, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x72, 0x00, 0xB5, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x81, 0x00, 0xC2, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xE7, 0x01, 0xCA, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0xA7, 0x00, 0xC6, 0x00, 0x00, 0x00, 0x9D, 0x0A, 0x90, 0x01, 0xBB, 0x00, 0x00, 0x00, 0x9D, 0x8A, 0x4D, 0x02, 0xD0, 0x00, 0x00, 0x00, 0x8D, 0x0A, 0x76, 0x01, 0x9C, 0x00, 0x40, 0x00, 0x9B, 0x8A, 0x88, 0x00, 0x8F, 0x00, 0xE2, 0xFF, 0x9A, 0x0A, 0x98, 0x00, 0xB2, 0x00, 0x14, 0x00, 0x9B, 0x0A, 0xF0, 0x01, 0x95, 0x00, 0xE2, 0xFF, 0x99, 0x0A, 0x2B, 0x02, 0xAD, 0x00, 0x14, 0x00, 0x03, 0x00, 0x76, 0x02, 0xC3, 0x00, 0x00, 0x00, 0x03, 0x00, 0x31, 0x02, 0xC8, 0x00, 0x00, 0x00, 0x3D, 0x0A, 0xBB, 0x02, 0x79, 0x00, 0x00, 0x00, 0x42, 0x0A, 0x34, 0x00, 0x42, 0x00, 0x00, 0x00, 0x03, 0x00, 0x5C, 0x00, 0xB2, 0x00, 0x00, 0x00, 0x03, 0x00, 0xD7, 0x00, 0xBB, 0x00, 0x00, 0x00, 0x03, 0x00, 0x60, 0x01, 0xA8, 0x00, 0x00, 0x00, 0x35, 0x0A, 0xBB, 0x00, 0x4F, 0x00, 0x00, 0x00, 0x10, 0x80, 0xE4, 0x00, 0x34, 0x00, 0x00, 0x00, 0x32, 0x86, 0x3F, 0x00, 0x1C, 0x01, 0x00, 0x00, 0x32, 0x86, 0x09, 0x00, 0x02, 0x00, 0x00, 0x00, 0x32, 0x86, 0xED, 0xFF, 0x38, 0x00, 0x00, 0x00, 0x32, 0x86, 0x20, 0x00, 0x0F, 0x01, 0x00, 0x00, 0x32, 0x86, 0xFC, 0xFF, 0x00, 0x01, 0x00, 0x00, 0x33, 0x06, 0x66, 0x00, 0xFC, 0x00, 0x00, 0x00, 0xFB, 0x05, 0x23, 0x00, 0x3B, 0x01, 0x00, 0x00, 0x00, 0x06, 0x3E, 0x00, 0x41, 0x00, 0x00, 0x00, 0x33, 0x06, 0x15, 0x00, 0x54, 0x00, 0x00, 0x00, 0x32, 0x06, 0x0C, 0x00, 0xEA, 0x00, 0x00, 0x00, 0x32, 0x86, 0x10, 0x00, 0xD1, 0x00, 0x00, 0x00, 0xF0, 0x05, 0x42, 0x00, 0x40, 0x01, 0x00, 0x00, 0x33, 0x86, 0x3D, 0x00, 0xA1, 0x00, 0x00, 0x00, 0x33, 0x86, 0x85, 0x00, 0xAE, 0x00, 0x00, 0x00, 0x32, 0x86, 0x50, 0x01, 0xAD, 0x00, 0x00, 0x00, 0x32, 0x86, 0xAE, 0x00, 0x1B, 0x01, 0x00, 0x00, 0x34, 0x06, 0xC8, 0x00, 0xBF, 0x00, 0x00, 0x00, 0x34, 0x06, 0x49, 0x01, 0xAF, 0x00, 0x00, 0x00, 0x34, 0x86, 0xFB, 0x00, 0xB9, 0x00, 0x00, 0x00, 0x10, 0x00, 0xFB, 0x01, 0xE0, 0x00, 0x00, 0x00, 0x24, 0x0A, 0xAE, 0x01, 0x8B, 0x00, 0x00, 0x00, 0x23, 0x0A, 0xD4, 0x00, 0x92, 0x00, 0x00, 0x00, 0x24, 0x0A, 0x75, 0x00, 0x8F, 0x00, 0x00, 0x00, 0x10, 0x00, 0xE2, 0x00, 0xDC, 0x00, 0x00, 0x00, 0x10, 0x80, 0x79, 0x00, 0xE0, 0x00, 0x00, 0x00, 0x03, 0x00, 0x01, 0x02, 0xCA, 0x00, 0x00, 0x00, 0x03, 0x00, 0x19, 0x02, 0xCA, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xD9, 0x02, 0x33, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x15, 0x17, 0x32, 0x01, 0xB4, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}