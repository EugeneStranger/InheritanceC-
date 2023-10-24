﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstructGeometry
{
    interface IHaveDiagonal
    {
        double GetDiagonal();
        void DrawDiagonal(PaintEventArgs e);

    }
}
