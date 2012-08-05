using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine;

namespace LunarDevKit.Classes
{
    using MathHelper=Microsoft.Xna.Framework.MathHelper;

    using Controls;
    using GraphicsHandler;

    public class CameraEd
    {
        #region Fields

        private float _zoom;
        public float Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = MathHelper.Max( value, Consts.Camera.ZOOM_OUT_MAX );
                _zoom = MathHelper.Min( _zoom, Consts.Camera.ZOOM_IN_MAX );
            }
        }

        private Vector2 _position;
        public Vector2 Position
        {
            get { return _position; }
            set
            {
                _position = value;
                _visibleArea.X = _position.X - _visibleArea.Width * 0.5f;
                _visibleArea.Y = _position.Y - _visibleArea.Height * 0.5f;
            }
        }

        private RectangleF _visibleArea;
        public RectangleF VisibleArea
        {
            get { return _visibleArea; }
        }

        public Vector2 ScreenPosition
        {
            get { return new Vector2( Parent.Width * 0.5f, Parent.Height * 0.5f ); }
        }

        private GraphicsDeviceControl _parent;
        public GraphicsDeviceControl Parent
        {
            get { return _parent; }
        }

        public Matrix View
        {
            get
            {
                Vector3 rotationOrigin = new Vector3( Position, 0f );
                Vector3 screenPos = new Vector3( ScreenPosition, 0f );

                return Matrix.CreateTranslation( -rotationOrigin ) *
                    Matrix.CreateScale( Zoom, Zoom, 1f ) *
                    Matrix.CreateTranslation( screenPos );
            }
        }

        #endregion

        #region Constructors

        public CameraEd( GraphicsDeviceControl parent, float width, float height, float zoom )
        {
            this._parent = parent;
            this._visibleArea = new RectangleF( 0, 0, width, height );
            this._zoom = zoom;
            this._position = ScreenPosition;
        }

        public CameraEd( GraphicsDeviceControl parent, float width, float height )
            : this( parent, width, height, 1f ) { }

        public CameraEd( GraphicsDeviceControl parent )
            : this( parent, parent.Width, parent.Height ) { }

        #endregion

        #region Methods

        public void Move( Vector2 amount )
        {
            Position += amount;
        }

        public void Move( float amountX, float amountY )
        {
            Vector2 pos = Position;
            pos.X += amountX;
            pos.Y += amountY;
            Position = pos;
        }

        #endregion
    }
}
