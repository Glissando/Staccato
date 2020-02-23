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
    public class Projector
    {
        float projectionAngle = 0;
        Vector2 anchor = new Vector2(0, 0);
        float[] transform;

        public static float CLASSIC = (float)Math.Atan(0.5);
        public static float ISOMETRIC = (float)(Math.PI / 6);
        public static float MILITARY = (float)(Math.PI / 4);
        
        public Projector()
        {
            transform = new[] { (float)Math.Cos(projectionAngle), (float)Math.Sin(projectionAngle) };
        }

        public Vector2 Project(Vector3 point)
        {
            Vector2 xy = new Vector2();

            xy.X = (point.X - point.Y) * transform[0];
            xy.Y = ((point.X + point.Y) * transform[1]) + point.Z;


            return xy;
        }

        public Vector2 ProjectXY(Vector3 point)
        {
            Vector2 xy = new Vector2();

            xy.X = (point.X - point.Y) * transform[0];
            xy.Y = ((point.X + point.Y) * transform[1]);

            return xy;
        }

        public Vector3 Unproject(Vector2 point, float z = 0)
        {
            Vector3 xyz = new Vector3();

            float x = point.X;
            float y = point.Y;

            xyz.X = x / (2 * transform[0]) + y / (2 * transform[1]);
            xyz.Y = -(x / (2 * transform[0])) + y / (2 * transform[1]);
            xyz.Z = z;

            return xyz;
        }
    }
}
