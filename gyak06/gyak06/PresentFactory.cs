﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak06
{
    public class PresentFactory : IToyFactory
    {
        public Color PresentColor { get; set; }
        public Color RibbonColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(PresentColor, RibbonColor);
        }
    }
}
