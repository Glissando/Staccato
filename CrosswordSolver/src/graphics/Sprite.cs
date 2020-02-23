using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Priority_Queue;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Sprite
    {
        [MoonSharpHidden]
        public Texture2D texture;
        Vector2 pos;
        //The depth of a layer. By default, 0 represents the front layer and 1 represents a back layer.
        //Use SpriteSortMode if you want sprites to be sorted during drawing.
        public float layer = 0.0f;
        Drawable parent;
        Effect effect;
        Table shaderProperties;
        public bool visible;

        [MoonSharpHidden]
        public void Load(String filename, EditorWindow window)
        {
            texture = window.Editor.Content.Load<Texture2D>(filename);
        }

        public void SetShader(String shaderId,Table properties)
        {
            this.shaderProperties = properties;
            foreach(DynValue x in properties.Keys)
            {
                
            }
        }

        public void Draw(SpriteBatch batch)
        {
            effect.CurrentTechnique.Passes[0].Apply();
            batch.Draw(texture,pos);
        }

        public void Destroy()
        {

        }
    }
}
