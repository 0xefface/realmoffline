using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using SharpPcap;
using System.Drawing;
using System.Net;
using System.Diagnostics;
using PacketMonitor.Helpers;
using System.Net.Sockets;

namespace PacketMonitor
{
    public static class Globals
    {
        /// <summary>
        /// The path this application is running from
        /// </summary>
        public static string AppDir = Application.StartupPath;

        /// <summary>
        /// Gets a List of Network adapters for a listview
        /// </summary>
        /// <param name="owner">the listview</param>
        /// <returns>the list of adapters converted to a listview collection</returns>
        public static ListView.ListViewItemCollection GetDevices(ListView owner)
        {
            ListView.ListViewItemCollection result = new ListView.ListViewItemCollection(owner);
            try
            {
                CaptureDeviceList DeviceList = CaptureDeviceList.Instance;
                for (int i = 0; i < DeviceList.Count; i++)
                {
                    string desc = DeviceList[i].Description.Substring(17);
                    //mainForm.WriteLine(desc);
                    ListViewItem item = new ListViewItem(desc);
                    item.Tag = DeviceList[i];
                    result.Add(item);
                }
            }
            catch (Exception ex) { mainForm.WriteLine(ex.Message, Color.Red); }
            return result;
        }
        /// <summary>
        /// Splits a string seperated by comma's
        /// </summary>
        /// <param name="list">the string</param>
        /// <returns>a list of strings</returns>
        public static List<string> SplitString(string list, char splitBy)
        {
            List<string> result = new List<string>();
            string[] split = list.Split(splitBy);
            try
            {
                for (int i = 0; i < split.Length; i++)
                {
                    result.Add(split[i].Trim());                    
                }
            }
            catch { }
            return result;
        }
        /// <summary>
        /// Splits a string seperated by comma's
        /// and checks if they are valid ip addresses
        /// </summary>
        /// <param name="list">the string</param>
        /// <returns>a list of ip's</returns>
        public static List<string> SplitIPList(string list)
        {
            List<string> result = new List<string>();
            string[] split = list.Split(',');
            try
            {
                for (int i = 0; i < split.Length; i++)
                {
                    IPAddress addy = IPAddress.Any;

                    if (IPAddress.TryParse(split[i], out addy))
                    {
                        result.Add(split[i]);
                    }
                }
            }
            catch { }
            return result;            
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
        
        public static char ToSafeAscii(int b)
        {
            if (b >= 32 && b <= 126)
            {
                return (char)b;
            }
            return '.';
        }

        public static string NiceHexOutPut(byte[] packet)
        {
            if (packet == null) return string.Empty;
            string outp = "";
            int counter = 0;

            outp = "Packet length: " + packet.Length.ToString() + "\r\n";

            while (counter < packet.Length)
            {
                outp = outp + " ";
                if (packet.Length - counter > 16)
                {
                    byte[] temp = new byte[16];
                    Array.Copy(packet, counter, temp, 0, 16);
                    outp = outp + BitConverter.ToString(temp).Replace("-", " ").PadRight(52);
                    foreach (byte b in temp)
                    {
                        outp = outp + ToSafeAscii(b);
                    }
                    outp = outp + "\r\n";
                }
                else
                {
                    byte[] temp = new byte[packet.Length - counter];
                    Array.Copy(packet, counter, temp, 0, packet.Length - counter);
                    outp = outp + BitConverter.ToString(temp).Replace("-", " ").PadRight(52);
                    foreach (byte b in temp)
                    {
                        outp = outp + ToSafeAscii(b);
                    }
                    outp = outp + "\r\n";
                }
                counter += 16;
            }
            return outp;
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
            return result.ToString();
        }
        public static byte[] ByteConvert(string s)
        {
            byte[] rt = new byte[(s.Length + 1) / 3];
            for (int j = 0, i = 0; i < s.Length; i += 3)
            {
                rt[j] = Convert.ToByte(s.Substring(i, 2), 16);
                j++;
            }
            return rt;
        }
        public static bool TryGetAllProcessMemoryBytes(Process process, out byte[] memory)
        {
            List<byte> allBytes = new List<byte>();

            try
            {
                //for (int i = 0; i < 2147483647; i++)
                //{
                    IntPtr pointer = (process.MainModule.BaseAddress + 3736);
                    uint BytesRead = 0;
                    byte[] toRead = TcpHelper.Read(process.Handle, pointer, 20480, ref BytesRead);
                    allBytes.AddRange(toRead);
                //}
                memory = allBytes.ToArray();
                return true;
            }
            catch (Exception ex) { mainForm.WriteLine("ER"+ex.Message); }
            memory = null;
            return false;
        }
        /// <summary>
        ///     Convert to uncompressed IPv4/IPv6
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public static string ToUncompressedString(this IPAddress ipAddress)
        {
            if (ipAddress.AddressFamily == AddressFamily.InterNetwork)  // IPv4
            {
                
                var strings = ipAddress.GetAddressBytes()
                    .Select(b => string.Format("{0:D3}", b));   // format bytes with padded 0s

                return string.Join(".", strings);   // join padded strings with '.' character
            }

            if (ipAddress.AddressFamily == AddressFamily.InterNetworkV6)    // IPv6
            {

                var strings = Enumerable.Range(0, 8)    // create index
                                        .Select(i => ipAddress.GetAddressBytes().ToList().GetRange(i * 2, 2))       // get 8 chunks of bytes
                                        .Select(i => { i.Reverse(); return i; })    // reverse bytes for endianness
                                        .Select(bytes => BitConverter.ToInt16(bytes.ToArray(), 0))  // convert bytes to 16 bit int
                                        .Select(int16 => string.Format("{0:X4}", int16).ToUpper()); // format int as a 4 digit hex 

                return string.Join(":", strings);   // join hex ints with ':'
            }

            return ipAddress.ToString();    // all else treat as to string
        }
    }
}
