using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop
{
    class DEFINE
    {
        public enum EChooseLine
        {
            DDA,
            Bresenham,
            Midpoint,
            Bold,
            Dash,
            Shaded
        }
        public enum EStateMouse
        {
            MouseDown,
            MouseUp
        }
        public enum EChooseCircle
        {
            Decac,
            ToaDoCuc,
            Midpoint,
            Elip
        }
        public enum ECollideOutSide
        {
            None,
            Bottom,
            Top,
            Left,
            Right
        }
        public enum EAnimation
        {
            Start,
            Running,
            Pause,
            Stop
        }
        public enum EChooseCircleMove
        {
            CircleTranslate,
            CircleRotate
        }

        public static int Round(double a)
        {
            return (int)(a >= 0 ? (a + 0.5) : (a - 0.5));
        }
        public static double DirToRad(Point direction)
        {
            double alpha = 0;
            if(direction.X == 0 && direction.Y == 0)
            {
                return 0.0;
            }
            if (direction.X == 0)
            {
                alpha = 90.0 * Math.PI / 180;
                return direction.Y > 0 ? alpha : -alpha;
            }
            else
            {
                alpha = Math.Atan(1.0 * direction.Y / direction.X);
            }
            if(direction.Y >= 0 && direction.X > 0)
            {
            }
            else if (direction.Y >= 0 && direction.X < 0)
            {
                alpha = Math.PI + alpha;
            }
            else if (direction.Y < 0 && direction.X > 0)
            {
                
            }
            else if (direction.Y < 0 && direction.X < 0)
            {
                alpha = alpha - Math.PI;
            }
            return alpha;
        }
        public static Point RadToDir(double alpha, int size = 10)
        {
            Point p = new Point();
            p.X = Round(size * Math.Cos(alpha));
            p.Y = Round(size * Math.Sin(alpha));
            return p;
        }
    }
}
