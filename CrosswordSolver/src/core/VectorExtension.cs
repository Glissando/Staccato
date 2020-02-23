using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CrosswordSolver
{
    public static class VectorExtension
    {
        public static float Distance(this Vector2 a, Vector2 b)
        {
            return (float)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public static float Dot(this Vector2 a, Vector2 b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static Vector2 Normal(this Vector2 a)
        {
            return new Vector2(-a.Y, a.X);
        }

    }
}
