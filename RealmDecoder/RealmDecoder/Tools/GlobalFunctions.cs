using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RealmDecoder.Encryption;
using System.Globalization;

namespace RealmDecoder.Tools
{
    public static class GlobalFunctions
    {
        public static byte[] GetPortionsToXOR(byte[] fullPacket, out int packetLength, out int crc, bool removePacketId = false)
        {
            packetLength = 0;
            crc = 0;
            // First 4 is packetLength
            MemoryStream stream = new MemoryStream(fullPacket);
            BinaryReader reader = new BinaryReader(stream);
            packetLength = BitConverter.ToInt32(reader.ReadBytes(4), 0);
            byte[] packet = null;
            try
            {
                if (removePacketId)
                {
                    reader.ReadBytes(4);
                    packet = reader.ReadBytes(packetLength - 4);
                }
                else { packet = reader.ReadBytes(packetLength); }
                // Crc is the last 4 bytes
                crc = BitConverter.ToInt32(reader.ReadBytes(4), 0);
            }
            catch { Form1.WriteLine(string.Format("We have an error with packet  {0}",BitConverter.ToString(fullPacket))); }
            reader.Close();
            return packet;
        }
        public static XoRKey GetKeyFromKnownPacketID(byte[] fullPacket, int knownId)
        {
            // Ites the second 4 bytes
            byte[] pid = new byte[4];
            Array.Copy(fullPacket, 4, pid, 0, pid.Length);

            // transform the known id
            byte[] packetID = BitConverter.GetBytes(knownId);
            // UnXor it
            byte[] result = new byte[4];

            for (int i = 0; i < 4; i++)
                result[i] = (byte)(pid[i] ^ packetID[i]);
            return new XoRKey(result);
        }
        private static char ToSafeAscii(int b)
        {
            if (b >= 32 && b <= 126)
            {
                return (char)b;
            }
            return '.';
        }
        public static string NiceHexOutput(byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) return "<null>";
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - 2) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString().Trim();
        }
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] HexAsBytes = new byte[hexString.Length / 2];
            for (int index = 0; index < HexAsBytes.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                try { HexAsBytes[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture); }
                catch { }
            }

            return HexAsBytes;
        }
        public static byte[] ParseFullHexStringToArray(string hexString)
        {
            // we get this type of string {0xAA, -0xBB}
            hexString = hexString.Remove(0, 1);
            hexString = hexString.Remove(hexString.Length - 1);
            string[] test = hexString.Split(',');
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = test[i].Trim();
                test[i] = test[i].Remove(0, 2);
            }
            return Tools.GlobalFunctions.ConvertHexStringToByteArray(string.Join("", test));
        }
        public static string FormatBytes(byte[] bytes)
        {
            if (bytes == null) { return ""; }
            // Create our start
            StringBuilder result = new StringBuilder();
            result.Append("{ ");
            string convert = BitConverter.ToString(bytes);
            string[] sections = convert.Split('-');
            List<string> rebuild = new List<string>();

            for (int i = 0; i < sections.Length; i++)
            {
                if (i != sections.Length - 1)
                {
                    rebuild.Add("0x" + sections[i] + ", ");
                }
                else
                {
                    rebuild.Add("0x" + sections[i]);
                }
            }
            foreach (string s in rebuild)
            {
                result.Append(s);
            }
            result.AppendLine(" };");
            return result.ToString();
        }
        public static byte[] RebuildPacket(int packetLength, int crc, byte[] payload)
        {
            byte[] pck_len = BitConverter.GetBytes(packetLength);
            byte[] Crc = BitConverter.GetBytes(crc);
            byte[] result = new byte[pck_len.Length + payload.Length + Crc.Length];
            Array.Copy(pck_len, result, pck_len.Length);
            Array.Copy(payload, 0, result, pck_len.Length, payload.Length);
            Array.Copy(Crc, 0, result, pck_len.Length + payload.Length, Crc.Length);
            return result;
        }
        public static void PrintPacket(byte[] packet, System.Drawing.Color color)
        {
            Form1.WriteLine("--------------------------Begin---------------------------------", color);
            Form1.WriteLine(string.Format("Packet ID {0}", BitConverter.ToInt32(packet, 4)));
            Form1.WriteLine(FormatBytes(packet)+"\n", color);
            Form1.WriteLine(NiceHexOutput(packet), color);
            Form1.WriteLine("--------------------------End-----------------------------------", color);

        }
    }
}
