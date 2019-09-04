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
    interface Drawable
    {
        void Draw(SpriteBatch batch);
        Vector2 GetPosition();
    }
    
    [MoonSharpUserData]
    class Group : Drawable
    {
        Vector2 position;
        List<Sprite> sprites;

        public Group()
        {
            sprites = new List<Sprite>();
        }

        public void Draw(SpriteBatch batch)
        {
            foreach(Sprite s in sprites)
            {
                s.Draw(batch);
            }
        }

        public Vector2 GetPosition()
        {
            return position;
        }
    }
}
