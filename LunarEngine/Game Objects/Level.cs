using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine.Collections;

namespace LunarEngine
{
    public class Level : IDisposable
    {
        #region Structs

        private struct ActorToCreate
        {
            public Actor Actor;
            public bool PlaceOnTop;
            public Layer Layer;

            public ActorToCreate( Actor actor, bool placeOnTop, Layer layer )
            {
                this.Actor = actor;
                this.PlaceOnTop = placeOnTop;
                this.Layer = layer;
            }
        }

        #endregion

        #region Fields

        private LunarGame _game;
        internal LunarGame Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public Input Input
        {
            get { return _game.Input; }
        }

        public Camera Camera
        {
            get { return _game.Camera; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private StringKeyPool<Layer> _layers;
        internal StringKeyPool<Layer> Layers
        {
            get { return _layers; }
        }

        private Layer _lastAddedLayer;
        internal Layer LastAddedLayer
        {
            get { return _lastAddedLayer; }
        }


        /// <summary>
        /// Actors that are going to be created in the beginning of the Update call
        /// </summary>
        private Pool<ActorToCreate> _actorsToCreate;
        /// <summary>
        /// Actors that were created during the creation of actors in the _actorsToCreate list. They will be added in the next Update call.
        /// </summary>
        private Pool<ActorToCreate> _actorsInQueue;
        private Pool<Actor> _actorsToDestroy;

        #endregion
        
        #region Init

        public Level( )
        {
            _layers = new StringKeyPool<Layer>( );
            _actorsToCreate = new Pool<ActorToCreate>( );
            _actorsInQueue = new Pool<ActorToCreate>( );
            _actorsToDestroy = new Pool<Actor>( );
        }

        #endregion
        
        #region Methods

        internal void NewLayer( Layer layer )
        {
            if( !_layers.ContainsKey( layer.Name ) )
            {
                layer.Container = this;
                _layers.Add( layer.Name, layer );
                _lastAddedLayer = layer;
            }
        }

        internal void LevelUpdate( GameTime gameTime )
        {
            if( _actorsToDestroy.Count > 0 )
            {
                foreach( Actor actor in _actorsToDestroy )
                    DeleteActor( actor );

                _actorsToDestroy.Clear( );
            }

            if( _actorsInQueue.Count > 0 )
            {
                foreach( ActorToCreate actor in _actorsInQueue )
                {
                    _actorsToCreate.Add( actor );
                }
                _actorsInQueue.Clear( );
            }

            if( _actorsToCreate.Count > 0 )
            {
                foreach( ActorToCreate actor in _actorsToCreate )
                {
                    actor.Layer.AddActor( actor.Actor, actor.PlaceOnTop );

                    actor.Actor.Init( );
                }

                _actorsToCreate.Clear( );
            }

            Update( gameTime );

            foreach( Layer layer in _layers.Values )
            {
                foreach( Actor actor in layer.Actors )
                {
                    actor.Update( gameTime );
                }
            }
        }

        internal void LevelDraw( SpriteBatch spriteBatch )
        {
            foreach( Layer layer in _layers.Values )
            {
                layer.Draw( spriteBatch );
            }

            Draw( spriteBatch );
        }

        public void Dispose( )
        {

        }


        private void DeleteActor( Actor actor )
        {
            foreach( Layer layer in _layers.Values )
            {
                foreach( Actor actor2 in layer.Actors )
                {
                    if( actor2 == actor )
                    {
                        layer.RemoveActor( actor );
                        actor.End( );
                        return;
                    }
                }
            }
        }

        #endregion

        #region Public Methods

        #region NewActor Overloads
        private Actor NewActor( ActorType actorType )
        {
            Actor actor = null;

            if( actorType.ScriptName != GameManager.NO_SCRIPT )
            {
                Type type = _game.GameManager.GetClassType( actorType.ScriptName );

                if( type != null )
                    actor = Activator.CreateInstance( type ) as Actor;
            }

            if( actor == null )
            {
                if( actorType.IsTextActor )
                    actor = new TextActor( );
                else
                    actor = new Actor( );
            }

            actor.Name = actorType.Name;
            actor.Scale = actorType.Scale;
            actor.Rotation = actorType.Rotation;
            actor.Visible = true;

            if( actorType.IsTextActor )
            {
                TextActor textActor = actor as TextActor;
                if( _game.LoadFont( actorType.FontName ) )
                {
                    textActor.Font = _game.Fonts[actorType.FontName];
                    textActor.Text = actorType.Text;
                    textActor.TextColor = actorType.TextColor;
                }
            }
            else
            {
                if( _game.LoadSprite( actorType.SpriteName ) )
                {
                    actor.Sprite = _game.Sprites[actorType.SpriteName];
                    actor.Origin = new Vector2( actor.Sprite.Texture.Width * 0.5f, actor.Sprite.Texture.Height * 0.5f );
                }
            }

            return actor;
        }

        public Actor NewActor( string actorTypeName, float x, float y )
        {
            if( _game.ActorTypes.ContainsKey( actorTypeName ) )
            {
                ActorType actorType = _game.ActorTypes[actorTypeName];

                Actor actor = NewActor( actorType );
                actor.Position = new Vector2( x, y );

                _actorsInQueue.Add( new ActorToCreate( actor, true, _lastAddedLayer ) );

                return actor;
            }

            return null;
        }

        public Actor NewActor( string actorTypeName, float x, float y, bool placeOnTop )
        {
            if( _game.ActorTypes.ContainsKey( actorTypeName ) )
            {
                ActorType actorType = _game.ActorTypes[actorTypeName];

                Actor actor = NewActor( actorType );
                actor.Position = new Vector2( x, y );

                _actorsInQueue.Add( new ActorToCreate( actor, placeOnTop, _lastAddedLayer ) );

                return actor;
            }

            return null;
        }

        public Actor NewActor( string actorTypeName, float x, float y, string layerName )
        {
            if( _game.ActorTypes.ContainsKey( actorTypeName ) && _layers.ContainsKey( layerName ) )
            {
                ActorType actorType = _game.ActorTypes[actorTypeName];

                Actor actor = NewActor( actorType );
                actor.Position = new Vector2( x, y );

                _actorsInQueue.Add( new ActorToCreate( actor, true, _layers[layerName] ) );

                return actor;
            }

            return null;
        }

        public Actor NewActor( string actorTypeName, float x, float y, bool placeOnTop, string layerName )
        {
            if( _game.ActorTypes.ContainsKey( actorTypeName ) && _layers.ContainsKey( layerName ) )
            {
                ActorType actorType = _game.ActorTypes[actorTypeName];

                Actor actor = NewActor( actorType );
                actor.Position = new Vector2( x, y );

                _actorsInQueue.Add( new ActorToCreate( actor, placeOnTop, _layers[layerName] ) );

                return actor;
            }
            
            return null;
        }
        #endregion

        public void DestroyActor( Actor actor )
        {
            _actorsToDestroy.Add( actor );
        }

        public Texture2D GetSprite( string spriteName )
        {
            return _game.GetSprite( spriteName );
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
