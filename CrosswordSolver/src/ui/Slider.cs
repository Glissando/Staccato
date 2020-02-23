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
    class Slider : GUIObject
    {
        public float value;
        public float ballX;

        Sprite ball;
        Sprite slider;

        public Signal onDown;
        public Signal onHover;
        public Signal onUp;
        public Signal onExit;
        public Signal onValueChange;

        public void SetValue(float value)
        {
            this.value = value;
            onValueChange.Invoke();
        }

        public new void Update(float dt)
        {
            Vector2 mousePosition = input.pointer.Position;

            if (geometry.Intersects(mousePosition))
            {
                if (!hovering)
                {
                    hovering = true;
                    onHover.Invoke();
                }

                if (input.pointer.LeftButtonPressed())
                {
                    onDown.Invoke();
                    down = true;
                }
            }
            else if (hovering)
            {
                hovering = false;
                onExit.Invoke();
            }

            if (down && input.pointer.LeftButtonReleased())
            {
                down = false;
                onUp.Invoke();
                onValueChange.Invoke();
            }
        }
    }
}

