using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class DrawLines
    {
        public static void DrawLine(int x1, int y1, int x2, int y2, Color color,ref Bitmap bm, DEFINE.EChooseLine chooseLine)
        {
            if (chooseLine == DEFINE.EChooseLine.DDA)
            {
                DDA(x1, y1, x2, y2, color,ref bm);
            }
            else if (chooseLine == DEFINE.EChooseLine.Bresenham)
            {
                Bresenham(x1, y1, x2, y2, color,ref bm);
            }
            else if (chooseLine == DEFINE.EChooseLine.Midpoint)
            {
                Midpoint(x1, y1, x2, y2, color,ref bm);
            }
            else if (chooseLine == DEFINE.EChooseLine.Bold)
            {
                Bold(x1, y1, x2, y2, color,ref bm);
            }
            else if (chooseLine == DEFINE.EChooseLine.Dash)
            {
                Dash(x1, y1, x2, y2, color, ref bm);
            }
            else if (chooseLine == DEFINE.EChooseLine.Shaded)
            {
                Shaded(x1, y1, x2, y2, color, ref bm);
            }
        }
        private static void SetPixel(int x, int y, Color color,ref Bitmap bm)
        {
            if (x < 0 || x >= bm.Width || y < 0 || y >= bm.Height) return;
            bm.SetPixel(x, y, color);
        }

        private static void DDA(int x1, int y1, int x2, int y2, Color color,ref Bitmap bm)
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
                    iy = DEFINE.Round(y);
                    //putPixel(x, iy);
                    SetPixel(x, iy, color, ref bm);
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
                    ix = DEFINE.Round(x);
                    //putPixel(x, iy);
                    SetPixel(ix, y, color, ref bm);
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
                    iy = DEFINE.Round(y);
                    //putPixel(x, iy);
                    SetPixel(x, iy, color, ref bm);
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
                    ix = DEFINE.Round(x);
                    SetPixel(ix, y, color, ref bm);
                    x -= (1 * infinity / m);
                }
            }
        }
        private static void BresenhamX(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
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
                SetPixel(x, y, color, ref bm);
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
        private static void BresenhamY(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
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
            for (; y < yend; y++)
            {
                SetPixel(x, y, color, ref bm);
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
        private static void Bresenham(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                BresenhamY(x1, y1, x2, y2, color, ref bm);
            }
            else
            {
                BresenhamX(x1, y1, x2, y2, color, ref bm);
            }
        }
        private static void MidpointX(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int h = dy;
            int w = h - dx;
            int F = h - dx / 2;
            int x = x1, y = y1;
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
            for (; x <= xend; x++)
            {
                SetPixel(x, y, color, ref bm);
                if (F < 0)
                    F += h;
                else
                {
                    F += w;
                    y += deltaY;
                }
            }
        }
        private static void MidpointY(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int h = dx;
            int w = h - dy;
            int F = h - dy / 2;
            int x = x1, y = y1;
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
            for (; y <= yend; y++)
            {
                SetPixel(x, y, color, ref bm);
                if (F < 0)
                    F += h;
                else
                {
                    F += w;
                    x += deltaX;
                }
            }
        }
        private static void Midpoint(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                MidpointY(x1, y1, x2, y2, color, ref bm);
            }
            else
            {
                MidpointX(x1, y1, x2, y2, color, ref bm);
            }
        }
        private static void Bold(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                BresenhamY(x1, y1, x2, y2, color, ref bm);
                BresenhamY(x1 + 1, y1, x2 + 1, y2, color, ref bm);
                BresenhamY(x1 - 1, y1, x2 - 1, y2, color, ref bm);
            }
            else
            {
                BresenhamX(x1, y1, x2, y2, color, ref bm);
                BresenhamX(x1, y1 + 1, x2, y2 + 1, color, ref bm);
                BresenhamX(x1, y1 - 1, x2, y2 - 1, color, ref bm);
            }

        }
        private static void DashX(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
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
                    SetPixel(x, y, color, ref bm);
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
        private static void DashY(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
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
                    SetPixel(x, y, color, ref bm);
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
        private static void Dash(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                DashY(x1, y1, x2, y2, color, ref bm);
            }
            else
            {
                DashX(x1, y1, x2, y2, color, ref bm);
            }
        }
        private static void ShadedX(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
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
                SetPixel(x, y, Color.FromArgb(DEFINE.Round(alpha * doMo), color), ref bm);
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
        private static void ShadedY(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
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
                SetPixel(x, y, Color.FromArgb(DEFINE.Round(alpha * doMo), color),ref bm);
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
        private static void Shaded(int x1, int y1, int x2, int y2, Color color, ref Bitmap bm)
        {
            double m = -3;
            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1 * 1.0);
            }
            if (m > 1 || m < -1)
            {
                ShadedY(x1, y1, x2, y2, color, ref bm);
            }
            else
            {
                ShadedX(x1, y1, x2, y2, color, ref bm);
            }
        }
    }
}
