using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class DrawCircles
    {
        public static void DrawCircle(int xI, int yI, int ra, int rb, Color color, ref Bitmap bm, DEFINE.EChooseCircle choose)
        {
            if (choose == DEFINE.EChooseCircle.Decac)
            {
                Decac(xI, yI, ra, color, ref bm);
            }
            else if (choose == DEFINE.EChooseCircle.ToaDoCuc)
            {
                ToaDoCuc(xI, yI, ra, color, ref bm);
            }
            else if (choose == DEFINE.EChooseCircle.Midpoint)
            {
                Midpoint(xI, yI, ra, color, ref bm);
            }
            else if (choose == DEFINE.EChooseCircle.Elip)
            {
                Elip(xI, yI, ra, rb, color, ref bm);
            }
        }
        private static void SetPixel(int x, int y, Color color, ref Bitmap bm)
        {
            if (x < 0 || x >= bm.Width || y < 0 || y >= bm.Height) return;
            bm.SetPixel(x, y, color);
        }
        private static void Decac(int xI, int yI, int r, Color color, ref Bitmap bm)
        {
            double y_real;
            int x;
            int y;
            for (x = 0; x <= r * Math.Cos(45 * Math.PI / 180.0) + 0.5; x++)
            {
                y_real = Math.Sqrt(1.0 * r * r - x * x);
                y = DEFINE.Round(y_real);
                SetPixel(x + xI, y + yI, color, ref bm);
                SetPixel(y + xI, x + yI, color, ref bm);
                SetPixel(y + xI, -x + yI, color, ref bm);
                SetPixel(x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, -y + yI, color, ref bm);
                SetPixel(-y + xI, -x + yI, color, ref bm);
                SetPixel(-y + xI, x + yI, color, ref bm);
                SetPixel(-x + xI, y + yI, color, ref bm);
            }
        }
        private static void ToaDoCuc(int xI, int yI, int r, Color color, ref Bitmap bm)
        {
            double scale = r / 60.0;
            int alpha0 = DEFINE.Round(90 * scale);
            int alphaEnd = DEFINE.Round(45 * scale);
            int x, y;
            for (; alpha0 >= alphaEnd; alpha0--)
            {

                x = DEFINE.Round(r * Math.Cos(alpha0 * Math.PI / 180 / scale));
                y = DEFINE.Round(r * Math.Sin(alpha0 * Math.PI / 180 / scale));
                SetPixel(x + xI, y + yI, color, ref bm);
                SetPixel(y + xI, x + yI, color, ref bm);
                SetPixel(y + xI, -x + yI, color, ref bm);
                SetPixel(x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, -y + yI, color, ref bm);
                SetPixel(-y + xI, -x + yI, color, ref bm);
                SetPixel(-y + xI, x + yI, color, ref bm);
                SetPixel(-x + xI, y + yI, color, ref bm);
            }
        }
        private static void Midpoint(int xI, int yI, int r, Color color, ref Bitmap bm)
        {
            int x, y, d;
            x = 0;
            y = r;
            d = 1 - r;
            for (; y >= x; x++)
            {
                SetPixel(x + xI, y + yI, color, ref bm);
                SetPixel(y + xI, x + yI, color, ref bm);
                SetPixel(y + xI, -x + yI, color, ref bm);
                SetPixel(x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, -y + yI, color, ref bm);
                SetPixel(-y + xI, -x + yI, color, ref bm);
                SetPixel(-y + xI, x + yI, color, ref bm);
                SetPixel(-x + xI, y + yI, color, ref bm);
                if (d < 0)
                {
                    d += 2 * (x + 1) + 1;
                }
                else
                {
                    d += 2 * (x + 1) + 1 + 1 - 2 * y;
                    y--;
                }
            }
        }
        private static void Elip(int xI, int yI, int a, int b, Color color, ref Bitmap bm)
        {
            int x = 0;
            int y = b;
            int d = DEFINE.Round(b * b - a * a * b + a * a * 0.25);

            for (; (2 * b * b * x) < (2 * a * a * y); x++) // y
            {
                SetPixel(x + xI, y + yI, color, ref bm);
                SetPixel(x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, y + yI, color, ref bm);
                if (d < 0)
                {
                    d += b * b * (2 * x + 3);
                }
                else
                {
                    d += b * b * (2 * x + 3) + a * a * (-2 * y + 2);
                    y--;
                }
            }
            d = DEFINE.Round(b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b);
            for (; y >= 0; y--)
            {
                SetPixel(x + xI, y + yI, color, ref bm);
                SetPixel(x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, -y + yI, color, ref bm);
                SetPixel(-x + xI, y + yI, color, ref bm);
                if (d >= 0)
                {
                    d += a * a * (-2 * y + 3);
                }
                else
                {
                    d += b * b * (2 * x + 2) + a * a * (-2 * y + 3);
                    x++;
                }
            }
        }
    }
}
