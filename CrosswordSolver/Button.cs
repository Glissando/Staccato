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
    public class Button : GUIObject
    {
        Sprite sprite;
        public Signal onDown;
        public Signal onHover;
        public Signal onUp;
        public Signal onExit;
        
        public Button(UIManager manager)
        {
            this.manager = manager;
            input = manager.game.input;
            hovering = false;
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
            else if(hovering)
            {
                hovering = false;
                onExit.Invoke();
            }

            if(down && input.pointer.LeftButtonReleased())
            {
                down = false;
                onUp.Invoke();
            }
        }

    }
}
