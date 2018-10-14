using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongHop.UC.CircleMove
{
    public partial class CircleMove : UserControl
    {
        Model.Circle c;

        Bitmap bm;
        DEFINE.EChooseCircleMove EChoose = DEFINE.EChooseCircleMove.CircleTranslate;
        DEFINE.EAnimation animation = DEFINE.EAnimation.Start;
        public CircleMove()
        {
            InitializeComponent();
            bm = new Bitmap(pbDraw.Width, pbDraw.Height);
            c = new Model.Circle(ref bm) {
                Color = Color.Red,
                Radius = 50,
                Velocity = new Point(tbVelocity.Value, tbVelocity.Value),
                Position = new Point(200, 200)
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation == DEFINE.EAnimation.Running)
            {
                if (EChoose == DEFINE.EChooseCircleMove.CircleTranslate)
                {
                    c.Translate(timer1.Interval / 1000.0);
                    pbDraw.Image = bm;
                }
                else if (EChoose == DEFINE.EChooseCircleMove.CircleRotate)
                {
                    bm.SetPixel(300, 300, Color.Red);


                    c.Rotate(new Point(300, 300), 10 * Math.PI / 180);
                    pbDraw.Image = bm;
                }
            }
            else if (animation == DEFINE.EAnimation.Pause)
            {
                
            }
            else if (animation == DEFINE.EAnimation.Stop)
            {
                timer1.Stop();
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            EChoose = DEFINE.EChooseCircleMove.CircleTranslate;
        }

        private void btnClearOrStop_Click(object sender, EventArgs e)
        {
            if(animation == DEFINE.EAnimation.Stop)
            {
                if (EChoose == DEFINE.EChooseCircleMove.CircleTranslate)
                {
                    // xoa
                    c.Erase();
                    pbDraw.Image = bm;
                    c = new Model.Circle(ref bm)
                    {
                        Color = Color.Red,
                        Radius = 50,
                        Velocity = new Point(tbVelocity.Value, tbVelocity.Value),
                        Position = new Point(200, 200)
                    };
                }
                animation = DEFINE.EAnimation.Start;
                btnStartOrPause.Text = "Start";
                btnClearOrStop.Text = "Stop";
                btnClearOrStop.Enabled = false;
                btnStartOrPause.Enabled = true;
                btnRotate.Enabled = true;
                btnTranslate.Enabled = true;
            }
            if(animation == DEFINE.EAnimation.Running || animation == DEFINE.EAnimation.Pause)
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
                if (EChoose == DEFINE.EChooseCircleMove.CircleTranslate)
                {
                    c.Draw();
                }
                pbDraw.Image = bm;
                timer1.Interval = 30;
                animation = DEFINE.EAnimation.Running;
                timer1.Start();                
                btnStartOrPause.Text = "Pause";
                btnClearOrStop.Text = "Stop";
                btnClearOrStop.Enabled = true;
                btnRotate.Enabled = false;
                btnTranslate.Enabled = false;
            }
            else if (animation == DEFINE.EAnimation.Running)
            {
                animation = DEFINE.EAnimation.Pause;
                btnStartOrPause.Text = "Resume";
            }
            else if(animation == DEFINE.EAnimation.Pause)
            {
                animation = DEFINE.EAnimation.Running;
                btnStartOrPause.Text = "Pause";
            }
        }

        private void pbDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if(animation == DEFINE.EAnimation.Start && EChoose == DEFINE.EChooseCircleMove.CircleTranslate)
            {
                c.Position = e.Location;
                c.Draw();
                pbDraw.Image = bm;
            }
        }

        private void tbVelocity_Scroll(object sender, EventArgs e)
        {
            if (EChoose == DEFINE.EChooseCircleMove.CircleTranslate)
            {
                c.ChangeVelocity(new Point(tbVelocity.Value, tbVelocity.Value));
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            EChoose = DEFINE.EChooseCircleMove.CircleRotate;
        }
    }
}
