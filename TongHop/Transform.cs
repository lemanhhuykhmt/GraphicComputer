using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TongHop
{
    class Transform
    {
        public static void Translate(ref int x, ref int y, int tx, int ty)
        {
            x += tx;
            y += ty;
        }
        public static void Rotate(ref int x, ref int y, int xr, int yr, double angle)
        {
            int x1 = (int)(xr + (x - xr) * Math.Cos(angle) - (y - yr) * Math.Sin(angle));
            int y1 = (int)(yr + (x - xr) * Math.Sin(angle) + (y - yr) * Math.Cos(angle));
            x = x1;
            y = y1;
        }
        public static void Rotate<T>(ref T target, Expression<Func<T, int>> x, Expression<Func<T, int>> y, int xr, int yr, double angle)
        {
            Object t = target;
            var exprX = (MemberExpression) x.Body;
            var propX = (PropertyInfo)exprX.Member;
            var exprY = (MemberExpression)y.Body;
            var propY = (PropertyInfo)exprY.Member;
            int X = Convert.ToInt32(propX.GetValue(target));
            int Y = Convert.ToInt32(propY.GetValue(target));
            int x1 = (int)(xr + (X - xr) * Math.Cos(angle) - (Y - yr) * Math.Sin(angle));
            int y1 = (int)(yr + (X - xr) * Math.Sin(angle) + (Y - yr) * Math.Cos(angle));
            propX.SetValue(t, x1);
            propY.SetValue(t, y1);
            target = (T)t;
        }
        public static void Scale(ref int x, ref int y, int sx, int sy)
        {
            x *= sx;
            y *= sy;
        }
    }
}
