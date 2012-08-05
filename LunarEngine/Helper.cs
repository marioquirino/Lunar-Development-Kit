using System;
using Microsoft.Xna.Framework;

namespace LunarEngine
{
    using math=System.Math;

    public static class Helper
    {
        internal static Vector2 ScreenToWorldPosition( Camera cam, Vector2 point )
        {
            if( cam == null )
                return Vector2.Zero;

            Matrix mx = Matrix.Invert( cam.View );
            return Vector2.Transform( point, mx );
        }

        public static Vector2 ScreenToWorldPosition( Camera cam, float x, float y )
        {
            return ScreenToWorldPosition( cam, new Vector2( x, y ) );
        }

        public static float AngleBetweenPoints( Vector2 point1, Vector2 point2 )
        {
            return (float)math.Atan2( point2.Y - point1.Y, point2.X - point1.X );
        }

        public static float DistanceBetweenPoints( Vector2 point1, Vector2 point2 )
        {
            float dx = point1.X - point2.X;
            float dy = point1.Y - point2.Y;
            return (float)math.Sqrt( dx * dx + dy * dy );
        }
    }
}
