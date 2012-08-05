using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;

namespace LunarEngine
{
    public static class Sound
    {
        internal static GameManager GameManager;

        internal static AudioEngine AudioEngine;
        private static List<WaveBank> WaveBanks = new List<WaveBank>( );
        private static Dictionary<string, SoundBank> SoundBanks = new Dictionary<string, SoundBank>( );

        public static void PlaySound( string soundBank, string soundName )
        {
            Cue cue = GetSoundCue( soundBank, soundName );
            if( cue != null )
                cue.Play( );
        }

        public static void PauseSound( string soundBank, string soundName )
        {
            Cue cue = GetSoundCue( soundBank, soundName );
            if( cue != null )
                cue.Pause( );
        }

        public static void ResumeSound( string soundBank, string soundName )
        {
            Cue cue = GetSoundCue( soundBank, soundName );
            if( cue != null )
                cue.Resume( );
        }

        public static void StopSound( string soundBank, string soundName )
        {
            Cue cue = GetSoundCue( soundBank, soundName );
            if( cue != null )
                cue.Stop( AudioStopOptions.AsAuthored );
        }



        private static Cue GetSoundCue( string soundBank, string soundName )
        {
            if( SoundBanks.ContainsKey( soundBank ) )
                return SoundBanks[soundBank].GetCue( soundName );
            return null;
        }

        internal static void AddWaveBank( string filename )
        {
            if( AudioEngine == null )
                throw new Exception( "AudioEngine needs to be initialized!" );

            WaveBanks.Add( new WaveBank( AudioEngine, filename ) );
        }

        internal static void AddSoundBank( string filename )
        {
            if( AudioEngine == null )
                throw new Exception( "AudioEngine needs to be initialized!" );

            SoundBanks.Add( System.IO.Path.GetFileNameWithoutExtension( filename ), new SoundBank( AudioEngine, filename ) );
        }

        internal static void Update( )
        {
            if( AudioEngine != null )
                AudioEngine.Update( );
        }

        internal static void Dispose( )
        {
            foreach( SoundBank soundBank in SoundBanks.Values )
                soundBank.Dispose( );

            foreach( WaveBank waveBank in WaveBanks )
                waveBank.Dispose( );

            AudioEngine.Dispose( );
        }
    }
}
