using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    abstract class Shape
    {
        protected Point position;
        private Color color;
        private Point velocity;
        private Bitmap bm;
        public Point Velocity { get => velocity; set => velocity = value; }
        public Color Color { get => color; set => color = value; }
        public Point Position { get => position; set => position = value; }
        public ref Bitmap Bm { get => ref bm; }

        private Shape()
        {
            position = new Point(0, 0);
            color = Color.Red;
            velocity = new Point(0, 0);
        }
        public Shape(ref Bitmap bm)
        {
            this.Bm = bm;
        }
        public Shape(Point pos, Color col, Point vel, ref Bitmap bm)
        {
            position = pos;
            color = col;
            velocity = vel;
            this.Bm = bm;
        }

        public void Translate(double deltaTime)
        {
            int x = position.X;
            int y = position.Y;
            Erase();
            // các tính toán bên trong đối tượng (vd: cập nhật vị trí)
            Transform.Translate(ref x, ref y, DEFINE.Round(deltaTime * velocity.X), DEFINE.Round(deltaTime * velocity.Y));
            DEFINE.ECollideOutSide eCollide = isCollideOutSide();
            if (eCollide == DEFINE.ECollideOutSide.Left || eCollide == DEFINE.ECollideOutSide.Right)
            {
                velocity.X *= -1;
            }
            else if (eCollide == DEFINE.ECollideOutSide.Top || eCollide == DEFINE.ECollideOutSide.Bottom)
            {
                velocity.Y *= -1;
            }

            position.X = x;
            position.Y = y;
            Draw();
        }
        public virtual void Rotate(Point I, double angle)
        {
            Erase();
            Transform.Rotate<Point>(ref position, x => x.X, x => x.Y, I.X, I.Y, -angle);
            Draw();
        }
        public abstract void Draw();
        public void Erase()
        {
            Color mColor = color;
            color = Color.White;
            Draw();
            color = mColor;
        }
        public virtual DEFINE.ECollideOutSide isCollideOutSide()
        {
            if (position.X > bm.Size.Width && velocity.X > 0)
                return DEFINE.ECollideOutSide.Right;
            else if (position.X < 0 && velocity.X < 0)
                return DEFINE.ECollideOutSide.Left;
            else if (position.Y > bm.Size.Height && velocity.Y > 0)
                return DEFINE.ECollideOutSide.Bottom;
            else if (position.Y < 0 && velocity.Y < 0)
                return DEFINE.ECollideOutSide.Top;
            return DEFINE.ECollideOutSide.None;
        }
        public void MultiVel(int n, int speedbase) //Vel * n
        {
            Point newVel = new Point();
            double sizeVel = Math.Sqrt(Velocity.X * Velocity.X + Velocity.Y * Velocity.Y);
            int nOld = DEFINE.Round(sizeVel / speedbase);
            if (nOld == 0)
            {
                newVel = new Point(n * oldVelocity.X, n * oldVelocity.Y);
            }
            else
            {
                oldVelocity = velocity;
                newVel = new Point(DEFINE.Round(n * (Velocity.X / nOld)),
                        DEFINE.Round(n * (Velocity.Y / nOld)));
            }
            Velocity = newVel;
        }



        private Point oldVelocity = new Point(1, 1); // van toc truoc khi = 0
    }
}
