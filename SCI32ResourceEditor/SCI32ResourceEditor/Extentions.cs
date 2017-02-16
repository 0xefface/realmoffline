using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI32ResourceEditor
{
    public static class Extentions
    {
        public static byte[] Reverse(this byte[] bytes)
        {
            Array.Reverse(bytes);
            return bytes;
        }
        public static byte[] FromFile(this byte[] bytes, string fileLocation)
        {
            return System.IO.File.ReadAllBytes(fileLocation);
        }
        public static string ToHexString(this byte[] bytes)
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
        public static byte[] ReadUntilFF(this BinaryReader reader)
        {
            List<byte> reply = new List<byte>();
            try
            {
                byte readByte = 0;
                while ((readByte = reader.ReadByte()) != 0xFF)
                {
                    reply.Add(readByte);
                }
            }
            catch { }
            return reply.ToArray();
        }
        public static void SortAllChildNodes(this TreeNode node)
        {
            List<TreeNode> allnodes = new List<TreeNode>();
            foreach (TreeNode tn in node.Nodes)
            {
                allnodes.Add(tn);
            }
            // sort .Tag works best so far not good enough
            allnodes = allnodes.OrderBy(c => int.Parse(c.Name.Split('.').First())).ToList();
            node.Nodes.Clear();
            foreach (TreeNode tn2 in allnodes)
                node.Nodes.Add(tn2);
        }
        public static byte[] ToByteArray(this BitArray bits)
        {
            int numBytes = bits.Count / 8;
            if (bits.Count % 8 != 0) numBytes++;
            byte[] bytes = new byte[numBytes];
            int byteIndex = 0, bitIndex = 0;
            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i])
                    bytes[byteIndex] |= (byte)(1 << (7 - bitIndex));
                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }
            return bytes;
        }
        public static IEnumerable<bool> GetBitsFromBytes(this byte[] bytes)
        {
            return bytes.SelectMany(GetBits).ToArray();

        }
        public static BitArray ToBitArray(this byte[] bytes, bool fromBool = false)
        {
            if (!fromBool)
                return new BitArray(bytes);
            else return new BitArray(GetBitsFromBytes(bytes).ToArray());
        }
        public static string BytesAsBinaryString(this byte[] bytes, int howMany)
        {
            var binaryStrings = from b in bytes
                                select Convert.ToString(b, 2);
            return String.Join(Environment.NewLine, binaryStrings.Take(howMany));
        }
        static IEnumerable<bool> GetBits(byte b)
        {
            for (int i = 0; i < 8; i++)
            {
                yield return (b & 0x80) != 0;
                b *= 2;
            }
        }
    }
}
