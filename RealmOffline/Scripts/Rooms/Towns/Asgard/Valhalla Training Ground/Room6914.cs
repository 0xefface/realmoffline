using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room6914 : Room
{
public Room6914()
: base(6914, "Valhalla Training Ground")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.GrassyBlueSky;
this.BlockedRoomExits = BlockedExits.DownLeftRight;
byte[] roomDecItems = { 0x7D, 0x97, 0x8A, 0x66, 0x02, 0xD7, 0x00, 0x00, 0x00, 0x73, 0x00, 0x44, 0x02, 0xDB, 0x00, 0x00, 0x00, 0x15, 0x80, 0x23, 0x02, 0x78, 0x00, 0x00, 0x00, 0x37, 0x06, 0x92, 0x01, 0xC9, 0x00, 0x00, 0x00, 0x15, 0x80, 0x5C, 0x02, 0xB3, 0x00, 0xEC, 0xFF, 0x16, 0x00, 0xDE, 0x00, 0x67, 0x00, 0xEC, 0xFF, 0xCA, 0x00, 0x16, 0x00, 0x33, 0x01, 0x00, 0x00, 0x16, 0x00, 0x83, 0x01, 0x63, 0x00, 0xEC, 0xFF, 0x16, 0x00, 0x36, 0x01, 0x22, 0x01, 0xEC, 0xFF, 0x14, 0x80, 0x40, 0x01, 0x6B, 0x00, 0x00, 0x00, 0x16, 0x00, 0x5C, 0x01, 0x68, 0x00, 0x00, 0x00, 0x42, 0x00, 0x14, 0x00, 0xB5, 0x00, 0x00, 0x00, 0x15, 0x00, 0x33, 0x00, 0x78, 0x00, 0xD8, 0xFF, 0x36, 0x06, 0x1F, 0x01, 0xC3, 0x00, 0x00, 0x00, 0x15, 0x00, 0x69, 0x02, 0x6E, 0x00, 0xEC, 0xFF, 0x15, 0x00, 0x69, 0x00, 0x79, 0x00, 0xEC, 0xFF, 0x42, 0x00, 0x65, 0x02, 0xB1, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x47, 0x01, 0xBF, 0x00, 0x00, 0x00, 0x38, 0x06, 0x51, 0x01, 0xC5, 0x00, 0x00, 0x00, 0xDF, 0x00, 0x58, 0x00, 0x38, 0x01, 0x00, 0x00, 0x15, 0x80, 0x8F, 0x01, 0x66, 0x00, 0xEC, 0xFF, 0xB9, 0x00, 0x52, 0x02, 0x88, 0x00, 0x00, 0x00, 0x15, 0x80, 0xF7, 0x01, 0x78, 0x00, 0x00, 0x00, 0xC8, 0x80, 0x65, 0x02, 0x30, 0x01, 0x00, 0x00, 0x39, 0x86, 0x0B, 0x01, 0xE6, 0x00, 0x00, 0x00, 0xDF, 0x00, 0x6C, 0x02, 0xDE, 0x00, 0x00, 0x00, 0x16, 0x80, 0xEA, 0x01, 0x70, 0x00, 0xEC, 0xFF, 0x99, 0x80, 0x7E, 0x01, 0x7F, 0x00, 0x00, 0x00, 0x15, 0x00, 0x89, 0x00, 0x7A, 0x00, 0x00, 0x00, 0x15, 0x80, 0x3E, 0x02, 0x65, 0x00, 0xD8, 0xFF, 0x73, 0x00, 0x6A, 0x01, 0x46, 0x01, 0xEC, 0xFF, 0xBE, 0x80, 0x5B, 0x02, 0x75, 0x00, 0x00, 0x00, 0xE8, 0x09, 0x9B, 0x00, 0x76, 0x00, 0x00, 0x00, 0x72, 0x00, 0x5E, 0x01, 0x79, 0x00, 0x00, 0x00, 0x15, 0x00, 0x4D, 0x02, 0x5D, 0x00, 0xEC, 0xFF, 0xEB, 0x09, 0x43, 0x01, 0x6F, 0x00, 0xF6, 0xFF, 0x72, 0x00, 0x20, 0x02, 0x39, 0x01, 0x00, 0x00, 0x9C, 0x00, 0x3E, 0x02, 0x93, 0x00, 0x00, 0x00, 0x73, 0x00, 0x39, 0x00, 0x3C, 0x01, 0x00, 0x00, 0xBE, 0x00, 0x2E, 0x00, 0x79, 0x00, 0x00, 0x00, 0xB9, 0x00, 0x32, 0x00, 0x91, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x46, 0x00, 0x94, 0x00, 0x00, 0x00, 0x73, 0x80, 0xC8, 0x01, 0x3C, 0x01, 0x00, 0x00, 0x72, 0x80, 0x5B, 0x02, 0x3A, 0x01, 0x00, 0x00, 0xB6, 0x0A, 0x6B, 0x00, 0x72, 0x00, 0x00, 0x00, 0xE8, 0x09, 0x0D, 0x02, 0x74, 0x00, 0x00, 0x00, 0x72, 0x00, 0xA7, 0x00, 0xC6, 0x00, 0x00, 0x00, 0xC3, 0x00, 0x44, 0x01, 0x5E, 0x00, 0xF1, 0xFF, 0xB6, 0x0A, 0xFA, 0x01, 0x6E, 0x00, 0x00, 0x00, 0x73, 0x00, 0x7D, 0x01, 0x7F, 0x00, 0x00, 0x00, 0x72, 0x00, 0xFB, 0x00, 0xBC, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x43, 0x01, 0x6D, 0x00, 0x00, 0x00, 0x39, 0x06, 0x6B, 0x01, 0xE5, 0x00, 0x00, 0x00, 0x36, 0x06, 0xE0, 0x01, 0xD0, 0x00, 0x00, 0x00, 0x37, 0x86, 0xFE, 0x01, 0xFA, 0x00, 0x00, 0x00, 0x37, 0x06, 0x71, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x37, 0x06, 0x94, 0x00, 0x03, 0x01, 0x00, 0x00, 0x3A, 0x06, 0x87, 0x01, 0xCF, 0x00, 0x00, 0x00, 0x37, 0x06, 0x80, 0x00, 0xFB, 0x00, 0x00, 0x00, 0x38, 0x06, 0x21, 0x01, 0x13, 0x01, 0x00, 0x00, 0x3A, 0x86, 0xF2, 0x00, 0xD2, 0x00, 0x00, 0x00, 0x38, 0x06, 0xEE, 0x00, 0x0D, 0x01, 0x00, 0x00, 0x3A, 0x86, 0x19, 0x01, 0xC7, 0x00, 0x00, 0x00, 0x37, 0x86, 0xFD, 0x01, 0xF4, 0x00, 0x00, 0x00, 0x36, 0x06, 0x94, 0x00, 0xD1, 0x00, 0x00, 0x00, 0x38, 0x06, 0x5D, 0x01, 0x10, 0x01, 0x00, 0x00, 0x38, 0x06, 0xF7, 0x01, 0xFD, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x43, 0x01, 0x89, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x42, 0x01, 0x82, 0x00, 0x00, 0x00, 0xEB, 0x00, 0xFD, 0x00, 0xC2, 0x00, 0x00, 0x00, 0xEB, 0x80, 0x87, 0x01, 0xC1, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x4D, 0x01, 0xA0, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x38, 0x01, 0x9F, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x37, 0x01, 0x9E, 0x00, 0x00, 0x00, 0x36, 0x06, 0xE9, 0x00, 0xC4, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x58, 0x01, 0xBB, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x2E, 0x01, 0xB2, 0x00, 0x00, 0x00, 0x36, 0x06, 0xA0, 0x01, 0x09, 0x01, 0x00, 0x00, 0x3A, 0x06, 0x49, 0x01, 0xC4, 0x00, 0x00, 0x00, 0x16, 0x00, 0xD4, 0x00, 0x66, 0x00, 0xEC, 0xFF, 0x16, 0x80, 0xFF, 0x00, 0x62, 0x00, 0xEC, 0xFF, 0x16, 0x80, 0xE7, 0x01, 0x66, 0x00, 0xEC, 0xFF, 0x15, 0x00, 0xC2, 0x01, 0x70, 0x00, 0x00, 0x00, 0x15, 0x00, 0x66, 0x02, 0xA2, 0x00, 0xC4, 0xFF, 0x15, 0x80, 0x4B, 0x02, 0x77, 0x00, 0xD8, 0xFF, 0x16, 0x00, 0x0E, 0x00, 0x85, 0x00, 0xD8, 0xFF, 0xF1, 0x00, 0xD0, 0x01, 0x14, 0x00, 0x00, 0x00, 0xF6, 0x00, 0xA0, 0x00, 0x16, 0x00, 0x00, 0x00, 0x15, 0x80, 0x09, 0x02, 0x53, 0x00, 0xEC, 0xFF, 0x16, 0x00, 0x36, 0x01, 0x22, 0x01, 0xEC, 0xFF, 0x73, 0x00, 0x1B, 0x01, 0x78, 0x00, 0x00, 0x00, 0x16, 0x00, 0x36, 0x01, 0x22, 0x01, 0xEC, 0xFF, 0x16, 0x00, 0x36, 0x01, 0x22, 0x01, 0xEC, 0xFF, 0x16, 0x00, 0x76, 0x02, 0xAD, 0x00, 0x00, 0x00, 0x16, 0x00, 0xBE, 0x01, 0x68, 0x00, 0x00, 0x00, 0x16, 0x00, 0xF2, 0x00, 0x6E, 0x00, 0x00, 0x00, 0x16, 0x00, 0x8E, 0x00, 0x6C, 0x00, 0x00, 0x00, 0x15, 0x00, 0x52, 0x00, 0x77, 0x00, 0x00, 0x00, 0x15, 0x00, 0x34, 0x00, 0x75, 0x00, 0xEC, 0xFF, 0x99, 0x00, 0x03, 0x01, 0x7E, 0x00, 0x00, 0x00, 0x73, 0x80, 0x05, 0x01, 0x7E, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x18, 0x00, 0xD1, 0x00, 0x00, 0x00, 0xDF, 0x00, 0x21, 0x00, 0xD2, 0x00, 0x00, 0x00, 0x16, 0x00, 0x36, 0x01, 0x22, 0x01, 0xEC, 0xFF, 0x15, 0x00, 0xA5, 0x00, 0x61, 0x00, 0xE2, 0xFF, 0x15, 0x80, 0x09, 0x02, 0x86, 0x00, 0x00, 0x00, 0x07, 0x00, 0x31, 0x00, 0x94, 0x00, 0x00, 0x00, 0x07, 0x00, 0x4D, 0x00, 0x94, 0x00, 0x00, 0x00, 0x07, 0x00, 0x61, 0x00, 0x94, 0x00, 0x00, 0x00, 0x07, 0x00, 0xF7, 0x00, 0x7F, 0x00, 0x00, 0x00, 0x07, 0x00, 0x0F, 0x01, 0x7F, 0x00, 0x00, 0x00, 0x07, 0x00, 0x79, 0x01, 0x81, 0x00, 0x00, 0x00, 0x07, 0x00, 0x90, 0x01, 0x81, 0x00, 0x00, 0x00, 0x07, 0x00, 0x29, 0x02, 0x93, 0x00, 0x00, 0x00, 0x07, 0x00, 0x42, 0x02, 0x93, 0x00, 0x00, 0x00, 0x07, 0x00, 0x5D, 0x02, 0x93, 0x00, 0x00, 0x00, 0xCC, 0x00, 0x36, 0x00, 0x35, 0x01, 0x00, 0x00, 0x72, 0x80, 0xD4, 0x01, 0xC5, 0x00, 0x00, 0x00, 0x97, 0x0A, 0x0E, 0x00, 0x3D, 0x01, 0x00, 0x00, 0x72, 0x80, 0x83, 0x01, 0xBB, 0x00, 0x00, 0x00, 0x97, 0x8A, 0x67, 0x02, 0x39, 0x01, 0x00, 0x00, 0xC9, 0x00, 0x53, 0x02, 0x38, 0x01, 0x00, 0x00, 0x73, 0x00, 0x86, 0x00, 0x30, 0x01, 0xF6, 0xFF, 0xE2, 0x1E, 0x8B, 0x02, 0x42, 0x01, 0x00, 0x00, 0xE2, 0x1E, 0x02, 0x00, 0x38, 0x01, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
byte[] roomItems = { 0x04, 0x00, 0x01, 0xB9, 0x07, 0x27, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x02, 0x1B, 0xA5, 0x00, 0xC7, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x28, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x02, 0x1B, 0xDD, 0x01, 0xC7, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x29, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x02, 0x1B, 0xF6, 0x00, 0xBD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xB9, 0x07, 0x2A, 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x01, 0x02, 0x1B, 0x8D, 0x01, 0xBD, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x98 };

this.AddRoomItemsByteBlock(roomItems);
base.ApplyRoomLayout();
}
}
}
