using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LunarDevKit.Classes.Zones
{
    using Point=System.Drawing.Point;

    public class CircleZone : Zone
    {
        #region Fields

        private int radius;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the radius of the circle.
        /// </summary>
        public int Radius
        {
            get { return radius; }
            set { radius = Helper.Max( value, 1 ); }
        }

        /// <summary>
        /// Gets the x coordinate of the left edge of the region.
        /// </summary>
        public override int Left
        {
            get { return X - Radius; }
        }
        /// <summary>
        /// Gets the x coordinate of the right edge of the region.
        /// </summary>
        public override int Right
        {
            get { return X + Radius; }
        }
        /// <summary>
        /// Gets the y coordinate of the top edge of the region.
        /// </summary>
        public override int Top
        {
            get { return Y - Radius; }
        }
        /// <summary>
        /// Gets the y coordinate of the bottom edge of the region.
        /// </summary>
        public override int Bottom
        {
            get { return Y + Radius; }
        }

        #endregion

        #region Constructors

        public CircleZone( Color zoneColor ) : base( zoneColor )
        {
            this.X = this.Y = 0;
            this.Radius = 1;
        }

        public CircleZone( Color zoneColor, int x, int y, int radius ) : base( zoneColor )
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        #endregion

        #region Methods

        public override bool Contains( int x, int y )
        {
            return ( x >= Left && x <= Right ) && ( y >= Top && y <= Bottom );
        }

        /// <summary>
        /// Increase the circle's size by a given amount.
        /// </summary>
        public void Inflate( int amount )
        {
            Radius += amount;
        }

        /// <summary>
        /// Moves the region by a given amount.
        /// </summary>
        public override void Offset( int xAmount, int yAmount )
        {
            X += xAmount;
            Y += yAmount;
        }
        /// <summary>
        /// Moves the region by a given amount.
        /// </summary>
        public override void Offset( Point amount )
        {
            X += amount.X;
            Y += amount.Y;
        }
        /// <summary>
        /// Moves the region by a given amount.
        /// </summary>
        public override void Offset( Vector2 amount )
        {
            X += (int)amount.X;
            Y += (int)amount.Y;
        }

        #endregion

        #region

        public override void Draw( Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch )
        {
            
        }

        #endregion
    }
}
