using SCI32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI32ResourceEditor.Helpers
{
    public enum Icon : int
    {
        EmptyFolder = 0,
        ClosedFolder = 1,
        OpenFolder = 2,
        Font = 3,
        Heap = 4,
        Message = 5,
        Palette = 6,
        Picture = 7,
        Script = 8,
        View = 9,
        Vocab = 10,
        None = 255
    }
    public static class Icons
    {
        public static int GetIconIndex(Icon icon)
        {
            return (int)icon;
        }
        public static Icon GetIconFromIndex(int icon)
        {
            Icon reply = Icon.None;
            foreach (Icon ico in Enum.GetValues(typeof(Icon)))
            {
                if (icon == GetIconIndex(ico)) { reply = ico; }
            }
            return reply;
        }
        public static int GetIconIndexByType(SCI32ResourceType type)
        {
            switch (type)
            {
                case SCI32ResourceType.Fon: return GetIconIndex(Icon.Font);
                case SCI32ResourceType.Hep: return GetIconIndex(Icon.Heap);
                case SCI32ResourceType.Msg: return GetIconIndex(Icon.Message);
                case SCI32ResourceType.P56: return GetIconIndex(Icon.Picture);
                case SCI32ResourceType.Pal: return GetIconIndex(Icon.Palette);
                case SCI32ResourceType.Scr: return GetIconIndex(Icon.Script);
                case SCI32ResourceType.V56: return GetIconIndex(Icon.View);
                case SCI32ResourceType.Voc: return GetIconIndex(Icon.Vocab);
                default: return GetIconIndex(Icon.None);
            }
        }
    }
}
