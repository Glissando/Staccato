using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Signal
    {
        List<Callback> callbacks;
        bool halt = false;

        public Signal()
        {
            callbacks = new List<Callback>();
        }

        public void Add(DynValue function, params DynValue[] args)
        {
            callbacks.Add(new Callback(function,args));
        }

        public void AddOnce(DynValue function, params DynValue[] args)
        {
            callbacks.Add(new Callback(function, args, true));
        }

        public void Remove(Callback callback)
        {
            callbacks.Remove(callback);
        }

        public void Halt()
        {
            halt = true;
        }

        public void Invoke()
        {
            for(int i = 0; i < callbacks.Count; i++)
            {
                callbacks[i].Invoke();
                if (callbacks[i].remove)
                {
                    callbacks.RemoveAt(i);
                    i--;
                }

                if(halt == true)
                {
                    halt = false;
                    return;
                }
            }
        }

        public void RemoveAll()
        {
            callbacks.Clear();
        }
    }
}
