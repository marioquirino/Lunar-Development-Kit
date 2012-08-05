using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine;

namespace LunarDevKit.Classes.Zones
{
    using Point=System.Drawing.Point;

    public class RectangleZone : Zone
    {
        #region Fields

        public int Width;
        public int Height;

        public bool DrawsFillColor = true;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the central position of this region.
        /// </summary>
        public Point Center
        {
            get { return new Point( (int)( Right * 0.5f ), (int)( Bottom * 0.5f ) ); }
            set
            {
                Point pnt = Center;
                int dx = pnt.X - value.X;
                int dy = pnt.Y - value.Y;
                X += dx;
                Y += dy;
                Width += dx;
                Height += dy;
            }
        }

        public override int Left
        {
            get { return X; }
        }
        /// <summary>
        /// Gets the x coordinate of the right edge of the region.
        /// </summary>
        public override int Right
        {
            get { return X + Width; }
        }
        public override int Top
        {
            get { return Y; }
        }
        /// <summary>
        /// Gets the y coordinate of the bottom edge of the region.
        /// </summary>
        public override int Bottom
        {
            get { return Y + Height; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new RectangleRegion.
        /// </summary>
        public RectangleZone( Color zoneColor ) : base( zoneColor )
        {
            this.X = this.Y =  this.Width = this.Height = 0;
        }
        /// <summary>
        /// Creates a new RectangleRegion specifying the x, y, width and height of the region.
        /// </summary>
        public RectangleZone( Color zoneColor, int x, int y, int width, int height ) : base( zoneColor )
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Verifies if this region contains a point, given the x and y components.
        /// </summary>
        public override bool Contains( int x, int y )
        {
            return ( x >= X && x <= Right ) && ( y >= Y && y <= Bottom );
        }

        /// <summary>
        /// Increases the width and height of the region
        /// </summary>
        public void Inflate( int xAmount, int yAmount )
        {
            Width += xAmount;
            Height += yAmount;
        }

        /// <summary>
        /// Moves the region by an offset amount
        /// </summary>
        /// <param name="xAmount">The amount of pixels the region will move along the x axis</param>
        /// <param name="yAmount">The amount of pixels the region will move along the y axis</param>
        public override void Offset( int xAmount, int yAmount )
        {
            X += xAmount;
            Y += yAmount;
            Width += xAmount;
            Height += yAmount;
        }
        /// <summary>
        /// Moves the region by an offset amount
        /// </summary>
        public override void Offset( Point amount )
        {
            X += amount.X;
            Y += amount.Y;
            Width += amount.X;
            Height += amount.Y;
        }
        /// <summary>
        /// Moves the region by an offset amount
        /// </summary>
        public override void Offset( Vector2 amount )
        {
            X += (int)amount.X;
            Y += (int)amount.Y;
            Width += (int)amount.X;
            Height += (int)amount.Y;
        }

        public void SetProperties( int X, int Y, int Width, int Height )
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }

        public void SetProperties( float X, float Y, float Width, float Height )
        {
            SetProperties( (int)X, (int)Y, (int)Width, (int)Height );
        }

        public void SetProperties( Rectangle rect )
        {
            SetProperties( rect.X, rect.Y, rect.Width, rect.Height );
        }

        public void SetProperties( RectangleF rect )
        {
            SetProperties( rect.X, rect.Y, rect.Width, rect.Height );
        }

        public RectangleZone Clone( )
        {
            RectangleZone rect = new RectangleZone( Color.White );

            rect.SetProperties( this.X, this.Y, this.Width, this.Height );
            rect.BorderColor = this.BorderColor;
            rect.FillColor = this.FillColor;
            rect.DrawsFillColor = this.DrawsFillColor;

            return rect;
        }

        #endregion

        #region Draw

        public override void Draw( SpriteBatch spriteBatch )
        {
            Draw( spriteBatch, Consts.Zones.BORDER_WIDTH );
        }

        public void Draw( SpriteBatch spriteBatch, int borderWidth )
        {
            Rectangle r = new Rectangle( );

            if ( this.Width < 0 )
                r.X = this.Right;
            else
                r.X = this.X;

            r.Width = Math.Abs( this.Width );

            if ( this.Height < 0 )
                r.Y = this.Bottom;
            else
                r.Y = this.Y;

            r.Height = Math.Abs( this.Height );

            if ( this.DrawsFillColor )
                spriteBatch.Draw( Global.Pixel, r, this.FillColor );

            
            //Draw top border
            r.Height = borderWidth;
            spriteBatch.Draw( Global.Pixel, r, this.BorderColor );

            //Draw bottom border
            if ( this.Height < 0 )
                r.Y = this.Y;
            else
                r.Y = this.Bottom;

            r.Width += borderWidth;
            spriteBatch.Draw( Global.Pixel, r, this.BorderColor );

            //Draw left border
            if ( this.Width < 0 )
                r.X = this.Right;
            else
                r.X = this.X;
            if ( this.Height < 0 )
                r.Y = this.Bottom;
            else
                r.Y = this.Y;

            r.Width = borderWidth;
            r.Height = Math.Abs( this.Height );
            spriteBatch.Draw( Global.Pixel, r, this.BorderColor );

            //Draw right border
            if ( this.Width < 0 )
                r.X = this.X;
            else
                r.X = this.Right;

            r.Height += borderWidth;
            spriteBatch.Draw( Global.Pixel, r, this.BorderColor );
        }

        #endregion
    }
}
