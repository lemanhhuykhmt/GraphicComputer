using System;
using System.Collections.Generic;
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
    }
}
