using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongHop.UC.Rectangle
{
    public partial class ucRectangleMove : UserControl
    {
        Model.Rectangle r;
        Bitmap bm;
        Model.Oxy Oxy;
        int speedMoveBase = 100;
        DEFINE.EAnimation animation = DEFINE.EAnimation.Start;
        public ucRectangleMove()
        {
            InitializeComponent();
            bm = new Bitmap(pbDraw.Size.Width, pbDraw.Size.Height);
            Oxy = new Model.Oxy(ref bm)
            {
                Position = new Point(DEFINE.Round(pbDraw.Width / 2), DEFINE.Round(pbDraw.Height / 2)),
                Color = Color.Red
            };
            r = new Model.Rectangle(ref bm)
            {
                Position = new Point(Oxy.Position.X, Oxy.Position.Y),
                Color = Color.Red,
                Direction = new Point(100, 0),
                Height = 60,
                Width = 30,
                Velocity = new Point(speedMoveBase * tbVelocity.Value, 0)
            };
            r.Draw();
            Oxy.Draw();
            pbDraw.Image = bm;

        }


        private void tbAlpha_Scroll(object sender, EventArgs e)
        {
            if (tbAlpha.Value > 360)
            {
                tbAlpha.Value = 0;
            }
            if (tbAlpha.Value < 0)
            {
                tbAlpha.Value = 360;
            }
            double theta = tbAlpha.Value * Math.PI / 180;
            double alpha2 = DEFINE.DirToRad(r.Direction);
            double alpha = theta - alpha2;
            r.Rotate(r.Position, alpha);

            Oxy.Draw();
            pbDraw.Image = bm;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation == DEFINE.EAnimation.Running)
            {
                r.Translate(timer1.Interval / 1000.0);
                Oxy.Draw();
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
                r.Erase();
                Oxy.Erase();
                r = new Model.Rectangle(ref bm)
                {
                    Position = new Point(Oxy.Position.X, Oxy.Position.Y),
                    Color = Color.Red,
                    Direction = new Point(100, 0),
                    Height = 60,
                    Width = 30,
                    Velocity = new Point(speedMoveBase * tbVelocity.Value, 0)
                };
                r.Draw();
                Oxy.Draw();
                pbDraw.Image = bm;

                animation = DEFINE.EAnimation.Start;
                btnStartOrPause.Text = "Start";
                btnClearOrStop.Text = "Stop";
                btnClearOrStop.Enabled = false;
                btnStartOrPause.Enabled = true;
                pnlAlpha.Enabled = true;
                tbAlpha.Value = 0;
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
                double sizeDir = Math.Sqrt(r.Direction.X * r.Direction.X + r.Direction.Y * r.Direction.Y);
                r.Velocity = new Point(DEFINE.Round(tbVelocity.Value * (speedMoveBase * r.Direction.X / sizeDir)),
                    -1 * DEFINE.Round(tbVelocity.Value * (speedMoveBase * r.Direction.Y / sizeDir)));
                timer1.Interval = 30;
                animation = DEFINE.EAnimation.Running;
                timer1.Start();
                btnStartOrPause.Text = "Pause";
                btnClearOrStop.Text = "Stop";
                btnClearOrStop.Enabled = true;
                //  pnlAlpha.Enabled = false;
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
            r.MultiVel(tbVelocity.Value, speedMoveBase);
        }
    }
}
