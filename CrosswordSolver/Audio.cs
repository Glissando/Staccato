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
    class Audio
    {
        Song song;
        float masterVolume = 1.0f;
        float soundVolume = 1.0f;
        Game game;
        List<Audioclip> audioclips;

        public Audio(Game game)
        {            
            this.game = game;
            audioclips = new List<Audioclip>();
        }

        void SetVolume(float volume)
        {
            masterVolume = volume;
            MediaPlayer.Volume = volume;
        }

        void SetSoundVolume(float volume)
        {
            soundVolume = volume;
            SoundEffect.MasterVolume = volume;
        }

        public void Add(SoundEffect sound)
        {
            audioclips.Add(new Audioclip(sound, this));
        }

        public void Add(String soundId)
        {
            audioclips.Add(new Audioclip(soundId, this));
        }

        public void PlaySong(bool repeat = true)
        {
            MediaPlayer.Play(song);
            MediaPlayer.IsRepeating = repeat;
        }

        public void StopSong()
        {
            MediaPlayer.Stop();
        }

        public void SetRepeating(bool repeat)
        {
            MediaPlayer.IsRepeating = repeat;
        }
    }
}
