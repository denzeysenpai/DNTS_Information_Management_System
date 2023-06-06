using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnts.Code
{
    internal class SeiyaMarx
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public void RoundCorners(Control element, int radius)
        {
            element.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, element.Width, element.Height, radius, radius));
        }
    }
}
