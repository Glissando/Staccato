using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using MoonSharp.Interpreter;

namespace CrosswordSolver
{
    class Audioclip
    {
        float volume;
        SoundEffect sound;
        SoundEffectInstance instance;
        Audio audio;

        public Audioclip(SoundEffect sound, Audio audio)
        {
            this.sound = sound;
            this.audio = audio;
            instance = sound.CreateInstance();
        }

        public Audioclip(String soundId, Audio audio)
        {
            this.audio = audio;
            instance = sound.CreateInstance();
        }

        public void SetVolume(float volume)
        {
            this.volume = volume;
        }

        public void Play()
        {
            instance.Play();
        }

        public void Stop()
        {
            instance.Stop();
        }
    }
}
