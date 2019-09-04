using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class TimeManager
    {
        List<Timer> timers;
        public const float SECOND = 1.0f;
        public const float HALF_SECOND = 0.5f;
        public const float QUARTER_SECOND = 0.25f;
        Game game;

        public Timer this[int index]
        {
            get { return timers[index];  }
            set { timers[index] = value; }
        }

        public TimeManager(Game game)
        {
            timers = new List<Timer>();
            this.game = game;
        }

        public void Add(DynValue function, float time)
        {
            var timer = new Timer(function, time);
            timers.Add(timer);
            timer.manager = this;
        }

        public void Add(DynValue function, float time, bool repeat, int repeatCount, params DynValue[] args)
        {
            var timer = new Timer(function, time, repeat, repeatCount, args);
            timers.Add(timer);
            timer.manager = this;
        }

        public void Remove(Timer timer)
        {
            timers.Remove(timer);
        }
        
        public void Clear()
        {

        }

        public void Update(float dt)
        {
            for(int i=0;i<timers.Count;i++)
            {
                timers[i].Update(dt);
                if (timers[i].IsFinished())
                {
                    timers.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
