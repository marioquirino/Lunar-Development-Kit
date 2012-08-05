using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine.Collections;

namespace LunarEngine
{
    public class Layer
    {
        #region Fields

        private bool _visible;
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        private float _scale;
        public float Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            internal set { _name = value; }
        }

        private Pool<Actor> _actors;
        internal Pool<Actor> Actors
        {
            get { return _actors; }
        }

        private Level _container;
        internal Level Container
        {
            get { return _container; }
            set { _container = value; }
        }

        #endregion

        #region Init

        public Layer( string name )
        {
            _actors = new Pool<Actor>( );
            _name = name;
            _visible = true;
            _scale = 1f;
        }

        #endregion

        #region Methods

        internal void Draw( SpriteBatch spriteBatch )
        {
            if( _visible )
            {
                foreach( Actor actor in _actors )
                {
                    actor.ActorDraw( spriteBatch );
                }
            }
        }

        internal void AddActor( Actor actor )
        {
            actor.Container = this;
            _actors.Add( actor );
        }

        internal void AddActor( Actor actor, bool placeOnTop )
        {
            actor.Container = this;
            if( placeOnTop )
                _actors.Add( actor );
            else
                _actors.Insert( 0, actor );
        }

        /// <summary>
        /// Adds a new actor to the layer. It will be placed right beneath of another given actor.
        /// </summary>
        internal void AddActor( Actor actor, Actor actorAbove )
        {
            actor.Container = this;
            _actors.Insert( _actors.IndexOf( actorAbove ), actor );
        }

        internal void RemoveActor( Actor actor )
        {
            _actors.Remove( actor );
            actor.Container = null;
        }

        #endregion
    }
}
