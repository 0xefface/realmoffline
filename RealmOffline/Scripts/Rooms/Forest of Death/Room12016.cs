using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealmOffline.Core.Rooms;
using Scripts.Rooms.RoomDecorations;
namespace Scripts.Rooms
{
public class Room12016 : Room
{
public Room12016()
: base(12016, "Forest of Death")
{ }
public override void ApplyRoomLayout()
{
this.Background = RoomBackground.PatchyGrassyBlueSky0;
byte[] roomDecItems = { 0x45, 0xB7, 0x0A, 0x4D, 0x00, 0x7C, 0x00, 0x00, 0x00, 0xB7, 0x0A, 0x3D, 0x02, 0x89, 0x00, 0x00, 0x00, 0xA8, 0x00, 0x2E, 0x01, 0x83, 0x00, 0x00, 0x00, 0x9A, 0x00, 0xF7, 0x01, 0x8E, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x74, 0x02, 0x90, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x8F, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x99, 0x00, 0x3D, 0x02, 0x96, 0x00, 0x00, 0x00, 0x99, 0x00, 0xC8, 0x00, 0x88, 0x00, 0x00, 0x00, 0x9A, 0x80, 0x1A, 0x01, 0x87, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x79, 0x01, 0x91, 0x00, 0x00, 0x00, 0x9C, 0x00, 0xCB, 0x01, 0x87, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x4A, 0x00, 0x83, 0x00, 0x00, 0x00, 0x9C, 0x00, 0x1C, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x30, 0x00, 0x23, 0x00, 0xCD, 0x00, 0x00, 0x00, 0x31, 0x80, 0x20, 0x01, 0xF5, 0x00, 0x00, 0x00, 0x88, 0x0B, 0x62, 0x02, 0x41, 0x01, 0x00, 0x00, 0x73, 0x00, 0x3F, 0x02, 0xFE, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x01, 0x02, 0x47, 0x01, 0x00, 0x00, 0x32, 0x00, 0x4D, 0x00, 0xBA, 0x00, 0x00, 0x00, 0x31, 0x00, 0x90, 0x00, 0xF5, 0x00, 0x00, 0x00, 0x88, 0x0B, 0xAB, 0x01, 0xDF, 0x00, 0x00, 0x00, 0xCC, 0x00, 0x5F, 0x00, 0xBA, 0x00, 0x00, 0x00, 0x2D, 0x00, 0x49, 0x02, 0xFF, 0x00, 0x00, 0x00, 0x5D, 0x00, 0x4E, 0x01, 0x68, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x58, 0x01, 0xEB, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x51, 0x01, 0x6A, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xBF, 0x01, 0xE6, 0x00, 0x00, 0x00, 0x3E, 0x00, 0xDA, 0x01, 0xDE, 0x00, 0x00, 0x00, 0xC7, 0x04, 0xA6, 0x01, 0xD7, 0x00, 0x00, 0x00, 0xB9, 0x00, 0x8E, 0x00, 0x0E, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xE8, 0x00, 0x05, 0x01, 0x00, 0x00, 0x73, 0x00, 0x27, 0x02, 0x4C, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x88, 0x00, 0xEC, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x28, 0x00, 0xCD, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x3F, 0x00, 0xCD, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x20, 0x00, 0xC7, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x57, 0x00, 0xC4, 0x00, 0x00, 0x00, 0xC7, 0x04, 0x3D, 0x02, 0x07, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x5A, 0x02, 0x0A, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x62, 0x02, 0x3E, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x44, 0x02, 0x48, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x7C, 0x02, 0x4D, 0x01, 0x00, 0x00, 0x3E, 0x00, 0x32, 0x00, 0xC4, 0x00, 0x00, 0x00, 0x3E, 0x80, 0xD3, 0x00, 0xF1, 0x00, 0x00, 0x00, 0xE1, 0x80, 0x1F, 0x01, 0x2C, 0x01, 0x00, 0x00, 0xE1, 0x00, 0xFE, 0x00, 0x33, 0x01, 0x00, 0x00, 0xC7, 0x04, 0xB9, 0x01, 0x65, 0x01, 0x00, 0x00, 0xC7, 0x04, 0x1C, 0x02, 0x33, 0x01, 0x00, 0x00, 0xE1, 0x00, 0x11, 0x01, 0x18, 0x01, 0x00, 0x00, 0xE1, 0x80, 0xE0, 0x00, 0x2B, 0x01, 0x00, 0x00, 0xE1, 0x00, 0x2D, 0x01, 0x0F, 0x01, 0x00, 0x00, 0xE1, 0x00, 0xF8, 0x00, 0x20, 0x01, 0x00, 0x00, 0xE9, 0x00, 0x3E, 0x01, 0xAE, 0x00, 0x00, 0x00, 0xE9, 0x80, 0x4F, 0x01, 0x82, 0x00, 0x00, 0x00, 0x05, 0x00, 0xAF, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0xC6, 0x00, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0xD8, 0x00, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0x74, 0x00, 0x8B, 0x00, 0x00, 0x00, 0x05, 0x00, 0xFE, 0x00, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0x14, 0x01, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0x36, 0x01, 0x86, 0x00, 0x00, 0x00, 0x05, 0x00, 0x64, 0x01, 0x90, 0x00, 0x00, 0x00, 0x05, 0x00, 0x7B, 0x01, 0x90, 0x00, 0x00, 0x00, 0x05, 0x00, 0x93, 0x01, 0x90, 0x00, 0x00, 0x00, 0x05, 0x00, 0xCA, 0x01, 0x85, 0x00, 0x00, 0x00, 0x05, 0x00, 0xDB, 0x01, 0x8D, 0x00, 0x00, 0x00, 0x05, 0x00, 0xF1, 0x01, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x08, 0x02, 0x8C, 0x00, 0x00, 0x00, 0x05, 0x00, 0x1F, 0x02, 0x8D, 0x00, 0x00, 0x00 };

this.AddDecorationsByteBlock(roomDecItems);
base.ApplyRoomLayout();
}
}
}
