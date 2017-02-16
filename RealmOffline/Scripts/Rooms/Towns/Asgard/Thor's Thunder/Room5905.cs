using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room5905 : Room
{
public Room5905()
: base(5905, "Thor's Thunder")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.None;
byte[] roomDecItems = { 0x4A, 0xC5, 0x09, 0x67, 0x01, 0x34, 0x00, 0x00, 0x00, 0xC6, 0x09, 0x10, 0x01, 0x35, 0x00, 0x00, 0x00, 0xC5, 0x09, 0xCF, 0x00, 0x1C, 0x00, 0x00, 0x00, 0xD1, 0x09, 0xC8, 0x01, 0x35, 0x00, 0x00, 0x00, 0xD2, 0x09, 0xEA, 0x01, 0x3B, 0x00, 0x00, 0x00, 0x59, 0x0A, 0xB7, 0x01, 0x3C, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0xCC, 0x00, 0x90, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x59, 0x01, 0xBD, 0x00, 0x14, 0x00, 0x67, 0x0A, 0x59, 0x01, 0xD5, 0x00, 0x00, 0x00, 0x51, 0x0A, 0xBF, 0x01, 0x7E, 0x00, 0x00, 0x00, 0x51, 0x0A, 0xFC, 0x01, 0x79, 0x00, 0x00, 0x00, 0x2A, 0x0A, 0xDD, 0x00, 0x42, 0x00, 0x00, 0x00, 0x60, 0x0A, 0x96, 0x01, 0xBC, 0x00, 0xE4, 0xFF, 0x5B, 0x0A, 0x8C, 0x01, 0x5B, 0x00, 0x00, 0x00, 0x5D, 0x0A, 0xF4, 0x01, 0xC2, 0x00, 0x00, 0x00, 0x5E, 0x0A, 0xF5, 0x01, 0x64, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0x94, 0x00, 0x48, 0x00, 0x00, 0x00, 0x3C, 0x86, 0xF4, 0x01, 0xDA, 0x00, 0x00, 0x00, 0x29, 0x0A, 0x98, 0x01, 0x94, 0x01, 0x32, 0x01, 0x6C, 0x0A, 0x02, 0x01, 0xD1, 0x00, 0x74, 0x00, 0x6C, 0x0A, 0xCA, 0x00, 0xC6, 0x00, 0x74, 0x00, 0x29, 0x0A, 0x2F, 0x01, 0x04, 0x01, 0xB3, 0x00, 0x6D, 0x0A, 0x07, 0x01, 0x91, 0x00, 0x2D, 0x00, 0x6D, 0x0A, 0xD7, 0x00, 0x5D, 0x01, 0x00, 0x00, 0xEE, 0x09, 0x78, 0x02, 0xAC, 0x00, 0x00, 0x00, 0x6F, 0x00, 0x90, 0x00, 0xBD, 0x00, 0x00, 0x00, 0x31, 0x00, 0x9F, 0x00, 0xBC, 0x00, 0x00, 0x00, 0x29, 0x0A, 0x78, 0x02, 0xB4, 0x00, 0x8E, 0x00, 0xD3, 0x09, 0xFE, 0x01, 0x14, 0x00, 0x00, 0x00, 0x65, 0x0A, 0x2D, 0x01, 0xB0, 0x00, 0x14, 0x00, 0x15, 0x0A, 0xF8, 0x00, 0x99, 0x00, 0x00, 0x00, 0x67, 0x0A, 0x2D, 0x01, 0xCE, 0x00, 0x00, 0x00, 0x5D, 0x0A, 0xE7, 0x01, 0x5E, 0x00, 0x31, 0x00, 0x6E, 0x0A, 0x09, 0x01, 0x5E, 0x00, 0x00, 0x00, 0x5E, 0x0A, 0xB6, 0x01, 0x3C, 0x00, 0x00, 0x00, 0x6C, 0x0A, 0xA0, 0x00, 0xC5, 0x00, 0x00, 0x00, 0x6D, 0x0A, 0xD3, 0x00, 0xD5, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0x56, 0x01, 0xE5, 0x00, 0x00, 0x00, 0x6D, 0x0A, 0x0F, 0x01, 0xDF, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0x56, 0x01, 0x6C, 0x00, 0x00, 0x00, 0x65, 0x0A, 0xF6, 0x00, 0xB6, 0x00, 0x1F, 0x00, 0x67, 0x0A, 0xF7, 0x00, 0xCB, 0x00, 0x00, 0x00, 0x6F, 0x0A, 0xA0, 0x00, 0x7A, 0x00, 0x00, 0x00, 0x6E, 0x0A, 0x18, 0x01, 0x9C, 0x00, 0x00, 0x00, 0x71, 0x0A, 0x5D, 0x01, 0xD5, 0x00, 0xFC, 0xFF, 0x72, 0x0A, 0x5C, 0x01, 0x98, 0x00, 0x00, 0x00, 0x74, 0x0A, 0xA1, 0x00, 0xA3, 0x00, 0xF6, 0xFF, 0x6D, 0x0A, 0xDC, 0x00, 0x99, 0x00, 0x00, 0x00, 0x67, 0x0A, 0xCD, 0x00, 0xB6, 0x00, 0x00, 0x00, 0x65, 0x0A, 0xCD, 0x00, 0xAF, 0x00, 0x1F, 0x00, 0x02, 0x06, 0x2D, 0x02, 0xD1, 0x00, 0x00, 0x00, 0x32, 0x06, 0x4F, 0x02, 0xC8, 0x00, 0x00, 0x00, 0x3C, 0x06, 0xFC, 0x01, 0xCE, 0x00, 0x00, 0x00, 0x3C, 0x06, 0xE1, 0x01, 0xD3, 0x00, 0x00, 0x00, 0xF1, 0x85, 0x8D, 0x01, 0xE9, 0x00, 0x00, 0x00, 0xF2, 0x05, 0x4C, 0x01, 0xDE, 0x00, 0x00, 0x00, 0xF0, 0x85, 0x52, 0x01, 0xE8, 0x00, 0x00, 0x00, 0xF0, 0x05, 0xBE, 0x00, 0x14, 0x00, 0x6B, 0xFF, 0x33, 0x06, 0x2B, 0x00, 0x97, 0x00, 0x00, 0x00, 0x33, 0x06, 0x12, 0x02, 0xD3, 0x00, 0x00, 0x00, 0x33, 0x86, 0x33, 0x02, 0xC9, 0x00, 0x00, 0x00, 0x34, 0x06, 0x52, 0x00, 0xBA, 0x00, 0x00, 0x00, 0x31, 0x06, 0x76, 0x00, 0x09, 0x01, 0x00, 0x00, 0x31, 0x86, 0x00, 0x00, 0x5E, 0x00, 0x00, 0x00, 0x31, 0x86, 0x1A, 0x00, 0x71, 0x00, 0x00, 0x00, 0x32, 0x06, 0x87, 0x01, 0xCF, 0x00, 0x00, 0x00, 0xFA, 0x09, 0x78, 0x02, 0xAD, 0x00, 0x05, 0x00, 0x10, 0x00, 0x5E, 0x01, 0xEB, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x94, 0x02, 0xE8, 0x00, 0x00, 0x00, 0x33, 0x06, 0x49, 0x00, 0x58, 0x00, 0x00, 0x00, 0x01, 0x06, 0x07, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x33, 0x06, 0x50, 0x01, 0xD0, 0x00, 0x00, 0x00, 0xC5, 0x09, 0x56, 0x02, 0x2A, 0x00, 0x00, 0x00, 0x29, 0x0A, 0x91, 0x02, 0xC5, 0x00, 0x8E, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x01, 0x00, 0x01, 0xDB, 0x02, 0x28, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x11, 0x17, 0xE1, 0x01, 0xD7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
