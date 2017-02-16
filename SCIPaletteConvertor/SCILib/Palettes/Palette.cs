using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SCILib.Palettes
{
    public class Palette
    {
        public short FirstColor { get; set; }
        public bool IsTripleColors { get; set; }
        public Color[] Colors { get; set; }
    }
}
