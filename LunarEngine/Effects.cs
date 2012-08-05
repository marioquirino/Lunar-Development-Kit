using System;
using System.IO;
using Microsoft.Xna.Framework;
using ProjectMercury;
using ProjectMercury.Renderers;

namespace LunarEngine
{
    public static class Effects
    {
        private static bool noEffects = false;

        private static ParticleEffectManager effects = new ParticleEffectManager( );
        private static Renderer _renderer;
        internal static Renderer Renderer
        {
            get { return _renderer; }
            set
            {
                _renderer = value;
                effects.Renderer = value;
            }
        }

        internal static void LoadEffects( GameManager gm )
        {
            if( !Directory.Exists( gm.effectsFolder ) )
            {
                noEffects = true;
                return;
            }

            Renderer.LoadContent( gm.Content );

            string[] files = Directory.GetFiles( gm.effectsFolder );

            foreach( string file in files )
            {
                string name = Path.GetFileNameWithoutExtension( file );

                try
                {
                    ParticleEffect effect = gm.Content.Load<ParticleEffect>( Path.Combine( "Effects", name ) );
                    effect.LoadContent( gm.Content );
                    effect.Initialise( );
                    effects.Add( effect, name );
                }
                catch { }
            }
        }

        internal static void Update( GameTime gameTime )
        {
            if( !noEffects )
                effects.Update( gameTime );
        }

        internal static void Draw( ref Matrix transform )
        {
            if( !noEffects )
                effects.Draw( ref transform );
        }

        public static void TriggerEffect( string fxName, Vector2 position )
        {
            if( !noEffects && effects.ContainsEffect( fxName ) )
                effects[fxName].Trigger( position );
        }
    }
}
