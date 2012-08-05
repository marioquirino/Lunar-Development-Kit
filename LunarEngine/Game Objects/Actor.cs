using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine.Collections;

namespace LunarEngine
{
    public class Actor
    {
        #region Fields

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private Vector2 _pos;
        public Vector2 Position
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public float X
        {
            get { return _pos.X; }
            set { _pos.X = value; }
        }

        public float Y
        {
            get { return _pos.Y; }
            set { _pos.Y = value; }
        }

        private float _scale;
        public float Scale
        {
            get { return _scale; }
            set { _scale = Math.Max( value, 0.01f ); }
        }

        private Vector2 _origin;
        public Vector2 Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        private float _rotation;
        public float Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        private bool _visible;
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Sprite _sprite;
        internal Sprite Sprite
        {
            get { return _sprite; }
            set { _sprite = value; }
        }

        public Texture2D Texture
        {
            get { return _sprite.Texture; }
        }

        private Layer _container;
        public Layer Container
        {
            get { return _container; }
            internal set
            {
                if( _container != null )
                    _container.Actors.Remove( this );
                _container = value;
            }
        }

        public Level ActiveLevel
        {
            get { return _container.Container.Game.ActiveLevel; }
        }

        public Input Input
        {
            get { return _container.Container.Input; }
        }

        public Camera Camera
        {
            get { return _container.Container.Camera; }
        }

        

        private StringKeyPool<bool> _tags = new StringKeyPool<bool>( );

        #endregion

        #region Methods

        internal virtual void ActorDraw( SpriteBatch spriteBatch )
        {
            if( _visible && _sprite != null )
            {
                spriteBatch.Draw( _sprite.Texture, _pos, null, Color.White, _rotation, _origin, _scale, SpriteEffects.None, 0f );
            }
            Draw( spriteBatch );
        }

        internal void CopyValues( Actor actor )
        {
            actor._id = _id;
            actor._name = _name;
            actor._pos = _pos;
            actor._origin = _origin;
            actor._scale = _scale;
            actor._rotation = _rotation;
            actor._visible = _visible;
            actor._sprite = _sprite;

            actor._tags.Clear( );
            foreach( string tag in _tags.Keys )
            {
                actor._tags.Add( tag, false );
            }
        }

        #endregion

        #region Public Methods

        public Texture2D GetSprite( string spriteName )
        {
            return _container.Container.GetSprite( spriteName );
        }
        public Texture2D GetSprite( Actor actor )
        {
            return actor.Sprite.Texture;
        }

        public void AddTag( string tag )
        {
            _tags.Add( tag, false );
        }

        public void RemoveTag( string tag )
        {
            _tags.Remove( tag );
        }

        public bool HasTag( string tag )
        {
            return _tags.ContainsKey( tag );
        }

        public void Destroy( )
        {
            ActiveLevel.DestroyActor( this );
        }

        #endregion

        #region C# Script Events

        public virtual void Init( ) { }

        public virtual void Update( GameTime gameTime ) { }

        public virtual void Draw( SpriteBatch spriteBatch ) { }

        public virtual void End( ) { }

        #endregion
    }
}
