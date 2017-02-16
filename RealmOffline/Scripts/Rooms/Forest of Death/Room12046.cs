using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room12046 : Room
{
public Room12046()
: base(12046, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
byte[] roomDecItems = { 0x3E, 0xB7, 0x0A, 0x60, 0x01, 0x7F, 0x00, 0x00, 0x00, 0xA8, 0x80, 0x76, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x33, 0x01, 0x83, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x34, 0x00, 0x81, 0x00, 0x00, 0x00, 0x9A, 0x80, 0x3E, 0x02, 0x87, 0x00, 0x00, 0x00, 0x99, 0x00, 0x9A, 0x01, 0x84, 0x00, 0x00, 0x00, 0x99, 0x80, 0x6A, 0x01, 0x85, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xE4, 0x01, 0x86, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x71, 0x00, 0x81, 0x00, 0x00, 0x00, 0x9C, 0x80, 0xEA, 0x00, 0x84, 0x00, 0x00, 0x00, 0x9C, 0x00, 0xA8, 0x00, 0x82, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x6D, 0x02, 0x86, 0x00, 0x00, 0x00, 0x30, 0x00, 0x5A, 0x02, 0x01, 0x01, 0x00, 0x00, 0x31, 0x80, 0x08, 0x02, 0xDE, 0x00, 0x00, 0x00, 0x73, 0x00, 0xB2, 0x00, 0x1C, 0x01, 0x00, 0x00, 0x72, 0x00, 0x9B, 0x00, 0x1B, 0x01, 0x00, 0x00, 0x32, 0x00, 0x25, 0x01, 0xF6, 0x00, 0x00, 0x00, 0x31, 0x00, 0x27, 0x00, 0xD0, 0x00, 0x00, 0x00, 0x88, 0x0B, 0xB3, 0x01, 0xD6, 0x00, 0x00, 0x00, 0xCB, 0x00, 0x76, 0x02, 0xEF, 0x01, 0x00, 0x00, 0x2D, 0x00, 0xCC, 0x00, 0xF1, 0x00, 0x00, 0x00, 0x5D, 0x00, 0x4E, 0x01, 0x68, 0x00, 0x00, 0x00, 0x64, 0x00, 0x5E, 0x00, 0x43, 0x01, 0x00, 0x00, 0x64, 0x00, 0x47, 0x01, 0x5D, 0x01, 0x00, 0x00, 0x64, 0x00, 0x17, 0x02, 0x40, 0x01, 0x00, 0x00, 0x64, 0x00, 0x15, 0x00, 0x13, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xD8, 0x00, 0x01, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x30, 0x01, 0x05, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xC1, 0x00, 0xED, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x0A, 0x01, 0xFB, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xC0, 0x01, 0xE0, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x12, 0x02, 0xE7, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x6B, 0x02, 0x10, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x55, 0x02, 0xFD, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x09, 0x02, 0xDD, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xBA, 0x01, 0xD4, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x34, 0x00, 0xD8, 0x00, 0x00, 0x00, 0x3E, 0x00, 0xEC, 0x00, 0xEA, 0x00, 0x00, 0x00, 0x3E, 0x00, 0xB4, 0x00, 0x19, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x95, 0x01, 0xE8, 0x00, 0x00, 0x00, 0x3E, 0x00, 0xDD, 0x01, 0xDA, 0x00, 0x00, 0x00, 0x3E, 0x00, 0xA3, 0x01, 0x29, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x42, 0x00, 0xE5, 0x00, 0x00, 0x00, 0x3E, 0x00, 0x16, 0x02, 0x05, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x36, 0x01, 0x22, 0x01, 0x00, 0x00, 0xB9, 0x00, 0xBA, 0x01, 0xF9, 0x00, 0x00, 0x00, 0x05, 0x00, 0x46, 0x00, 0x80, 0x00, 0x00, 0x00, 0x05, 0x00, 0x60, 0x00, 0x80, 0x00, 0x00, 0x00, 0x05, 0x00, 0x76, 0x00, 0x80, 0x00, 0x00, 0x00, 0x05, 0x00, 0x8E, 0x00, 0x81, 0x00, 0x00, 0x00, 0x05, 0x00, 0xA6, 0x00, 0x80, 0x00, 0x00, 0x00, 0x05, 0x00, 0xFF, 0x00, 0x83, 0x00, 0x00, 0x00, 0x05, 0x00, 0x1A, 0x01, 0x82, 0x00, 0x00, 0x00, 0x05, 0x00, 0x5B, 0x01, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0x72, 0x01, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0x44, 0x01, 0x82, 0x00, 0x00, 0x00, 0x05, 0x00, 0x93, 0x01, 0x83, 0x00, 0x00, 0x00, 0x05, 0x00, 0xD1, 0x01, 0x86, 0x00, 0x00, 0x00, 0x05, 0x00, 0xE8, 0x01, 0x86, 0x00, 0x00, 0x00, 0x05, 0x00, 0x29, 0x02, 0x87, 0x00, 0x00, 0x00, 0x05, 0x00, 0x41, 0x02, 0x88, 0x00, 0x00, 0x00, 0x05, 0x00, 0x75, 0x02, 0x85, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}