using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI32
{
    public enum SCI32ResourceType : byte
    {
        V56 = 0,
        P56 = 1,
        Scr = 2,
        Snd = 4,
        Voc = 6,
        Fon = 7,
        Cur = 8,
        Pat = 9,
        Bmp = 10,
        Pal = 11,
        Wav = 12,
        Aud = 13,
        Syn = 14,
        Msg = 15,
        Map = 16,
        Hep = 17,
        None = 20,
        EndResource = 255
    }
}
