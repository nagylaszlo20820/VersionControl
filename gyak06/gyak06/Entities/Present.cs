﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak06
{
    public class Present : Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color ribbon,Color box)
        {
            PresentColor = new SolidBrush(box);
            RibbonColor = new SolidBrush(ribbon);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 20, 0, 10, 50);
            g.FillRectangle(RibbonColor, 0, 20, 50, 10);

        }
    }
}
