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
    public partial class ucLines : UserControl
    {
        enum EChoose
        {
            DDA,
            Bresenham,
            Midpoint,
            Bold,
            Dash,
            Shaded
        }
        enum EStateMouse
        {
            MouseDown,
            MouseUp
        }
        EStateMouse stateMouse = EStateMouse.MouseUp;
        EChoose flagChoose = EChoose.DDA;
        Point pA;
        Point pB;
        Bitmap bm;
        Point pBOld = new Point(-1, 0);
        public ucLines()
        {
            InitializeComponent();
            bm = new Bitmap(this.pbDraw.Size.Width, this.pbDraw.Size.Height);
        }




        private void rbDDA_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = EChoose.DDA;
            //RadioButton rb = sender as RadioButton;
            //if(rb.Checked)
            //{
            //    Bitmap bm = new Bitmap(this.pbDraw.Size.Width, this.pbDraw.Size.Height);
            //    DDA(100, 100, 100, 200, bm);
            //    pbDraw.Image = bm;
            //}
        }

        private void rbBresenham_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = EChoose.Bresenham;
        }

        private void rbBold_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = EChoose.Bold;
        }

        private void rbMidpoint_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = EChoose.Midpoint;
        }

        private void rbDash_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = EChoose.Dash;
        }

        private void rbShaded_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = EChoose.Shaded;
        }

        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            stateMouse = EStateMouse.MouseDown;
            pA = e.Location;
            txtX1.Text = pA.X.ToString();
            txtY1.Text = pA.Y.ToString();
        }

        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (stateMouse == EStateMouse.MouseUp) return;
            pB = e.Location;
            txtX2.Text = pB.X.ToString();
            txtY2.Text = pB.Y.ToString();
            DrawLine();
            pBOld = e.Location;

        }

        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            stateMouse = EStateMouse.MouseUp;
            pBOld = new Point(-1, 0);
        }

        private void DrawLine()
        {
            if (flagChoose == EChoose.DDA)
            {
                if (pBOld.X != -1)
                {
                    DDA(pA.X, pA.Y, pBOld.X, pBOld.Y, Color.White);
                }
                DDA(pA.X, pA.Y, pB.X, pB.Y, Color.Red);
                pbDraw.Image = bm;
            }
            else if (flagChoose == EChoose.Bresenham)
            {
                if (pBOld.X != -1)
                {
                    // xoa dt cu
                    Bresenham(pA.X, pA.Y, pBOld.X, pBOld.Y, Color.White);
                }
                Bresenham(pA.X, pA.Y, pB.X, pB.Y, Color.Red);
                pbDraw.Image = bm;
            }
            else if (flagChoose == EChoose.Midpoint)
            {

            }
            else if (flagChoose == EChoose.Bold)
            {
                if (pBOld.X != -1)
                {
                    // xoa dt cu
                    Bold(pA.X, pA.Y, pBOld.X, pBOld.Y, Color.White);
                }
                Bold(pA.X, pA.Y, pB.X, pB.Y, Color.Red);
                pbDraw.Image = bm;
            }
            else if (flagChoose == EChoose.Dash)
            {
                if (pBOld.X != -1)
                {
                    // xoa dt cu
                    Dash(pA.X, pA.Y, pBOld.X, pBOld.Y, Color.White);
                }
                Dash(pA.X, pA.Y, pB.X, pB.Y, Color.Red);
                pbDraw.Image = bm;
            }
            else if (flagChoose == EChoose.Shaded)
            {
                if (pBOld.X != -1)
                {
                    // xoa dt cu
                    Shaded(pA.X, pA.Y, pBOld.X, pBOld.Y, Color.White);
                }
                Shaded(pA.X, pA.Y, pB.X, pB.Y, Color.Red);
                pbDraw.Image = bm;
            }
        }
        private void setPixel(int x, int y, Color color, Bitmap bm)
        {
            if (x < 0 || x >= this.pbDraw.Size.Width || y < 0 || y >= this.pbDraw.Size.Height) return;
            bm.SetPixel(x, y, color);
        }

        private void DDA(int x1, int y1, int x2, int y2, Color color)
        {
            //get board
            //calculating

            double m = -3;
            int infinity = 0;
            if (x1 != x2)
            {
                infinity = 1;
                m = (y2 - y1) / (x2 - x1 * 1.0); // hệ số m
            }
            // tăng theo x
            if (((m <= 1 && m >= 0) || (m >= -1 && m < 0)) && x2 > x1)
            {

                double y = y1;
                int iy;
                for (int x = x1; x <= x2; x++)
                {
                    iy = (int)(y + 0.5);
                    //putPixel(x, iy);
                    setPixel(x, iy, color, bm);
                    y += m;
                }
            }
            //tăng theo y
            else if ((m > 1 || m < -1) && y2 > y1)
            {
                double x = x1;
                int ix;
                for (int y = y1; y <= y2; y++)
                {
                    ix = (int)(x + 0.5);
                    //putPixel(x, iy);
                    setPixel(ix, y, color, bm);
                    x += (1 * infinity / m);
                }
            }
            // giảm theo x
            else if (((m >= -1 && m <= 0) || (m > 0 && m <= 1)) && x1 > x2)
            {
                double y = y1;
                int iy;
                for (int x = x1; x >= x2; x--)
                {
                    iy = (int)(y + 0.5);
                    //putPixel(x, iy);
                    setPixel(x, iy, color, bm);
                    y -= m;
                }
            }
            // giảm theo y
            else if ((m > 1 || m < -1) && y1 > y2)
            {
                double x = x1;
                int ix;
                for (int y = y1; y >= y2; y--)
                {
                    ix = (int)(x + 0.5);
                    //putPixel(x, iy);
                    setPixel(ix, y, color, bm);
                    x -= (1 * infinity / m);
                }
            }
        }
        private void BresenhamX(int x1, int y1, int x2, int y2, Color color)
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
                setPixel(x, y, color, bm);
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
        private void BresenhamY(int x1, int y1, int x2, int y2, Color color)
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
            if (x < xend)
            {
                deltaX = 1;
            }
            int y0 = y;
            for (; y < yend; y++)
            {
                setPixel(x, y, color, bm);
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
        private void Bresenham(int x1, int y1, int x2, int y2, Color color)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                BresenhamY(x1, y1, x2, y2, color);
            }
            else
            {
                BresenhamX(x1, y1, x2, y2, color);
            }
        }
        private void Bold(int x1, int y1, int x2, int y2, Color color)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                BresenhamY(x1, y1, x2, y2, color);
                BresenhamY(x1 + 1, y1, x2 + 1, y2, color);
                BresenhamY(x1 - 1, y1, x2 - 1, y2, color);
            }
            else
            {
                BresenhamX(x1, y1, x2, y2, color);
                BresenhamX(x1, y1 + 1, x2, y2 + 1, color);
                BresenhamX(x1, y1 - 1, x2, y2 - 1, color);
            }

        }
        private void DashX(int x1, int y1, int x2, int y2, Color color)
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
            int dash = 3;
            for (; x < xend; x++)
            {
                if (dash > 0)
                {
                    setPixel(x, y, color, bm);
                    dash--;
                }
                else
                {
                    dash = 3;
                }
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
        private void DashY(int x1, int y1, int x2, int y2, Color color)
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
            if (x < xend)
            {
                deltaX = 1;
            }
            int dash = 3;
            for (; y < yend; y++)
            {

                if (dash > 0)
                {
                    setPixel(x, y, color, bm);
                    dash--;
                }
                else
                {
                    dash = 3;
                }
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
        private void Dash(int x1, int y1, int x2, int y2, Color color)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                DashY(x1, y1, x2, y2, color);
            }
            else
            {
                DashX(x1, y1, x2, y2, color);
            }
        }
        private void ShadedX(int x1, int y1, int x2, int y2, Color color)
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
            int alpha = 255;
            int x0 = x;
            for (; x < xend; x++)
            {
                double doMo = (xend - x) / (xend - x0 * 1.0);
                if (x1 == xend)
                {
                    doMo = 1 - (xend - x) / (xend - x0 * 1.0);
                }
                setPixel(x, y, Color.FromArgb((int)(alpha * doMo), color), bm);
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
        private void ShadedY(int x1, int y1, int x2, int y2, Color color)
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
            if (x < xend)
            {
                deltaX = 1;
            }
            int alpha = 255;
            int y0 = y;
            for (; y < yend; y++)
            {
                double doMo = (yend - y) / (yend - y0 * 1.0);
                if (y1 == yend)
                {
                    doMo = 1 - (yend - y) / (yend - y0 * 1.0);
                }
                setPixel(x, y, Color.FromArgb((int)(alpha * doMo), color), bm);
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
        private void Shaded(int x1, int y1, int x2, int y2, Color color)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                ShadedY(x1, y1, x2, y2, color);
            }
            else
            {
                ShadedX(x1, y1, x2, y2, color);
            }
        }
    }
}
