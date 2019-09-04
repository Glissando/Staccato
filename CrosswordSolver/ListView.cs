using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class ListView : GUIObject
    {
        List<Item> items;
        int currentIndex;

        public Signal onDown;
        public Signal onHover;
        public Signal onUp;
        public Signal onExit;
        public Signal onValueChange;
    }
}
