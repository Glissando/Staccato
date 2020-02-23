using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Pointer
    {
        MouseState currentState;
        MouseState previousState;
        Vector2 currentPosition;
        Vector2 previousPosition;
        public Vector2 Position { get { return currentPosition; } private set { Position = value; } }
        public Vector2 ChangeInPosition { get { return currentPosition - previousPosition; } private set { ChangeInPosition = value; } }
        InputManager manager;

        public Pointer(InputManager manager)
        {
            this.manager = manager;
            currentPosition = new Vector2();
            previousPosition = new Vector2();
        }

        public void Update(MouseState state)
        {
            previousState = currentState;
            currentState = state;
            previousPosition = currentPosition;
            currentPosition = state.Position.ToVector2();
        }

        public bool RightButtonPressed()
        {
            if(currentState.RightButton == ButtonState.Pressed && previousState.RightButton == ButtonState.Released)
            {
                return true;
            }
            return false;
        }

        public bool RightButtonReleased()
        {
            if (currentState.RightButton == ButtonState.Released && previousState.RightButton == ButtonState.Pressed)
            {
                return true;
            }
            return false;
        }

        public bool LeftButtonPressed()
        {
            if (currentState.LeftButton == ButtonState.Pressed && previousState.LeftButton == ButtonState.Released)
            {
                return true;
            }
            return false;
        }

        public bool LeftButtonReleased()
        {
            if (currentState.LeftButton == ButtonState.Released && previousState.LeftButton == ButtonState.Pressed)
            {
                return true;
            }
            return false;
        }

        public bool MiddleButtonPressed()
        {
            if (currentState.MiddleButton == ButtonState.Pressed && previousState.MiddleButton == ButtonState.Released)
            {
                return true;
            }
            return false;
        }

        public bool MiddleButtonReleased()
        {
            if (currentState.MiddleButton == ButtonState.Released && previousState.MiddleButton == ButtonState.Pressed)
            {
                return true;
            }
            return false;
        }
    }
}
