using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6913 : Room
{
public Room6913()
: base(6913, "Valhalla Hall")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PlainDirt;
this.BlockedRoomExits = BlockedExits.UpLeftRight;
byte[] roomDecItems = { 0x83, 0x1A, 0x0A, 0x61, 0x00, 0xA4, 0x00, 0x1E, 0x00, 0x25, 0x0A, 0x04, 0x02, 0x80, 0x00, 0x14, 0x00, 0xD5, 0x09, 0x2D, 0x00, 0x10, 0x00, 0x00, 0x00, 0x23, 0x0A, 0x48, 0x00, 0x92, 0x00, 0x1E, 0x00, 0x25, 0x0A, 0xFE, 0x00, 0x80, 0x00, 0x14, 0x00, 0xD5, 0x09, 0x8A, 0x00, 0x01, 0x00, 0x00, 0x00, 0xD6, 0x09, 0x5C, 0x00, 0x2A, 0x00, 0x00, 0x00, 0xDD, 0x09, 0xED, 0x00, 0x0E, 0x00, 0x00, 0x00, 0xDE, 0x09, 0x9C, 0x01, 0x13, 0x00, 0x00, 0x00, 0xDE, 0x09, 0x12, 0x02, 0x13, 0x00, 0x00, 0x00, 0xDD, 0x09, 0x65, 0x02, 0x0E, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x77, 0x00, 0xA5, 0x00, 0x00, 0x00, 0xCB, 0x0A, 0xA0, 0x01, 0x5C, 0x00, 0x00, 0x00, 0xDE, 0x09, 0x3B, 0x01, 0x13, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0xA1, 0x00, 0xB0, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x8E, 0x00, 0xB4, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x7A, 0x00, 0xB1, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x65, 0x00, 0xB3, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x3D, 0x00, 0xB9, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x53, 0x00, 0xB4, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x2B, 0x00, 0xC3, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x16, 0x00, 0xC8, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x01, 0x00, 0xCD, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x00, 0x00, 0x9A, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0xA1, 0x00, 0x4D, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x8E, 0x00, 0x80, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x77, 0x00, 0x8D, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0xA3, 0x00, 0x7E, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x12, 0x00, 0x92, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x77, 0x00, 0x59, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x8D, 0x00, 0x5D, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0xA0, 0x00, 0x2B, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x27, 0x00, 0xA3, 0x00, 0x00, 0x00, 0x1C, 0x0A, 0xF4, 0x01, 0x9C, 0x00, 0x14, 0x00, 0x1C, 0x0A, 0xEE, 0x00, 0x9C, 0x00, 0x14, 0x00, 0xCB, 0x8A, 0x8B, 0x01, 0x5C, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0xFE, 0xFF, 0x68, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x28, 0x00, 0x6F, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x63, 0x00, 0x7A, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x3B, 0x00, 0x5A, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x4F, 0x00, 0x59, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x63, 0x00, 0x3B, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x8C, 0x00, 0x3A, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x14, 0x00, 0x72, 0x00, 0x00, 0x00, 0xC6, 0x0A, 0x25, 0x00, 0x41, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x12, 0x00, 0x3E, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0xFF, 0xFF, 0x35, 0x00, 0x00, 0x00, 0xC4, 0x0A, 0x76, 0x00, 0x2C, 0x00, 0x00, 0x00, 0xC3, 0x0A, 0x4E, 0x00, 0x2B, 0x00, 0x00, 0x00, 0xC5, 0x0A, 0x3B, 0x00, 0x34, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x2F, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x17, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x32, 0x01, 0x7A, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x34, 0x01, 0x9F, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xB3, 0x01, 0xAF, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x5E, 0x01, 0xAD, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x49, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x5D, 0x01, 0x7F, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x45, 0x01, 0x7E, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x5B, 0x01, 0x4E, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x48, 0x01, 0x53, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xBA, 0x01, 0x7A, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xB1, 0x01, 0x57, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xCC, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0xCF, 0x01, 0x7A, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xE5, 0x01, 0x7E, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xC7, 0x01, 0x48, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xE4, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0xFB, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x01, 0x01, 0xAE, 0x00, 0xFD, 0xFF, 0xC7, 0x0A, 0xB7, 0x00, 0xAE, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x10, 0x02, 0xAE, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0xB7, 0x00, 0x77, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xB8, 0x00, 0x44, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xCE, 0x00, 0x79, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xD0, 0x00, 0xAD, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0xEA, 0x00, 0xAE, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xE7, 0x00, 0x92, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xE6, 0x00, 0x5D, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xCE, 0x00, 0x45, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x09, 0x01, 0x3C, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xF9, 0x00, 0x3F, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x18, 0x01, 0x40, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x47, 0x01, 0x3E, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x31, 0x01, 0x3A, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0xE5, 0x00, 0x31, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0xE0, 0x01, 0x36, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0xFA, 0x01, 0x3C, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x28, 0x02, 0xAD, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x12, 0x02, 0x40, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x25, 0x02, 0x3E, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x3C, 0x02, 0xAC, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x3C, 0x02, 0x9F, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x3A, 0x02, 0x6D, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x51, 0x02, 0x8C, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x6A, 0x02, 0xAC, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x4F, 0x02, 0x58, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x54, 0x02, 0xAD, 0x00, 0x00, 0x00, 0xC7, 0x0A, 0x68, 0x02, 0x7A, 0x00, 0x00, 0x00, 0xC8, 0x0A, 0x3C, 0x02, 0x3C, 0x00, 0x00, 0x00, 0xC9, 0x0A, 0x51, 0x02, 0x25, 0x00, 0x00, 0x00, 0xCA, 0x0A, 0x66, 0x02, 0x45, 0x00, 0x00, 0x00, 0x47, 0x0A, 0x32, 0x02, 0x49, 0x00, 0x28, 0x00, 0x47, 0x0A, 0xFF, 0x00, 0x48, 0x00, 0x28, 0x00, 0x49, 0x0A, 0xAA, 0x01, 0x53, 0x00, 0x32, 0x00, 0x49, 0x0A, 0x48, 0x01, 0x53, 0x00, 0x32, 0x00, 0x47, 0x0A, 0x38, 0x02, 0xAF, 0x00, 0x00, 0x00, 0x47, 0x0A, 0x00, 0x01, 0xB0, 0x00, 0x00, 0x00, 0x49, 0x0A, 0x36, 0x01, 0xB1, 0x00, 0x00, 0x00, 0x49, 0x0A, 0xF8, 0x01, 0xB0, 0x00, 0x00, 0x00, 0x3F, 0x0A, 0xF2, 0xFF, 0xCF, 0x00, 0x00, 0x00, 0x3F, 0x0A, 0xD4, 0xFF, 0x73, 0x00, 0x32, 0x00, 0x40, 0x0A, 0x33, 0x00, 0xC3, 0x00, 0x00, 0x00, 0x40, 0x0A, 0x31, 0x00, 0x5A, 0x00, 0x28, 0x00, 0x35, 0x08, 0xB4, 0x00, 0xF2, 0x00, 0x00, 0x00, 0x0E, 0x80, 0x56, 0x00, 0xD9, 0x00, 0x00, 0x00, 0x0E, 0x80, 0xE9, 0xFF, 0xEB, 0x00, 0x00, 0x00, 0x58, 0x0A, 0x55, 0x00, 0x02, 0x01, 0xF6, 0xFF, 0x59, 0x0A, 0x77, 0x00, 0xFC, 0x00, 0xF6, 0xFF, 0x5A, 0x0A, 0xB1, 0x00, 0xF3, 0x00, 0xF6, 0xFF, 0xE2, 0x00, 0x4B, 0x01, 0x2C, 0x01, 0x00, 0x00, 0x6E, 0x0A, 0x0E, 0x00, 0x03, 0x01, 0xF6, 0xFF, 0x39, 0x08, 0x42, 0x00, 0x00, 0x01, 0x00, 0x00, 0xDC, 0x1E, 0x3C, 0x02, 0xB7, 0x00, 0x00, 0x00, 0xDC, 0x1E, 0xE5, 0x00, 0xB7, 0x00, 0x00, 0x00, 0xE2, 0x00, 0x97, 0x01, 0xA8, 0x00, 0x00, 0x00, 0x03, 0x00, 0xE9, 0x00, 0xAF, 0x00, 0x00, 0x00, 0x03, 0x00, 0x83, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x03, 0x00, 0x57, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x52, 0x0A, 0xAC, 0x00, 0xB1, 0x00, 0x00, 0x00, 0x51, 0x0A, 0xAC, 0x00, 0x65, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x05, 0x00, 0x01, 0xDC, 0x02, 0xBF, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x01, 0x1B, 0x94, 0x01, 0xB3, 0x00, 0x02, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC0, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x01, 0x1B, 0x80, 0x00, 0xDF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x07, 0xC1, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x01, 0x1B, 0x54, 0x01, 0xB3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x07, 0xC2, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x01, 0x1B, 0xD6, 0x01, 0xB6, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xE0, 0x02, 0xC3, 0x48, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x01, 0x1B, 0x1B, 0x00, 0x18, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xF0, 0xFE };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
