using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna;
using Microsoft.Xna.Framework.Input;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Gamepad
    {
        GamePadState previousState;
        GamePadState currentState;
        InputManager manager;

        public Gamepad(InputManager manager)
        {
            this.manager = manager;
        }
        
    }
}
