using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongHop.UC.Wheel
{
    public partial class ucWheelMove : UserControl
    {
        Bitmap bm;
        int speedMoveBase = 100;
        double speedRotateBase = 0.2;
        Model.Wheel w;
        DEFINE.EAnimation animation = DEFINE.EAnimation.Start;



        public ucWheelMove()
        {
            InitializeComponent();
            bm = new Bitmap(pbDraw.Size.Width, pbDraw.Size.Height);
            w = new Model.Wheel(new Point(200, 200), 50, Color.Red, new Point(speedMoveBase * tbVelocity.Value, 0), speedRotateBase, ref bm);
            w.Draw();

            pbDraw.Image = bm;
        }

        private void tbRotate_Scroll(object sender, EventArgs e)
        {
            int dir = 1;
            if(w.SpeedRotate < 0)
            {
                dir = -1;
            }
            w.SpeedRotate = speedRotateBase * tbRotate.Value * dir;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation == DEFINE.EAnimation.Running)
            {

                w.Rotate();

                w.Translate(timer1.Interval / 1000.0);
                pbDraw.Image = bm;

            }
            else if (animation == DEFINE.EAnimation.Pause)
            {

            }
            else if (animation == DEFINE.EAnimation.Stop)
            {
                timer1.Stop();
            }
        }
        private void btnClearOrStop_Click(object sender, EventArgs e)
        {
            if (animation == DEFINE.EAnimation.Stop)
            {

                // xoa
                w.Erase();

                w = new Model.Wheel(new Point(200, 200), 50, Color.Red, new Point(speedMoveBase * tbVelocity.Value, 0), speedRotateBase, ref bm);
                w.Draw();
                pbDraw.Image = bm;

                animation = DEFINE.EAnimation.Start;
                btnStartOrPause.Text = "Start";
                btnClearOrStop.Text = "Stop";
                btnClearOrStop.Enabled = false;
                btnStartOrPause.Enabled = true;
                pnlRotate.Enabled = true;
                tbRotate.Value = 1;
                tbVelocity.Value = 1;
            }
            if (animation == DEFINE.EAnimation.Running || animation == DEFINE.EAnimation.Pause)
            {
                animation = DEFINE.EAnimation.Stop;
                btnClearOrStop.Text = "Clear";
                btnStartOrPause.Enabled = false;
            }
        }

        private void btnStartOrPause_Click(object sender, EventArgs e)
        {
            if (animation == DEFINE.EAnimation.Start)
            {
                timer1.Interval = 30;
                animation = DEFINE.EAnimation.Running;
                timer1.Start();
                btnStartOrPause.Text = "Pause";
                btnClearOrStop.Text = "Stop";
                btnClearOrStop.Enabled = true;
            }
            else if (animation == DEFINE.EAnimation.Running)
            {
                animation = DEFINE.EAnimation.Pause;
                btnStartOrPause.Text = "Resume";
            }
            else if (animation == DEFINE.EAnimation.Pause)
            {
                animation = DEFINE.EAnimation.Running;
                btnStartOrPause.Text = "Pause";
            }
        }

        private void tbVelocity_Scroll(object sender, EventArgs e)
        {
            w.MultiVel(tbVelocity.Value, speedMoveBase);
        }
    }
}
