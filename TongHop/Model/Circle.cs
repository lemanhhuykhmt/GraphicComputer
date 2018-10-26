using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class Circle : Shape
    {
        private int radius;
        public int Radius { get => radius; set => radius = value; }

       

        public Circle(ref Bitmap bm) : base(ref bm)
        {
            radius = 10;
        }

        public Circle(Point pos, Color col, Point vel, int r, ref Bitmap bm) : base(pos, col, vel, ref bm)
        {
            radius = r;
        }


        public override void Draw()
        {
            DrawCircles.DrawCircle(Position.X, Position.Y, radius, radius, Color, ref Bm, DEFINE.EChooseCircle.ToaDoCuc);
            //Bm.SetPixel(Position.X, Position.Y, Color);
        }
        public override DEFINE.ECollideOutSide isCollideOutSide()
        {
            if (Position.X + radius > Bm.Size.Width && Velocity.X > 0)
                return DEFINE.ECollideOutSide.Right;
            else if (Position.X - radius < 0 && Velocity.X < 0)
                return DEFINE.ECollideOutSide.Left;
            else if (Position.Y + radius > Bm.Size.Height && Velocity.Y > 0)
                return DEFINE.ECollideOutSide.Bottom;
            else if (Position.Y - radius < 0 && Velocity.Y < 0)
                return DEFINE.ECollideOutSide.Top;
            return DEFINE.ECollideOutSide.None;
        }
    }
}
