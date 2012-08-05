using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine;

namespace LunarDevKit.Classes.Zones
{
    using Point=System.Drawing.Point;

    public abstract class Zone
    {
        #region Fields

        public int X;
        public int Y;

        public Color FillColor;
        public Color BorderColor;

        #endregion

        #region Properties

        public abstract int Left
        { get; }
        public abstract int Right
        { get; }
        public abstract int Top
        { get; }
        public abstract int Bottom
        { get; }

        #endregion

        #region Constructor

        public Zone( Color zoneColor )
        {
            this.FillColor = new Color( zoneColor, Consts.Zones.FILL_COLOR_OPACITY );
            this.BorderColor = zoneColor;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Verifies if this zone contains a given RectangleZone.
        /// </summary>
        public virtual bool Contains( RectangleZone region )
        {
            return Contains( region.X, region.Y ) && Contains( region.Width, region.Height );
        }
        /// <summary>
        /// Verifies if this zone contains a given CircleZone.
        /// </summary>
        public virtual bool Contains( CircleZone region )
        {
            return region.Left >= Left && region.Right <= Right && region.Top >= Top && region.Bottom <= Bottom;
        }
        /// <summary>
        /// Verifies if this zone contains a given rectangle.
        /// </summary>
        public virtual bool Contains( Rectangle rectangle )
        {
            return Contains( rectangle.X, rectangle.Y ) && Contains( rectangle.Width, rectangle.Height );
        }
        /// <summary>
        /// Verifies if this zone contains a given rectangleF
        /// </summary>
        /// <param name="rectangle"></param>
        /// <returns></returns>
        public virtual bool Contains( RectangleF rectangle )
        {
            return Contains( (int)rectangle.X, (int)rectangle.Y ) && Contains( (int)rectangle.Width, (int)rectangle.Height );
        }
        /// <summary>
        /// Verifies if this zone contains a given Point.
        /// </summary>
        public virtual bool Contains( Point point )
        {
            return Contains( point.X, point.Y );
        }
        /// <summary>
        /// Verifies if this zone contains a given Vector2.
        /// </summary>
        public virtual bool Contains( Vector2 point )
        {
            return Contains( (int)point.X, (int)point.Y );
        }
        public abstract bool Contains( int x, int y );

        public virtual bool Intersects( RectangleZone zone )
        {
            return Contains( zone.X, zone.Y ) || Contains( zone.Width, zone.Height );
        }
        public virtual bool Intersects( CircleZone zone )
        {
            return false;
        }
        public virtual bool Intersects( Rectangle rectangle )
        {
            return Contains( rectangle.X, rectangle.Y ) || Contains( rectangle.Width, rectangle.Height );
        }
        public virtual bool Intersects( RectangleF rectangle )
        {
            return Contains( (int)rectangle.X, (int)rectangle.Y ) || Contains( (int)rectangle.Width, (int)rectangle.Height );
        }

        public abstract void Offset( int xAmount, int yAmount );
        public abstract void Offset( Point amount );
        public abstract void Offset( Vector2 amount );

        public abstract void Draw( SpriteBatch spriteBatch );

        #endregion
    }
}
