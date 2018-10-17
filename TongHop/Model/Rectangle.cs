using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class Rectangle : Shape
    {
        private int width;
        private int height;
        private Point direction;
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Point Direction { get => direction; set => direction = value; }

        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private void getABCD()
        {
            double alpha = DEFINE.DirToRad(direction);

            A = new Point(Position.X - DEFINE.Round(width / 2), Position.Y - DEFINE.Round(height / 2));
            Transform.Rotate<Point>(ref A, x => x.X, x => x.Y, Position.X, Position.Y, alpha);

            B = new Point(Position.X + DEFINE.Round(width / 2), Position.Y - DEFINE.Round(height / 2));
            Transform.Rotate<Point>(ref B, x => x.X, x => x.Y, Position.X, Position.Y, alpha);

            C = new Point(Position.X + DEFINE.Round(width / 2), Position.Y + DEFINE.Round(height / 2));
            Transform.Rotate<Point>(ref C, x => x.X, x => x.Y, Position.X, Position.Y, alpha);

            D = new Point(Position.X - DEFINE.Round(width / 2), Position.Y + DEFINE.Round(height / 2));
            Transform.Rotate<Point>(ref D, x => x.X, x => x.Y, Position.X, Position.Y, alpha);

        }
        public Rectangle(ref Bitmap bm) : base(ref bm)
        {
        }

        

       

        public override void Draw()
        {
            // toạ độ pbdraw nên
            int yDir = direction.Y;
            direction = new Point(direction.X, -direction.Y);
            getABCD();
            DrawLines.DrawLine(A.X, A.Y, B.X, B.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
            DrawLines.DrawLine(C.X, C.Y, B.X, B.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
            DrawLines.DrawLine(C.X, C.Y, D.X, D.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
            DrawLines.DrawLine(A.X, A.Y, D.X, D.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
            DrawLines.DrawLine(position.X, position.Y, position.X + direction.X, position.Y + direction.Y, Color, ref Bm, DEFINE.EChooseLine.Midpoint);
            direction = new Point(direction.X, yDir);
        }



        public override void Rotate(Point I, double angle)
        {
            Erase();
            // toạ độ pbdraw nên
            //angle *= -1;
            Transform.Rotate<Point>(ref position, x => x.X, x => x.Y, I.X, I.Y, -angle);
            double alpha = DEFINE.DirToRad(direction);
            alpha = alpha + angle;
            direction = DEFINE.RadToDir(alpha, DEFINE.Round(Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y)));
            Draw();
        }

        public override DEFINE.ECollideOutSide isCollideOutSide()
        {
            int halfWidth = DEFINE.Round(width / 2);
            int halfHeight = DEFINE.Round(height / 2);
            if (position.X  + halfWidth > Bm.Size.Width && Velocity.X > 0)
                return DEFINE.ECollideOutSide.Right;
            else if (position.X - halfWidth < 0 && Velocity.X < 0)
                return DEFINE.ECollideOutSide.Left;
            else if (position.Y + halfHeight > Bm.Size.Height && Velocity.Y > 0)
                return DEFINE.ECollideOutSide.Bottom;
            else if (position.Y - halfHeight < 0 && Velocity.Y < 0)
                return DEFINE.ECollideOutSide.Top;
            return DEFINE.ECollideOutSide.None;
        }

        
    }
}
