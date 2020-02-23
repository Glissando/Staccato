using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class TweenManager
    {
        List<Spring> springs;
        List<Tween> tweens;

        
        public void AddSpring()
        {

        }

        public void AddTween()
        {

        }

        [MoonSharpHidden]
        public void Update(float dt)
        {
            UpdateSprings(dt);
            UpdateTweens(dt);
        }

        void UpdateSprings(float dt)
        {
            foreach(Spring s in springs)
            {
                s.Update(dt);
            }
        }

        void UpdateTweens(float dt)
        {
            foreach(Tween t in tweens)
            {
                t.Update(dt);
            }
        }
    }
}
