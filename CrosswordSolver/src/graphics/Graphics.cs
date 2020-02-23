using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    class Graphics
    {
        SpriteBatch batch;
        GraphicsDevice device;
        private Texture2D pixel;

        public Graphics(Game game, EditorWindow window)
        {
            batch = window.Editor.spriteBatch;
            device = window.Editor.graphics;
            createPixel();
        }

        void createPixel()
        {
            Texture2D pixel = new Texture2D(device, 1, 1);
            pixel.SetData(new Color[] { Color.White });
        }
        /*
        private void DrawPoints(Vector2 position, List<Vector2> points, Color color, float thickness)
        {
            if (points.Count < 2)
                return;

            for (int i = 1; i < points.Count; i++)
            {
                DrawLine(batch, points[i - 1] + position, points[i] + position, color, thickness);
            }
        }
        
        public void DrawLine(Vector2 point1, Vector2 point2, Color color, float thickness)
        {
            // calculate the distance between the two vectors
            float distance = Vector2.Distance(point1, point2);

            // calculate the angle between the two vectors
            float angle = (float)Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);

            DrawLine(batch, point1, distance, angle, color, thickness);
        }

        public static void DrawLine(Vector2 point, float length, float angle, Color color, float thickness)
        {
            if (pixel == null)
            {
                CreateThePixel(spriteBatch);
            }

            // stretch the pixel between the two vectors
            spriteBatch.Draw(pixel,
                             point,
                             null,
                             color,
                             angle,
                             Vector2.Zero,
                             new Vector2(length, thickness),
                             SpriteEffects.None,
                             0);
        }

        public void DrawRect()
        {

        }

        public void DrawCircle()
        {

        }

        public void DrawPolygon()
        {

        }*/
    }
}
