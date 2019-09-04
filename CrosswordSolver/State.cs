using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using MonoGame.Forms.Services;

namespace CrosswordSolver
{
    public class State
    {
        Script state;
        Game game;

        public State(String cacheId, Game game)
        {
            this.game = game;
            state = game.loader.cache.GetScript(cacheId);
        }

        public void Start()
        {
            if (!state.Globals.Get("start").IsNil())
            {
                state.Call(state.Globals["start"]);
            }
        }

        public void Update(float dt)
        {
            if (state.Globals["update"] != null)
            {
               state.Call(state.Globals["update"], dt);
            }
        }

        public void Draw(MonoGameService editor)
        {
            if (!state.Globals.Get("draw").IsNil())
            {
                state.Call(state.Globals["draw"]);
            }
        }

        public void Shutdown()
        {
            if (!state.Globals.Get("shutdown").IsNil())
            {
                state.Call(state.Globals["shutdown"]);
            }
        }
    }
}
