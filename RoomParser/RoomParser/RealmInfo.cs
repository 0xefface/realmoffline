using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.IO;

namespace RoomParser
{
    #region HardCoded Backgrounds
    public enum RoomBackground : ushort
    {
        GrassyBlueSky = 3000,
        PatchyGrassyBlueSky0 = 3001,
        PatchyGrassyBlueSky1 = 3009,
        DesertBrightBlueSky = 3030,
        BeachLeft = 3031,
        BeachTop = 3032,
        GloomyDesert = 3033,
        GloomyBeachLeft = 3034,
        GloomyBeachTop = 3035,
        BrightSnowyGrass = 3050,
        BrightSnowyPatchyGrass = 3051,
        SnowyDesert = 3052,
        DarkCave = 3071,
        LongGrassySunnyDay = 3201,
        PavedRoom0 = 3300,
        DesertBreezeRight = 3404,
        DesertBreezeLeft = 3405,
        EvilDesertBreezeLeft = 3406,
        EvilDesertBreezeRight = 3407,
        EvilDesertStill0 = 3408,
        EvilDesertStill1 = 3409,
        PlainDirt = 3500,
        EvilPlainDirt = 3501,
        PavedRoom1 = 4000,
        InnerTent = 4001,
        Swamp = 6500
    }
    #endregion
    #region Blocked Exits
    public enum BlockedExits : byte
    {
        All = 0x00,
        DownLeftRight = 0x01,
        UpLeftRight = 0x02,
        LeftRight = 0x03,
        UpDownLeft = 0x04,
        DownLeft = 0x05,
        UpLeft = 0x06,
        Left = 0x07,
        UpDownRight = 0x08,
        DownRight = 0x09,
        UpRight = 0x0A,
        Right = 0x0B,
        UpDown = 0x0C,
        Down = 0x0D,
        Up = 0x0E,
        None = 0x0F
    }
    #endregion
}
public class RealmInfo
{
    public static byte[] GetByteArrayFromString(string contents)
    {
        byte[] reply = new byte[0]; //{ 0x10, 0x00, 0x00, 0x00, 0x12, 0x00, 0x00, 0x00, 0x83, 0x0F, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x00 };
        string data = contents;
        // So we ignore all else, except those with 0x in front, those we convert and add
        List<byte> b = new List<byte>();
        int index = 0;
        while (data.Length != 0)
        {
            if ((index = data.IndexOf("0x")) == 0) { break; }
            // Get the byte folloiwing it
            string singleByte = string.Empty;
            try { singleByte = data.Substring(index, 4); data = data.Remove(0, index + 4); }
            catch { break; } // we are done
            singleByte = singleByte.Remove(0, 2);
            byte convert = Byte.Parse(singleByte, NumberStyles.HexNumber);
            b.Add(convert);
        }
        if (b.Count > 0) { reply = b.ToArray(); }
        return reply;
    }
}
public class RoomDecoration
{
    public ushort GraphicID { get; set; }
    public ushort LocationX { get; set; }
    public ushort LocationY { get; set; }
    public ushort LocationZ { get; set; }
    public uint RoomID { get; set; }
    public RoomDecoration UnSerialize(byte[] stream, ushort toRoomID)
    {
        // If we do not have 8 bytes, then we are in trouble
        // So if not the correct amount of bytes, or a bad roomid return nothing.
        if (stream.Length != 8 || toRoomID < 0) { return null; }
        // 3 sets of 2 bytes, and a room ID
        var room = this as RoomDecoration;
        room.GraphicID = BitConverter.ToUInt16(stream, 0);
        room.LocationX = BitConverter.ToUInt16(stream, 2);
        room.LocationY = BitConverter.ToUInt16(stream, 4);
        room.LocationZ = BitConverter.ToUInt16(stream, 6);
        room.RoomID = toRoomID;
        return room;
    }
    public static RoomDecoration FromCode(ushort graphicID, ushort X, ushort Y, ushort Z, uint forRoom)
    {
        RoomDecoration reply = new RoomDecoration(graphicID);
        reply.LocationX = X;
        reply.LocationY = Y;
        reply.LocationZ = Z;
        reply.RoomID = forRoom;
        return reply;
    }
    public virtual byte[] Serialize()
    {
        // Build the small list, 3 ushorts
        List<byte> buffer = new List<byte>();
        buffer.AddRange(BitConverter.GetBytes(this.GraphicID)); // Graphic Id First
        buffer.AddRange(BitConverter.GetBytes(this.LocationX));
        buffer.AddRange(BitConverter.GetBytes(this.LocationY));
        buffer.AddRange(BitConverter.GetBytes(this.LocationZ));
        return buffer.ToArray();
    }
    public RoomDecoration(ushort graphicID)
    {
        this.GraphicID = graphicID;
    }
    public void SetLocation(uint inRoom, ushort X, ushort Y, ushort Z)
    {
        this.RoomID = inRoom;
        this.LocationX = X;
        this.LocationY = Y;
        this.LocationZ = Z;
    }
}