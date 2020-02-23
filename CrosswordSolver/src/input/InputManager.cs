using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using Microsoft.Xna.Framework.Input;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class InputManager
    {
        public Game game;

        [MoonSharpHidden]
        public EditorWindow window;
        public Keyboard keyboard;
        public Pointer pointer;

        public InputManager(EditorWindow window, Game game)
        {
            this.window = window;
            this.game = game;
            keyboard = new Keyboard(this);
            pointer = new Pointer(this);
        }

        public void Update(KeyboardState keyboard)
        {
            this.keyboard.keyState = keyboard;
        }
    }
}
