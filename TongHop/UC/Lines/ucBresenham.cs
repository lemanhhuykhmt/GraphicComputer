using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongHop.UC.Lines
{
    public partial class ucBresenham : UserControl
    {
        public ucBresenham()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(txtX1.Text);
            int y1 = Convert.ToInt32(txtY1.Text);
            int x2 = Convert.ToInt32(txtX2.Text);
            int y2 = Convert.ToInt32(txtY2.Text);
            Bitmap bm = new Bitmap(this.pbDraw.Size.Width, this.pbDraw.Size.Height);

            BresenhamY(x1, y1, x2, y2, bm);
           // Bresenham(100, 100, 40, 350, bm);

            pbDraw.Image = bm;
        }
        private void Bresenham(int x1, int y1, int x2, int y2, Bitmap bm)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int h = 2 * dy;
            int w = h - 2 * dx;
            int d = h - dx;
            int x = x1;
            int y = y1;
            int xend;
            int yend;
            if (x1 > x2)
            {
                x = x2;
                y = y2;
                xend = x1;
                yend = y1;
            }
            else
            {
                x = x1;
                y = y1;
                xend = x2;
                yend = y2;
            }
            int deltaY = -1;
            if (y < yend)
            {
                deltaY = 1;
            }
            for (; x < xend; x++)
            {
                bm.SetPixel(x,pbDraw.Height - 1 - y, Color.Red);
                if (d < 0)
                {
                    d += h;
                }
                else
                {
                    d += w;
                    y += deltaY;
                }
            }
        }
        private void BresenhamY(int x1, int y1, int x2, int y2, Bitmap bm)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int h = 2 * dx;
            int w = h - 2 * dy;
            int d = h - dy;
            int x = x1;
            int y = y1;
            int xend;
            int yend;
            if (y1 > y2)
            {
                x = x2;
                y = y2;
                xend = x1;
                yend = y1;
            }
            else
            {
                x = x1;
                y = y1;
                xend = x2;
                yend = y2;
            }
            int deltaX = -1;
            if (y < yend)
            {
                deltaX = 1;
            }
            for (; y < yend; y++)
            {
                bm.SetPixel(x, pbDraw.Height - 1 - y, Color.Red);
                if (d < 0)
                {
                    d += h;
                }
                else
                {
                    d += w;
                    x += deltaX;
                }
            }
        }
    }
}
