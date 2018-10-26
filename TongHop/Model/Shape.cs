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
        protected Point position; // vị trí của hình
        private Color color; // màu 
        private Point velocity; // vận tốc
        private Bitmap bm; // đệm vẽ
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

        public virtual void Translate(double deltaTime) // tịnh tiến
        {
            // lấy vị trí hiện tại
            int x = position.X; 
            int y = position.Y;
            // xoá hình cũ
            Erase();
            // tịnh tiến vị trí hiệnt tại
            Transform.Translate(ref x, ref y, DEFINE.Round(deltaTime * velocity.X), DEFINE.Round(deltaTime * velocity.Y));
            
            // kiểm tra va chạm biên
            DEFINE.ECollideOutSide eCollide = isCollideOutSide();
            if (eCollide == DEFINE.ECollideOutSide.Left || eCollide == DEFINE.ECollideOutSide.Right)
            {
                velocity.X *= -1;
            }
            else if (eCollide == DEFINE.ECollideOutSide.Top || eCollide == DEFINE.ECollideOutSide.Bottom)
            {
                velocity.Y *= -1;
            }
            // cập nhật giá trị mới
            position.X = x;
            position.Y = y;
            // vẽ mới
            Draw();

        }
        public virtual void Rotate(Point I, double angle) // quay hình với tâm và góc
        {
            Erase(); // xoá hình cũ
            Transform.Rotate<Point>(ref position, x => x.X, x => x.Y, I.X, I.Y, -angle); // angle âm vì 0y bm >< 0xy
            Draw(); // vẽ mới
        }
        public abstract void Draw(); // vẽ hình
        public virtual void Erase() // xoá hình
        {
            Color mColor = color;
            color = Color.White;
            Draw();
            color = mColor;
        } 
        public virtual DEFINE.ECollideOutSide isCollideOutSide() // kiểm tra va chạm biên bảng vẽ
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
        public virtual void MultiVel(int n, int speedbase) // thay vector vận tốc với  độ lớn = n * tốc độ cơ bản. bảo toàn hướng
        {
            Point newVel = new Point();
            double sizeVel = Math.Sqrt(Velocity.X * Velocity.X + Velocity.Y * Velocity.Y);//độ lớn vận tốc hiện tại
            int nOld = DEFINE.Round(sizeVel / speedbase);
            // cập nhật vận tốc mới
            if (nOld == 0)
            {
                //newVel = new Point(n * oldVelocity.X, n * oldVelocity.Y);// xem lại
                nOld = DEFINE.Round(Math.Sqrt(oldVelocity.X * oldVelocity.X + oldVelocity.Y * oldVelocity.Y) / speedbase); 
                newVel = new Point(DEFINE.Round(n * (oldVelocity.X / nOld)),DEFINE.Round(n * (oldVelocity.Y / nOld)));
            }
            else
            {
                oldVelocity = velocity;
                newVel = new Point(DEFINE.Round(n * (Velocity.X / nOld)),
                        DEFINE.Round(n * (Velocity.Y / nOld)));
            }
            Velocity = newVel;
        }



        protected Point oldVelocity = new Point(1, 1); // van toc truoc khi = 0
    }
}
