using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using Microsoft.Xna.Framework.Input;
using System.Windows.Forms;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Game
    {
        #if EDITOR
        [MoonSharpHidden]
        public EditorWindow window;
        [MoonSharpHidden]
        Form1 form;
        #else
        #endif
        public StateManager state;
        public InputManager input;
        public Debug debug;
        public TimeManager timer;
        public Loader loader;
        public ObjectFactory add;
        public Keys keys;

        public Game(Form1 form)
        {
            input = new InputManager(window, this);
            state = new StateManager(this);
            timer = new TimeManager(this);
            loader = new Loader(this);
            debug = new Debug();
            this.form = form;
            TextBox box = (TextBox)form.Controls.Find("console", false)[0];
            debug.console = box;
        }

        public Sprite AddSprite(String filename)
        {
            Sprite sprite = new Sprite();
            sprite.Load(filename, window);
            return sprite;
        }

        public void Close()
        {
            
        }
    }
}
