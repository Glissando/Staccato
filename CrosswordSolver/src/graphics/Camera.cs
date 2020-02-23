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
    class Camera
    {
        Vector2 position;
        SpriteBatch batch;
        float width;
        float height;
        Rect viewport;
        RenderTarget2D renderTarget;
        GraphicsDevice device;
        Color backgroundColor;

        public Camera(SpriteBatch batch)
        {
            this.batch = batch;
        }

        public Camera(GraphicsDevice device)
        {
            renderTarget = new RenderTarget2D(device,
                device.PresentationParameters.BackBufferWidth,
                device.PresentationParameters.BackBufferHeight,
                false,
                device.PresentationParameters.BackBufferFormat,
                DepthFormat.Depth24);
        }

        public void Render(Drawable[] drawables)
        {
            batch.Begin();
            
            for(int i = 0; i < drawables.Length; i++)
            {
                Drawable sprite = drawables[i];

                if (viewport.Intersects(sprite.GetPosition())) {
                    sprite.Draw(batch);
                }
            }

            batch.End();
        }

        public Texture2D Render(Drawable[] drawables, Texture2D texture)
        {
            device.SetRenderTarget(renderTarget);

            device.DepthStencilState = new DepthStencilState() { DepthBufferEnable = true };

            device.Clear(backgroundColor);

            Render(drawables);

            device.SetRenderTarget(null);

            return (Texture2D)renderTarget;
        }
    }
}
