﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace draw_app
{
    public class Square : Rectangle
    {
        public Square(int x, int y, int w, Color color, int penWidth) : base(x, y, w, w, color, penWidth) { }
    }
}
