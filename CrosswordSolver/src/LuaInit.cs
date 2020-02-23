using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    //handles the setup and initialization of the main lua script and the scripting API
    class LuaInit
    {
        public static Game game;
        public static Script Start(Form1 form)
        {
            UserData.RegisterAssembly();
            
            EditorWindow window = (EditorWindow)form.Controls.Find("inspector", false)[0];
            game = new Game(form);
            Script.DefaultOptions.DebugPrint = s => game.debug.Log(s);
            Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion<Script>(v => DynValue.NewTable(v));
            //Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion<Vector2>(v => new Table(;
            UserData.RegisterType<Vector2>();
            UserData.RegisterExtensionType(typeof(Vector2));
            game.window = window;
            return game.loader.LoadScript("main", "main");
        }
    }
}
