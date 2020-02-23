using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Callback
    {
        Closure function;
        DynValue[] arguments;
        public bool remove {get; private set; }

        public Callback(DynValue function, DynValue[] arguments, bool remove = false)
        {
            this.function = function.Function;
            this.arguments = arguments;
            this.remove = remove;
        }

        public void Invoke()
        {
            function.Call(arguments);
        }
    }
}
