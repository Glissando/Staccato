using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Tween
    {
        TweenManager manager;
        float x;
        float xt;
        float from;
        float to;
        float time;
        float t;
        ScriptFunctionDelegate<float> interpolator;

        public Tween(TweenManager manager)
        {
            this.manager = manager;
        }

        public void Update(float dt)
        {
            if(interpolator != null)
            {

            }
            else
            {
                t = Math.Min(t + dt, time);
                x = (to - from) * (t / time);
            }
        }
    }
}
