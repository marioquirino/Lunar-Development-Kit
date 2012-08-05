using System;
using Microsoft.Xna.Framework;

namespace LunarEngine
{
    public struct RectangleF
    {
        #region Fields

        private float x;
        private float y;
        private float width;
        private float height;

        private float right;
        private float bottom;

        #endregion Fields

        #region Properties

        public float X
        {
            get { return x; }
            set
            {
                x = value;
                right = x + width;
            }
        }

        public float Y
        {
            get { return y; }
            set
            {
                y = value;
                bottom = y + height;
            }
        }

        public float Width
        {
            get { return width; }
            set
            {
                width = value;
                right = x + width;
            }
        }

        public float Height
        {
            get { return height; }
            set
            {
                height = value;
                bottom = y + height;
            }
        }

        public float Right
        {
            get { return right; }
            set
            {
                right = value;
                width = right - x;
            }
        }

        public float Bottom
        {
            get { return bottom; }
            set
            {
                bottom = value;
                height = bottom - y;
            }
        }

        #endregion Properties

        #region Constructors

        public RectangleF( float X, float Y, float Width, float Height )
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
            right = X + Width;
            bottom = Y + Height;
        }

        #endregion Constructors

        #region Methods

        public Rectangle ToRectangle( )
        {
            return new Rectangle( (int)x, (int)y, (int)width, (int)height );
        }

        public bool Contains( float X, float Y )
        {
            return (X > this.x) && (X < this.right) && (Y > this.y) && (Y < this.bottom);
        }

        public bool Contains( Vector2 point )
        {
            return Contains( point.X, point.Y );
        }

        public RectangleF Union( RectangleF rect1, RectangleF rect2 )
        {
            RectangleF tempRect = new RectangleF( );

            if( rect1.x < rect2.x )
                tempRect.x = rect1.x;
            else
                tempRect.x = rect2.x;

            if( rect1.right > rect2.right )
                tempRect.right = rect1.right;
            else
                tempRect.right = rect2.right;

            tempRect.width = tempRect.right - tempRect.x;


            if( rect1.y < rect2.y )
                tempRect.y = rect1.y;
            else
                tempRect.y = rect2.y;

            if( rect1.bottom > rect2.bottom )
                tempRect.bottom = rect1.bottom;
            else
                tempRect.bottom = rect2.bottom;

            tempRect.height = tempRect.bottom - tempRect.y;
            return tempRect;
        }

        public static bool IsCollision( RectangleF r2, RectangleF r1 )
        {
            return (r1.X + r1.Width >= r2.X && r1.Y + r1.Height >= r2.Y && r1.X <= r2.X + r2.Width && r1.Y <= r2.Y + r2.Height);
        }

        #endregion Methods
    } 
}
