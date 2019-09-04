using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Rect
    {
        Rectangle rect;

        public bool Intersects(Vector2 point)
        {
            return rect.Contains(point);
        }

        public bool Intersects(Rectangle rectangle)
        {
            return rect.Intersects(rectangle);
        }
    }
}
