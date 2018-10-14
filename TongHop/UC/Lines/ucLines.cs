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
        DEFINE.EStateMouse stateMouse = DEFINE.EStateMouse.MouseUp;
        DEFINE.EChooseLine flagChoose = DEFINE.EChooseLine.DDA;
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
            flagChoose = DEFINE.EChooseLine.DDA;
        }

        private void rbBresenham_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseLine.Bresenham;
        }

        private void rbBold_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseLine.Bold;
        }

        private void rbMidpoint_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseLine.Midpoint;
        }

        private void rbDash_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseLine.Dash;
        }

        private void rbShaded_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseLine.Shaded;
        }

        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            stateMouse = DEFINE.EStateMouse.MouseDown;
            pA = e.Location;
            txtX1.Text = pA.X.ToString();
            txtY1.Text = pA.Y.ToString();
        }

        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (stateMouse == DEFINE.EStateMouse.MouseUp) return;
            pB = e.Location;
            txtX2.Text = pB.X.ToString();
            txtY2.Text = pB.Y.ToString();
            DrawLine();
            pBOld = e.Location;

        }

        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            stateMouse = DEFINE.EStateMouse.MouseUp;
            pBOld = new Point(-1, 0);
        }

        private void DrawLine()
        {
            if (pBOld.X != -1)
            {
                Model.DrawLines.DrawLine(pA.X, pA.Y, pBOld.X, pBOld.Y, Color.White, ref bm, flagChoose);
            }
            Model.DrawLines.DrawLine(pA.X, pA.Y, pB.X, pB.Y, Color.Red, ref bm, flagChoose);
            pbDraw.Image = bm;
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            pbDraw.Image = null;
            bm = new Bitmap(this.pbDraw.Size.Width, this.pbDraw.Size.Height);
        }
    }
}
