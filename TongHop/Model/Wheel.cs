using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class Wheel : Shape
    {
        private double speedRotate;
        private List<Shape> component;
        public List<Shape> Component
        {
            get { return component; }
            private set { }
        }

        public double SpeedRotate { get => speedRotate; set => speedRotate = value; }

        public Wheel(ref Bitmap bm) : base(ref bm)
        {

            component = new List<Shape>();
        }

        public Wheel(Point pos, int r, Color col, Point vel, double rotate, ref Bitmap bm) : base(pos, col, vel, ref bm)
        {
            component = new List<Shape>();
            component.Add(new Circle(ref bm)
            {
                Position = pos,
                Color = col,
                Velocity = vel,
                Radius = r
            });
            component.Add(new Line(ref bm)
            {
                PHead = pos,
                PEnd = new Point(pos.X, pos.Y - r),
                Color = col,
                Velocity = vel
            });
            component.Add(new Line(ref bm)
            {
                PHead = pos,
                PEnd = new Point(pos.X, pos.Y + r),
                Color = col,
                Velocity = vel
            });
            component.Add(new Line(ref bm)
            {
                PHead = pos,
                PEnd = new Point(pos.X + r, pos.Y),
                Color = col,
                Velocity = vel
            });
            component.Add(new Line(ref bm)
            {
                PHead = pos,
                PEnd = new Point(pos.X - r, pos.Y),
                Color = col,
                Velocity = vel
            });
            speedRotate = rotate;
        }

        public override void Draw()
        {
            foreach(var item in component)
            {
                item.Draw();
            }
        }

        public override DEFINE.ECollideOutSide isCollideOutSide()
        {
            return component[0].isCollideOutSide();
        }

        public override void Rotate(Point I, double angle)
        {
            base.Rotate(position, -angle);
            foreach(var item in component)
            {
                item.Erase();
                item.Rotate(position, -angle);
                item.Draw();
            }
            
        }

        public void Rotate ()
        {
            base.Rotate(position, -speedRotate);
            foreach (var item in component)
            {
                item.Erase();
                item.Rotate(position, -speedRotate);
                item.Draw();
            }
        }

        public override void Translate(double deltaTime)
        {
            base.Translate(deltaTime);
           foreach(var item in component)
            {
                item.Erase();
                item.Translate(deltaTime);
                item.Draw();
            }
            DEFINE.ECollideOutSide eCollide = isCollideOutSide();
            if (eCollide == DEFINE.ECollideOutSide.Left || eCollide == DEFINE.ECollideOutSide.Right)
            {
                Velocity = new Point(Velocity.X * -1, Velocity.Y);
                speedRotate *= -1;
                foreach (var item in component)
                {
                    item.Velocity = new Point(Velocity.X, Velocity.Y);
                }
            }
            else if (eCollide == DEFINE.ECollideOutSide.Top || eCollide == DEFINE.ECollideOutSide.Bottom)
            {
                Velocity = new Point(Velocity.X, -1 * Velocity.Y);
                foreach (var item in component)
                {
                    item.Velocity = new Point(Velocity.X, Velocity.Y * -1);
                }
            }
        }

        public override void Erase()
        {
            base.Erase();
            Color mColor = Color;
            
            foreach(var item in component)
            {
                item.Color = Color.White;
            }
            Draw();
            foreach (var item in component)
            {
                item.Color = mColor;
            }
        }

        public override void MultiVel(int n, int speedbase)
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
                oldVelocity = Velocity;
                newVel = new Point(DEFINE.Round(n * (Velocity.X / nOld)),
                        DEFINE.Round(n * (Velocity.Y / nOld)));
            }
            Velocity = newVel;
            foreach(var item in component)
            {
                item.Velocity = Velocity;
            }
        }
    }
}
