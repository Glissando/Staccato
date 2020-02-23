using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    public interface Geometry
    {
        bool Intersects(Vector2 point);

    }

    [MoonSharpUserData]
    public class Circle : Geometry
    {
        public float radius;
        public Vector2 position;
        
        public Circle()
        {
            radius = 1.0f;
            position = new Vector2(0, 0);
        }

        public Circle(float radius)
        {
            this.radius = radius;
            position = new Vector2(0, 0);
        }

        public Circle(float radius, Vector2 position)
        {
            this.radius = radius;
            this.position = position;
        }

        public bool Intersects(Vector2 point)
        {
            if(position.Distance(point) <= radius)
            {
                return true;
            }
            return false;
        }
    }
}
