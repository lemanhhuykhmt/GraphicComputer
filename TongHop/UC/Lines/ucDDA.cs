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
    public partial class ucDDA : UserControl
    {
        public ucDDA()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //get data
            int x1 = Convert.ToInt32(txtX1.Text);
            int y1 = Convert.ToInt32(txtY1.Text);
            int x2 = Convert.ToInt32(txtX2.Text);
            int y2 = Convert.ToInt32(txtY2.Text);

            //get board
            Bitmap bm = new Bitmap(this.pbDraw.Width, this.pbDraw.Height);
            //calculating
            double m = (double)(y2 - y1) / (x2 - x1); // hệ số m

            // tăng theo x
            if (((m <= 1 && m >= 0) || (m >= -1 && m < 0)) && x2 > x1)
            {

                double y = y1;
                int iy;
                for (int x = x1; x <= x2; x++)
                {
                    iy = (int)(y + 0.5);
                    //putPixel(x, iy);
                    bm.SetPixel(x, pbDraw.Height - 1 - iy, Color.Red);
                    y += m;
                }
            }
            //tăng theo y
            else if((m > 1 || m < -1) && y2 > y1)
            {
                double x = x1;
                int ix;
                for (int y = y1; y <= y2; y++)
                {
                    ix = (int)(x + 0.5);
                    //putPixel(x, iy);
                    bm.SetPixel(ix, pbDraw.Height - y, Color.Red);
                    x += (1 / m);
                }
            }
            // giảm theo x
            else if(((m >= -1 && m <= 0) || (m > 0 && m <= 1)) && x1 > x2)
            {
                double y = y1;
                int iy;
                for (int x = x1; x >= x2; x--)
                {
                    iy = (int)(y + 0.5);
                    //putPixel(x, iy);
                    bm.SetPixel(x, pbDraw.Height - iy, Color.Red);
                    y -= m;
                }
            }
            // giảm theo y
            else if((m > 1 || m < -1) && y1 > y2)
            {
                double x = x1;
                int ix;
                for (int y = y1; y >= y2; y--)
                {
                    ix = (int)(x + 0.5);
                    //putPixel(x, iy);
                    bm.SetPixel(ix, pbDraw.Height - y, Color.Red);
                    x -= (1 / m);
                }
            }
            pbDraw.Image = bm;
        }
    }
}
