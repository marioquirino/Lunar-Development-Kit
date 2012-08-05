using System;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarEngine;
using LunarDevKit.Controls;

namespace LunarDevKit.Classes
{
    public class ActorEd
    {
        #region Fields

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if( AddedToLevel )
                {
                    string oldValue = _name;
                    _name = value;

                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "Name", oldValue, _name ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                    Global.Properties.UpdateTitle( );

                    return;
                }

                _name = value;
            }
        }

        private Vector2 _pos;
        public Vector2 Position
        {
            get { return _pos; }
            set 
            {
                if( AddedToLevel )
                {
                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "Position", _pos, value ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                }

                _pos = value;
                UpdateBounds( );
            }
        }

        private float _scale;
        public float Scale
        {
            get { return _scale; }
            set 
            {
                if( AddedToLevel )
                {
                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "Scale", _scale, Math.Max( value, 0.01f ) ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                }

                _scale = Math.Max( value, 0.01f );
                UpdateBounds( );
            }
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
            set 
            {
                if( AddedToLevel )
                {
                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "Rotation", _rotation, value ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                }

                _rotation = value;
            }
        }

        private bool _visible;
        public bool Visible
        {
            get { return _visible; }
            set
            {
                if( AddedToLevel )
                {
                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "Visible", _visible, value ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                }

                _visible = value;
            }
        }

        private SpriteEd _sprite;
        public SpriteEd Sprite
        {
            get { return _parent.SpriteAsset.Sprite; }
        }

        private string[] _tags;
        public string[] Tags
        {
            get { return _tags; }
            set
            {
                if( AddedToLevel )
                {
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                }

                _tags = value;
            }
        }


        private ActorTypeEd _parent;
        public ActorTypeEd Parent
        {
            get { return _parent; }
        }

        private LayerEd _container;
        public LayerEd Container
        {
            get { return _container; }
            set
            {
                if( _container != null )
                    _container.Actors.Remove( this );
                _container = value;
            }
        }

        private RectangleF _bounds;
        public RectangleF Bounds
        {
            get { return _bounds; }
        }

        public Vector2 WorldOrigin
        {
            get { return new Vector2( _pos.X - _origin.X * _scale, _pos.Y - _origin.Y * _scale ); }
        }

        private ActorProperties _properties;
        public ActorProperties Properties
        {
            get { return _properties; }
        }

        public bool AddedToLevel = false;

        #region TextActor-related

        public bool IsTextActor
        {
            get { return _parent.IsTextActor; }
        }
        
        public FontAssetItem FontAsset
        {
            get { return _parent.FontAsset; }
        }

        public SpriteFont Font
        {
            get { return _parent.FontAsset.Font.SpriteFont; }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                if( AddedToLevel )
                {
                    string oldValue = _text;
                    _text = value;
                    UpdateBounds( );

                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "Text", oldValue, _text ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );

                    return;
                }

                _text = value;
            }
        }

        private Color _textColor;
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                if( AddedToLevel )
                {
                    Global.UndoProvider.StoreAction( new PropertyChangeAction( this, "TextColor", _textColor, value ) );
                    Global.MainWindow.OnLevelChanged( _container.Container.Parent );
                }

                _textColor = value;
            }
        }

        #endregion

        #region Other

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }

        #endregion

        #endregion

        #region Constructor

        public ActorEd( ActorTypeEd parent )
        {
            _parent = parent;
            _name = "Actor";
            _visible = true;
            _bounds = new RectangleF( 0f, 0f, 1f, 1f );

            _properties.Actor = this;

            parent.SpriteChanged += new EventHandler( parent_SpriteChanged );
            parent.RotationChanged += new EventHandler( parent_RotationChanged );
            parent.ScaleChanged += new EventHandler( parent_ScaleChanged );

            parent.IsTextActorChanged += new EventHandler( parent_IsTextActorChanged );
            parent.TextChanged += new EventHandler( parent_TextChanged );
            parent.TextColorChanged += new EventHandler( parent_TextColorChanged );
        }

        #endregion

        #region Event Methods

        private void parent_SpriteChanged( object sender, EventArgs e )
        {
            UpdateBounds( );
        }

        private void parent_RotationChanged( object sender, EventArgs e )
        {
            _rotation = Parent.Rotation;
        }

        private void parent_ScaleChanged( object sender, EventArgs e )
        {
            _scale = Parent.Scale;
            UpdateBounds( );
        }



        private void parent_IsTextActorChanged( object sender, EventArgs e )
        {
            _text = Parent.Text;
            _textColor = Parent.TextColor;
            UpdateBounds( );
        }

        private void parent_TextChanged( object sender, EventArgs e )
        {
            _text = Parent.Text;
            UpdateBounds( );
        }

        private void parent_TextColorChanged( object sender, EventArgs e )
        {
            _textColor = Parent.TextColor;
        }

        #endregion

        #region Methods

        public ActorEd Clone( )
        {
            ActorEd actor = new ActorEd( _parent );
            actor._origin = this._origin;
            actor._pos = this._pos;
            actor._scale = this._scale;
            actor._rotation = this._rotation;
            actor._sprite = this._sprite;
            actor._visible = this._visible;
            actor._text = this._text;
            actor._textColor = this._textColor;
            actor._name = this._name;
            actor._id = this._id;

            actor.UpdateBounds( );

            return actor;
        }

        public void Draw( SpriteBatch spriteBatch )
        {
            if( IsTextActor )
            {
                if( !string.IsNullOrEmpty( _text ) )
                    spriteBatch.DrawString( Font, _text, _pos, _textColor, _rotation, _origin, _scale, SpriteEffects.None, 0f );
            }
            else
                spriteBatch.Draw( Sprite, _pos, null, Color.White, _rotation, _origin, _scale, SpriteEffects.None, 0f );
            
            if( _isSelected && Global.Tools.IsSelectionMode )
            {
                ActorSelectionBox.SetProperties( Bounds );
                ActorSelectionBox.Draw( spriteBatch );
            }
        }

        public void UpdateBounds( )
        {
            Vector2 pos;
            if( !IsTextActor )
            {
                pos = WorldOrigin;
                _bounds = new RectangleF( pos.X, pos.Y, Sprite.Width * _scale, Sprite.Height * _scale );
            }
            else
            {
                if( !string.IsNullOrEmpty( Text ) )
                {
                    Vector2 textSize = Font.MeasureString( Text );
                    _origin = new Vector2( textSize.X * 0.5f, textSize.Y * 0.5f );
                    pos = WorldOrigin;
                    _bounds = new RectangleF( pos.X, pos.Y, textSize.X * _scale, textSize.Y * _scale );
                }
            }
                    
        }

        #endregion
    }



    public struct ActorProperties : IEdObject, IComponent
    {
        public ActorEd Actor;

        #region IComponent Fields

        public event EventHandler Disposed;

        [Browsable( false )]
        public ISite Site
        {
            get { return new Classes.PropertyGridStuff.DesignerVerbSite( this ); }
            set { throw new NotImplementedException( ); }
        }

        public void Dispose( )
        {
            if( Disposed != null )
                Disposed( this, EventArgs.Empty );
        }

        #endregion

        [Browsable( true )]
        public void TagEditor( )
        {
            string[] tags = new Forms.TagEditor( ).ShowDialog( Actor.Tags );
            if( tags != null && tags.Length > 0 )
                Actor.Tags = tags;
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorName )]
        public string Name
        {
            get { return Actor.Name; }
            set {  Actor.Name = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorPosition )]
        public Vector2 Position
        {
            get { return Actor.Position; }
            set { Actor.Position = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorScale )]
        public float Scale
        {
            get { return Actor.Scale; }
            set { Actor.Scale = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorRotation )]
        public float Rotation
        {
            get { return Actor.Rotation * Helper.RADTODEG; }
            set { Actor.Rotation = value * Helper.DEGTORAD; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorVisible )]
        public bool Visible
        {
            get { return Actor.Visible; }
            set { Actor.Visible = value; }
        }





        [CategoryAttribute( Consts.PropsDescriptions.CategoryText ),
        Description( Consts.PropsDescriptions.ActorText )]
        public string Text
        {
            get { return Actor.Text; }
            set { Actor.Text = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryText ),
        Description( Consts.PropsDescriptions.ActorTextColor )]
        public Color TextColor
        {
            get { return Actor.TextColor; }
            set { Actor.TextColor = value; }
        }
    }
}
