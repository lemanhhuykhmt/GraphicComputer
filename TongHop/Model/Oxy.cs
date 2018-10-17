using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHop.Model
{
    class Oxy : Shape
    {
        public Oxy(ref Bitmap bm) : base(ref bm)
        {
        }

        public Oxy(Point pos, Color col, Point vel, ref Bitmap bm) : base(pos, col, vel, ref bm)
        {

        }

        public override void Draw()
        {
            Point O = position;
            for(int x = 0; x < Bm.Width; x++)
            {
                Bm.SetPixel(x, O.Y, Color);
            }
            for(int y = 0; y < Bm.Height; ++y)
            {
                Bm.SetPixel(O.X, y, Color);
            }
        }
    }
}
