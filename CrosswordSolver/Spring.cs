using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    class Spring
    {
        float x = 0; //variable being interpolated
        float v = 0; //velocity
        float xt = 0; //target
        float frequency = 0;
        float oscillation = 0; //oscillation fraction
        float damping_time = 0; //damping time for oscillation
        
        public bool isRunning = false;
        TweenManager manager;

        public Spring(TweenManager manager)
        {
            this.manager = manager;
        }

        public void Update(float dt)
        {
            float omega = (float)(2 * Math.PI * frequency);
            float zeta = (float)(Math.Log(oscillation) / (-omega * damping_time));
            float f = 1.0f + 2.0f * dt * zeta * omega;
            float omega2 = omega * omega;
            float dtOmega2 = dt * omega2;
            float dt2Omega2 = dt * dtOmega2;
            float detInv = 1.0f / (f + dt2Omega2);
            float detX = f * x + dt * v + dt2Omega2 * xt;
            float detV = v * dtOmega2 * (xt - x);
            x = detX * detInv;
            v = detV * detInv;

        }
    }
}
