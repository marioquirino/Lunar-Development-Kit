using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LunarEngine
{
    public class Camera
    {
        #region Constants

        internal const float CAMERA_MAX_ZOOM = 3f;
        internal const float CAMERA_MIN_ZOOM = 0.2f;
        internal const float CAMERA_ZOOM_INCREMENT = 0.09f;
        internal const float CAMERA_ZOOM_FACTOR = 0.01f;

        #endregion

        #region Fields

        private float _rotation;
        public float Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        private float _zoom;
        public float Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = MathHelper.Max( value, CAMERA_MIN_ZOOM );
                _zoom = MathHelper.Min( _zoom, CAMERA_MAX_ZOOM );
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

        public float X
        {
            get { return _position.X; }
            set
            {
                _position.X = value;
                _visibleArea.X = _position.X - _visibleArea.Width * 0.5f;
            }
        }

        public float Y
        {
            get { return _position.Y; }
            set
            {
                _position.Y = value;
                _visibleArea.Y = _position.Y - _visibleArea.Height * 0.5f;
            }
        }

        private RectangleF _visibleArea;
        internal RectangleF VisibleArea
        {
            get { return _visibleArea; }
        }

        internal Vector2 ScreenPosition
        {
            get { return new Vector2( Viewport.Width * 0.5f, Viewport.Height * 0.5f ); }
        }

        public Matrix View
        {
            get
            {
                Vector3 rotationOrigin = new Vector3( Position, 0f );
                Vector3 screenPos = new Vector3( ScreenPosition, 0f );

                return Matrix.CreateTranslation( -rotationOrigin ) *
                    Matrix.CreateScale( Zoom, Zoom, 1f ) *
                    Matrix.CreateRotationZ( Rotation ) *
                    Matrix.CreateTranslation( screenPos );
            }
        }

        private Viewport _viewport;
        internal Viewport Viewport
        {
            get { return _viewport; }
        }

        #endregion

        #region Constructors

        public Camera( Viewport parent, float width, float height, float zoom, float rotation )
        {
            this._viewport = parent;
            this._visibleArea = new RectangleF( 0, 0, width, height );
            this._zoom = zoom;
            this._position = ScreenPosition;
            this._rotation = rotation;
        }

        public Camera( Viewport parent, float width, float height )
            : this( parent, width, height, 1f, 0f ) { }

        public Camera( Viewport parent )
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

        public void SetToActor( Actor actor )
        {
            Position = actor.Position;
        }

        #endregion
    }
}
