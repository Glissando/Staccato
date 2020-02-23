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
    public class ObjectFactory
    {

        public Sprite Sprite()
        {
            return new Sprite();
        }

        public Vector2 Vector2(float x, float y)
        {
            return new Vector2(x, y);
        }
    }
}
