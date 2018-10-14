using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongHop.UC.Circle
{
    public partial class ucCircle : UserControl
    {
        DEFINE.EChooseCircle flagChoose = DEFINE.EChooseCircle.Decac;
        Point pCenter;
        Bitmap bm;
        int ra;
        int rb;
        public ucCircle()
        {
            InitializeComponent();
            bm = new Bitmap(this.pbDraw.Size.Width, this.pbDraw.Size.Height);
            pCenter = new Point(0, 0);
            ra = rb = tbRadius.Value;
            tbA.Value = tbRadius.Value;
            tbB.Value = tbRadius.Value;
            gbElip.Enabled = false;
        }
        private void DrawCircle()
        {
            Model.DrawCircles.DrawCircle(pCenter.X, pCenter.Y, ra, rb, Color.Red,ref bm, flagChoose);
            pbDraw.Image = bm;
        }


        private void pbDraw_MouseClick(object sender, MouseEventArgs e)
        {
            pCenter = e.Location;
            txtX.Text = pCenter.X.ToString();
            txtY.Text = pCenter.Y.ToString();
            DrawCircle();
        }

        private void tbRadius_Scroll(object sender, EventArgs e)
        {
            ra = rb = tbRadius.Value;
            tbA.Value = tbRadius.Value;
            tbB.Value = tbRadius.Value;
        }

        private void rbDecac_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseCircle.Decac;
            ChangeDrawElip();
        }

        private void rbToaDoCuc_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseCircle.ToaDoCuc;
            ChangeDrawElip();
        }

        private void rbMidpoint_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseCircle.Midpoint;
            ChangeDrawElip();
        }

        private void rbElip_CheckedChanged(object sender, EventArgs e)
        {
            flagChoose = DEFINE.EChooseCircle.Elip;
            ChangeDrawElip();
        }

        private void tbA_Scroll(object sender, EventArgs e)
        {
            ra = tbA.Value;
            tbRadius.Value = tbA.Value;
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            rb = tbB.Value;
        }

        private void ChangeDrawElip()
        {
            if(flagChoose == DEFINE.EChooseCircle.Elip)
            {
                pnlRadius.Enabled = false;
                gbElip.Enabled = true;
            }
            else
            {
                pnlRadius.Enabled = true;
                gbElip.Enabled = false;
                ra = rb = tbRadius.Value;
                tbA.Value = tbRadius.Value;
                tbB.Value = tbRadius.Value;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
