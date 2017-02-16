using System;

namespace RealmOffline.Core
{
    public class RealmCrypt
    {
        uint ekey0 = 0;
        uint ekey1 = 0;

        uint dkey0 = 0;
        uint dkey1 = 0;

        public void PutU32(byte[] dst, int offset, uint value)
        {
            byte[] enc = BitConverter.GetBytes(value);
            Buffer.BlockCopy(enc, 0, dst, offset, 4);
        }

        // this takes a message from server->client of type 4 and
        // extracts the crypt keys
        public void HandleCryptMessage(byte[] message)
        {
            byte cryptKey0 = message[8 + 0];
            byte cryptKey1 = message[8 + 1];

            int numWords = (message.Length - 10) / 4;

            for (int x = 0; x < numWords; ++x)
            {
                int baseIndex = 10 + x * 4;
                byte a = message[baseIndex + 0];
                byte b = message[baseIndex + 1];
                byte c = message[baseIndex + 2];
                byte d = message[baseIndex + 3];

                a -= cryptKey0;
                a += 0x39;

                b += cryptKey1;
                b -= 0x46;

                c += cryptKey0;
                c -= 0x0C;

                d -= cryptKey1;
                d += 0x30;

                message[baseIndex + 0] = a;
                message[baseIndex + 1] = b;
                message[baseIndex + 2] = c;
                message[baseIndex + 3] = d;
            }

            byte isDecrypt = message[10];

            if (isDecrypt == 1)
            {
                dkey0 = BitConverter.ToUInt32(message, 0x9C);
                dkey1 = BitConverter.ToUInt32(message, 0xA0);
            }
            else
            {
                ekey0 = BitConverter.ToUInt32(message, 0x5C);
                ekey1 = BitConverter.ToUInt32(message, 0x60);
            }
        }

        public void EncryptMessage(byte[] msg)
        {
            int blocks = (msg.Length - 8) / 4;

            uint checksum = 0;
            uint eax = ekey0;

            for (int x = 0; x < blocks; ++x)
            {
                uint s = BitConverter.ToUInt32(msg, 4 + x * 4);
                checksum = checksum ^ s;

                eax = eax * ekey1;
                eax = eax + 1;

                PutU32(msg, 4 + x * 4, s ^ eax);
            }

            ekey0 = eax;
            PutU32(msg, msg.Length - 4, checksum);
        }

        public void DecryptMessage(byte[] msg, ref uint key0, ref uint key1)
        { 
            uint ecx = (uint)msg.Length - 4;
            ecx /= 4;

            uint eax = key0;

            uint src0 = BitConverter.ToUInt32(msg, 4);
            uint src1 = BitConverter.ToUInt32(msg, 8);
            uint src2 = BitConverter.ToUInt32(msg, 12);

            uint ebx = src0;

            eax = eax * key1 + 1;
            src0 ^= eax;
            PutU32(msg, 4, src0);

            eax = eax * key1 + 1;
            src1 ^= eax;
            ebx ^= src1;
            PutU32(msg, 8, src1);

            eax = eax * key1 + 1;
            src2 ^= eax;
            ebx ^= src2;
            PutU32(msg, 12, src2);

            key0 = eax;

            if (ecx >= 4)
            {
                uint src3 = BitConverter.ToUInt32(msg, 16);

                eax = eax * key1 + 1;
                src3 ^= eax;
                ebx ^= src3;
                PutU32(msg, 16, src3);

                key0 = eax;

                if (ecx >= 5)
                {
                    int baseOffset = 20;
                    ecx -= 5;

                    while (ecx > 0)
                    {
                        uint srcN = BitConverter.ToUInt32(msg, baseOffset);
                        ebx ^= srcN;

                        PutU32(msg, baseOffset, srcN);

                        baseOffset += 4;
                        ecx--;
                    }
                }
            }
        }
    }
}
