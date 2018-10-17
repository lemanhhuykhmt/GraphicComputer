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
                Point pMid = new Point(DEFINE.Round((pHead.X + pEnd.X) / 2.0), DEFINE.Round((pHead.Y + pEnd.Y) / 2.0));
                Position = pMid;
            }
        }
        public Point PEnd
        {
            get => pEnd;
            set
            {
                pEnd = value;
                Point pMid = new Point(DEFINE.Round((pHead.X + pEnd.X) / 2.0), DEFINE.Round((pHead.Y + pEnd.Y) / 2.0));
                Position = pMid;
            }
        }
        public Line(ref Bitmap bm) : base(ref bm)
        {

        }

        public Line(Point head, Point end, Color col, Point vel, ref Bitmap bm) : base(head, col, vel, ref bm)
        {
            PHead = head;
            PEnd = end;
            
            Point pMid = new Point(DEFINE.Round((head.X + end.X) / 2.0), DEFINE.Round((head.Y + end.Y) / 2.0));
            Position = pMid;
        }

        public override void Rotate(Point I, double angle)
        {
            base.Rotate(I, angle);
            this.Erase();
            Transform.Rotate<Point>(ref pHead, x => x.X, x => x.Y, I.X, I.Y, -angle);
            Transform.Rotate<Point>(ref pEnd, x => x.X, x => x.Y, I.X, I.Y, -angle);
            this.Draw();
        }

        public override void Draw()
        {
            DrawLines.DrawLine(PHead.X, PHead.Y, PEnd.X, PEnd.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
        }

        public int Length()
        {
            int len = 0;
            len = DEFINE.Round(Math.Sqrt((pHead.X - pEnd.X) * (pHead.X - pEnd.X) + (pHead.Y - pEnd.Y) * (pHead.Y - pEnd.Y)));
            return len;
        }
    }
}
