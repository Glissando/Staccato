using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    [MoonSharpUserData]
    public class Cache
    {
        Dictionary<String,Texture2D> textures;
        Dictionary<String,Song> music;
        Dictionary<String,SoundEffect> audio;
        Dictionary<String,Script> scripts;
        Dictionary<String,Effect> shaders;

        public Cache()
        {
            textures = new Dictionary<String, Texture2D>();
            music = new Dictionary<String, Song>();
            audio = new Dictionary<String, SoundEffect>();
            scripts = new Dictionary<String, Script>();
            shaders = new Dictionary<String, Effect>();
        }

        public Texture2D GetTexture(String id)
        {
            return textures[id];
        }
        
        public Song GetMusic(String id)
        {
            return music[id];
        }

        public SoundEffect GetAudio(String id)
        {
            return audio[id];
        }

        public Script GetScript(String id)
        {
            return scripts[id];
        }

        public Effect GetEffect(String id)
        {
            return shaders[id];
        }

        public void SetTexture(String id, Texture2D texture)
        {
            textures[id] = texture;
        }
        
        public void SetScript(String id, Script script)
        {
            scripts[id] = script;
        }

        public void SetAudio(String id, SoundEffect audio)
        {
            this.audio[id] = audio;
        }

        public void SetMusic(String id, Song music)
        {
            this.music[id] = music;
        }
        public void SetEffect(String id, Effect effect)
        {
            shaders.Add(id, effect);
        }
    }
}
