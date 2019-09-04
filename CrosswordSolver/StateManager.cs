using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using MonoGame.Forms.Services;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class StateManager
    {
        Dictionary<String, State> states;
        State currentState;
        public Game game;

        public StateManager(Game game)
        {
            states = new Dictionary<string, State>();
            this.game = game;
        }

        public void Add(String key, String cacheId)
        {
            State state = new State(cacheId, game);
            states.Add(key, state);
        }

        public void Start(String key)
        {
            if(currentState != null)
            {
                currentState.Shutdown();
            }

            if (states.ContainsKey(key))
            {
                currentState = states[key];
                currentState.Start();
            }
        }

        public void Clear()
        {
            states.Clear();
            currentState.Shutdown();
            currentState = null;
        }

        [MoonSharpHidden]
        public void Update(float dt)
        {
            if (currentState != null)
            {
                currentState.Update(dt);
            }
        }

        [MoonSharpHidden]
        public void Draw(MonoGameService editor)
        {
            if(currentState != null)
            {
                currentState.Draw(editor);
            }
        }
    }
}
