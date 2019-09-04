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
    class Polygon : Geometry
    {
        List<Vector2> points;

        public Polygon()
        {
            points = new List<Vector2>();
        }

        public float Area()
        {
            float area = 0;


            return area;
        }

        public bool Intersects(Vector2 point)
        {
            Vector2[] norms = getNormals();

            for(int i = 0; i < norms.Length; i++)
            {
                if(norms[i].Dot(point) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        public Vector2[] getNormals()
        {
            Vector2[] norms = new Vector2[points.Count - 1];

            for(int i = 0; i < points.Count - 1; i++)
            {
                norms[i] = (points[i+1] - points[i]).Normal();
            }

            return norms;
        }

    }
}
