using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace CrosswordSolver
{
    public class Keyboard
    {
        InputManager manager;
        Dictionary<String, List<Keys>> actions;
        public KeyboardState keyState;
        public KeyboardState previousState;

        public Keyboard(InputManager manager)
        {
            this.manager = manager;
        }

        public bool IsDown(Keys key)
        {
            return keyState.IsKeyDown(key);
        }

        public bool IsDown(String key)
        {
            if (actions.ContainsKey(key))
            {
                List<Keys> keys = actions[key];
                foreach (Keys k in keys)
                {
                    if (keyState.IsKeyUp(k))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsUp(Keys key)
        {
            return keyState.IsKeyDown(key);
        }

        public bool isUp(String key)
        {
            if (actions.ContainsKey(key))
            {
                List<Keys> keys = actions[key];
                foreach(Keys k in keys)
                {
                    if (keyState.IsKeyUp(k))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Update(KeyboardState state)
        {

        }
    }
}
