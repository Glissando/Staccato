using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Debug
    {
        [MoonSharpHidden]
        public TextBox console;
        [MoonSharpHidden]
        int lineCount = 1;

        public void Log(String message)
        {
            console.AppendText(String.Format("{0}: " + message, lineCount));
            console.AppendText(Environment.NewLine);
            lineCount++;
        }

        public void Clear()
        {
            console.Clear();
            lineCount = 0;
        }
    }
}
