using System;
using Microsoft.Xna.Framework;
using FarseerPhysics.DebugViewXNA;
using FarseerPhysics.Dynamics;

namespace LunarEngine
{
    public static class Physics
    {
        private static bool _updateWorld = false;

        public static World World { get; internal set; }

        public static void StartWorldUpdate( )
        {
            _updateWorld = true;
        }

        public static void StopWorldUpdate( )
        {
            _updateWorld = false;
        }

        internal static void Update( float dt )
        {
            if( _updateWorld )
                World.Step( dt );
        }
    }
}
