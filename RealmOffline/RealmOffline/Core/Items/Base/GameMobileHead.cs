using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RealmOffline.Core
{
    public class GameMobileHead
    {
        public byte Race;
        public byte Gender;
        public byte Head;
        public byte Hair;
        public byte Brow;
        public byte Eye;
        public byte Nose;
        public byte Ear;
        public byte Mouth;
        public byte Beard;
        public byte SkinColor;
        public byte HairColor;
        public byte EyeColor;

        public byte[] ToArray()
        {
            MemoryStream _stream = new MemoryStream();
            BinaryWriter _writer = new BinaryWriter(_stream);

            _writer.Write(Race);
            _writer.Write(Gender);
            _writer.Write(Head);
            _writer.Write(Hair);
            _writer.Write(Brow);
            _writer.Write(Eye);
            _writer.Write(Nose);
            _writer.Write(Ear);
            _writer.Write(Mouth);
            _writer.Write(Beard);
            _writer.Write(SkinColor);
            _writer.Write(HairColor);
            _writer.Write(EyeColor);

            _stream.Position = 0;

            return _stream.ToArray();
        }
    }
}
