using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class Line : Shape
    {
        private Point pHead;
        private Point pEnd;
        public Point PHead
        {
            get => pHead;
            set { pHead = value;
                UpdateMidPoint();
            }
        }
        public Point PEnd
        {
            get => pEnd;
            set
            {
                pEnd = value;
                UpdateMidPoint();
            }
        }
        public int Length
        {
            get
            {
                int len = 0;
                len = DEFINE.Round(Math.Sqrt((pHead.X - pEnd.X) * (pHead.X - pEnd.X) + (pHead.Y - pEnd.Y) * (pHead.Y - pEnd.Y)));
                return len;
            }
        }
        public Line(ref Bitmap bm) : base(ref bm)
        {

        }

        public Line(Point head, Point end, Color col, Point vel, ref Bitmap bm) : base(head, col, vel, ref bm)
        {
            pHead = head;
            pEnd = end;

            UpdateMidPoint();
        }

        public override void Rotate(Point I, double angle) // quay quanh tâm I 1 góc angle
        {
            base.Rotate(I, angle);
            this.Erase();
            Transform.Rotate<Point>(ref pHead, x => x.X, x => x.Y, I.X, I.Y, -angle); // trừ vì 0y bm >< Oxy
            Transform.Rotate<Point>(ref pEnd, x => x.X, x => x.Y, I.X, I.Y, -angle);
            this.Draw();
        }

        public override void Translate(double deltaTime)
        {
            int xhead = pHead.X;
            int yhead = pHead.Y;
            int xend = pEnd.X;
            int yend = pEnd.Y;
            Erase();
            // các tính toán bên trong đối tượng (vd: cập nhật vị trí)
            Transform.Translate(ref xhead, ref yhead, DEFINE.Round(deltaTime * Velocity.X), DEFINE.Round(deltaTime * Velocity.Y));
            Transform.Translate(ref xend, ref yend, DEFINE.Round(deltaTime * Velocity.X), DEFINE.Round(deltaTime * Velocity.Y));
            DEFINE.ECollideOutSide eCollide = isCollideOutSide();
            if (eCollide == DEFINE.ECollideOutSide.Left || eCollide == DEFINE.ECollideOutSide.Right)
            {
                Velocity = new Point(Velocity.X * -1, Velocity.Y);
            }
            else if (eCollide == DEFINE.ECollideOutSide.Top || eCollide == DEFINE.ECollideOutSide.Bottom)
            {
                Velocity = new Point(Velocity.X, Velocity.Y * -1);
            }

            pHead.X = xhead;
            pHead.Y = yhead;
            pEnd.X = xend;
            pEnd.Y = yend;
            UpdateMidPoint();
            Draw();
        }

        public override DEFINE.ECollideOutSide isCollideOutSide()
        {
            if ((pHead.X > Bm.Size.Width || pEnd.X > Bm.Size.Width) && Velocity.X > 0)
                return DEFINE.ECollideOutSide.Right;
            else if ((pHead.X < 0 || pEnd.X < 0) && Velocity.X < 0)
                return DEFINE.ECollideOutSide.Left;
            else if ((pHead.Y > Bm.Size.Height || pEnd.Y > Bm.Size.Height) && Velocity.Y > 0)
                return DEFINE.ECollideOutSide.Bottom;
            else if ((pHead.Y < 0 || pEnd.Y < 0) && Velocity.Y < 0)
                return DEFINE.ECollideOutSide.Top;
            return DEFINE.ECollideOutSide.None;
        }

        public override void Draw()
        {
            DrawLines.DrawLine(PHead.X, PHead.Y, PEnd.X, PEnd.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
        }

        

        private void UpdateMidPoint()//cập nhật trung điểm
        {
            Point pMid = new Point(DEFINE.Round((pHead.X + pEnd.X) / 2.0), DEFINE.Round((pHead.Y + pEnd.Y) / 2.0));
            Position = pMid;
        }
    }
}
