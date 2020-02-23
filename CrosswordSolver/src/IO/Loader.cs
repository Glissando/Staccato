using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;


namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Loader
    {
        public Cache cache;
        public Game game;
        ContentManager content;

        public Loader(Game game)
        {
            cache = new Cache();
            this.game = game;
        }

        public Script LoadScript(String id, String filename)
        {
            Script script = new Script();
            ((ScriptLoaderBase)script.Options.ScriptLoader).ModulePaths = new string[] { "Scripts/?", "Scripts/?.lua" };
            script.Options.ScriptLoader = new EmbeddedResourcesScriptLoader();
            if (Path.GetExtension(filename) == "")
            {
                script.DoFile("Scripts/" + filename + ".lua");
            }
            else
            {
                script.DoFile("Scripts/" + filename);
            }

            //Setup the Engine API
            Table globals = script.Globals;

            globals["game"] = game;
            globals["debug"] = game.debug;
            globals["input"] = game.input;
            globals["state"] = game.state;
            globals["time"] = game.timer;
            globals["loader"] = game.loader;

            cache.SetScript(id, script);
            return script;
        }

        public Texture2D LoadTexture(String id, String filename)
        {
            Texture2D texture = content.Load<Texture2D>(filename);
            cache.SetTexture(id, texture);
            return texture;
        }

        public SoundEffect LoadSoundEffect(String id, String filename)
        {
            SoundEffect soundEffect = content.Load<SoundEffect>(filename);
            cache.SetAudio(id, soundEffect);
            return soundEffect;
        }

        public Effect LoadEffect(String id, String filename)
        {
            Effect effect = content.Load<Effect>(filename);
            cache.SetEffect(id, effect);
            return effect;
        }

        public void SaveText(String directory, String text)
        {
            File.WriteAllText(directory, text);
        }

        public void SaveText(String directory, DynValue value)
        {
            SaveText(directory, value.CastToString());
        }
    }
}
