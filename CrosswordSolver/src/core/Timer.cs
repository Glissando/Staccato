using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Interop;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Timer
    {
        float t = 0; //The time passed for the current loop
        float totalTime = 0; //the total time that must be passed for a loop
        float delay; //The amount of delay before the timer can start
        float delayTime;
        bool loop; //Does this timer loop?
        int repeatCount; //How many iterations must this timer go through if it loops
        public float duration = 0.0f;
        //How many iterations has it gone through
        public int count { [MoonSharpVisible(true)] get; [MoonSharpVisible(false)] private set; }
        Closure callback;
        public TimeManager manager;
        private bool isFinished = false;
        DynValue[] arguments;

        public Timer(DynValue function, float time, bool repeat = false, int repeatCount = 0, params DynValue[] args)
        {
            totalTime = time;
            loop = repeat;
            this.repeatCount = repeatCount;
            callback = function.Function;
            arguments = args;
            
        }

        public Timer(float time)
        {
            totalTime = time;
        }

        [MoonSharpHidden]
        public void Update(float dt)
        {
            if(delay > 0 && delayTime < delay)
            {
                delayTime += dt;
                duration = delayTime + totalTime;
                return;
            }

            t += dt;
            duration = totalTime - t;

            if(t >= totalTime)
            {
                callback.Call(arguments);
                duration = totalTime;
                t = 0;
                if (loop && count < repeatCount)
                {
                    count++;
                }
                else
                {
                    isFinished = true;
                    duration = 0f;
                }
            }
        }

        public bool IsFinished()
        {
            return isFinished;
        }

    }
}
