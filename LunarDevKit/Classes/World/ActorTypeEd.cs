using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Controls;

namespace LunarDevKit.Classes
{
    public class ActorTypeEd
    {
        #region Fields

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if( !ActorAdded )
                {
                    _name = value;
                    return;
                }

                if( string.IsNullOrEmpty( value ) )
                    return;

                if( Global.AssetsBrowser.ActorItems.ContainsKey( value ) )
                {
                    MessageBox.Show( Global.EditorTxt.ActorTypeWithSameNameExistsError, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                _name = value;
                string newPath = Helper.ChangeFilePathName( _filePath, _name );
                if( File.Exists( _filePath ) )
                {
                    if( File.Exists( newPath ) )
                        File.Delete( newPath );
                    File.Move( _filePath, newPath );
                }

                _filePath = newPath;
                Global.MainWindow.OnWorldChanged( );
                Global.MainWindow.OnAssetChanged( );
                Global.Properties.UpdateTitle( );

                Parent.LabelName = _name;
            }
        }

        private Vector2 _origin;
        public Vector2 Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        private float _scale;
        public float Scale
        {
            get { return _scale; }
            set 
            { 
                _scale = value;
                if( ActorAdded )
                {
                    Global.MainWindow.OnAssetChanged( );

                    if( ScaleChanged != null )
                    {
                        DialogResult result = MessageBox.Show( Global.EditorTxt.ActortypePropertyChangedPrompt, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                        if( result == DialogResult.Yes )
                            ScaleChanged( this, EventArgs.Empty );
                    }
                }
            }
        }

        private float _rotation;
        public float Rotation
        {
            get { return _rotation; }
            set 
            {
                _rotation = value;
                if( ActorAdded )
                {
                    Global.MainWindow.OnAssetChanged( );

                    if( RotationChanged != null )
                    {
                        DialogResult result = MessageBox.Show( Global.EditorTxt.ActortypePropertyChangedPrompt, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                        if( result == DialogResult.Yes )
                            RotationChanged( this, EventArgs.Empty );
                    }
                }
            }
        }

        private SpriteAssetItem _spriteAsset;
        public SpriteAssetItem SpriteAsset
        {
            get
            {
                if( _spriteAsset == null )
                    return Global.AssetsBrowser.NoSpriteItem;
                return _spriteAsset;
            }
            set
            {
                _spriteAsset = value;
                if( ActorAdded )
                {
                    Global.MainWindow.OnAssetChanged( );
                    if( SpriteChanged != null )
                        SpriteChanged( this, EventArgs.Empty );
                }
            }
        }

        private Script _script;
        public Script Script
        {
            get { return _script; }
            set
            {
                _script = value;
                if( ActorAdded )
                    Global.MainWindow.OnAssetChanged( );
            }
        }

        private string[] _tags;
        public string[] Tags
        {
            get { return _tags; }
            set
            {
                _tags = value;
                if( ActorAdded )
                    Global.MainWindow.OnAssetChanged( );
            }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private ActorAssetItem _parent;
        public ActorAssetItem Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private ActorTypeProperties _properties;
        public ActorTypeProperties Properties
        {
            get { return _properties; }
        }


        public bool ActorAdded = false;


        #region TextActor-related

        private FontAssetItem _fontAsset;
        public FontAssetItem FontAsset
        {
            get { return _fontAsset; }
            set
            {
                _fontAsset = value;

                if( ActorAdded )
                    Global.MainWindow.OnAssetChanged( );
            }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;

                if( ActorAdded )
                {
                    Global.MainWindow.OnAssetChanged( );

                    if( TextChanged != null )
                    {
                        DialogResult result = MessageBox.Show( Global.EditorTxt.ActortypePropertyChangedPrompt, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                        if( result == DialogResult.Yes )
                            TextChanged( this, EventArgs.Empty );
                    }
                }
            }
        }

        private bool _isTextActor;
        public bool IsTextActor
        {
            get { return _isTextActor; }
            set
            {
                if( value == true && _fontAsset == null && ActorAdded )
                {
                    MessageBox.Show( Global.EditorTxt.NoFontAssignedMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                _isTextActor = value;

                if( ActorAdded )
                {
                    Global.MainWindow.OnAssetChanged( );
                    if( IsTextActorChanged != null )
                        IsTextActorChanged( this, EventArgs.Empty );
                }
            }
        }

        private Color _textColor = Color.White;
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;

                if( ActorAdded )
                {
                    Global.MainWindow.OnAssetChanged( );

                    if( TextColorChanged != null )
                    {
                        DialogResult result = MessageBox.Show( Global.EditorTxt.ActortypePropertyChangedPrompt, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                        if( result == DialogResult.Yes )
                            TextColorChanged( this, EventArgs.Empty );
                    }
                }
            }
        }

        #endregion


        /// <summary>
        /// Used only during the asset loading phase
        /// </summary>
        public string TempSpriteName;
        /// <summary>
        /// Used only during the asset loading phase
        /// </summary>
        public string TempScriptName;
        /// <summary>
        /// Used only during the asset loading phase
        /// </summary>
        public string TempFontName;

        #endregion

        #region Events

        public event EventHandler SpriteChanged;
        public event EventHandler ScaleChanged;
        public event EventHandler RotationChanged;

        public event EventHandler IsTextActorChanged;
        public event EventHandler TextChanged;
        public event EventHandler TextColorChanged;

        #endregion

        public ActorTypeEd( )
        {
            _properties.ActorType = this;
        }


        #region Methods

        /// <summary>
        /// Saves the ActorType into the file
        /// </summary>
        public void Save( )
        {
            FileManager.CreateActorTypeFile( this );
        }
        /// <summary>
        /// Saves the ActorType in the specified file path
        /// </summary>
        public void Save( string filePath )
        {
            string path = this._filePath;
            this._filePath = filePath;
            Save( );
            this._filePath = path;
        }

        public ActorEd CreateActor( int id )
        {
            if( IsTextActor )
                return CreateTextActor( id );

            ActorEd actor = new ActorEd( this );
            actor.ID = id;
            actor.Scale = this._scale;
            actor.Rotation = this._rotation;
            actor.Origin = new Vector2( this.SpriteAsset.Sprite.Width * 0.5f, this.SpriteAsset.Sprite.Height * 0.5f );
            actor.Tags = new string[] { this._name };

            return actor;
        }

        public ActorEd CreateTextActor( int id )
        {
            ActorEd actor = new ActorEd( this );
            actor.ID = id;
            actor.Scale = this._scale;
            actor.Rotation = this._rotation;
            actor.Origin = Vector2.Zero;
            actor.Text = _text;
            actor.TextColor = _textColor;
            actor.UpdateBounds( );
            actor.Tags = new string[] { this._name };

            return actor;
        }

        #endregion
    }



    public struct ActorTypeProperties : IEdObject, IComponent
    {
        public ActorTypeEd ActorType;

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
            string[] tags = new Forms.TagEditor( ).ShowDialog( ActorType.Tags );
            if( tags != null && tags.Length > 0 )
                ActorType.Tags = tags;
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorTypeName )]
        public string Name
        {
            get { return ActorType.Name; }
            set { ActorType.Name = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorTypeScale )]
        public float Scale
        {
            get { return ActorType.Scale; }
            set { ActorType.Scale = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorTypeRotation )]
        public float Rotation
        {
            get { return ActorType.Rotation * Helper.RADTODEG; }
            set { ActorType.Rotation = value * Helper.DEGTORAD; }
        }

        [Category( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorTypeScript ),
        TypeConverter( typeof( PropertyGridStuff.ScriptNameConverter ) )]
        public string Script
        {
            get
            {
                if( ActorType.Script == null )
                    return null;
                return ActorType.Script.Name;
            }
            set
            {
                if( string.IsNullOrEmpty( value ) )
                {
                    ActorType.Script = null;
                    return;
                }

                if( Global.AssetsBrowser.ScriptItems.ContainsKey( value ) )
                {
                    ActorType.Script = Global.AssetsBrowser.ScriptItems[value].Script;
                    return;
                }

                if( ActorType.IsTextActor )
                    Global.AssetsBrowser.AddNewScript( value, ScriptFormat.TextActor );
                else
                    Global.AssetsBrowser.AddNewScript( value, ScriptFormat.Actor );

                ActorType.Script = Global.AssetsBrowser.LastCreatedScript.Script;
            }
        }

        [Category( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.ActorTypeSprite ),
        TypeConverter( typeof( PropertyGridStuff.SpriteNameConverter ) )]
        public string Sprite
        {
            get
            {
                if( ActorType.SpriteAsset == Global.AssetsBrowser.NoSpriteItem )
                    return null;
                return ActorType.SpriteAsset.Sprite.Name;
            }
            set
            {
                if( string.IsNullOrEmpty( value ) )
                {
                    ActorType.SpriteAsset = null;
                    return;
                }

                if( Global.AssetsBrowser.SpriteItems.ContainsKey( value ) )
                    ActorType.SpriteAsset = Global.AssetsBrowser.SpriteItems[value];
            }
        }





        [CategoryAttribute( Consts.PropsDescriptions.CategoryText ),
        Description( Consts.PropsDescriptions.ActorTypeText )]
        public string Text
        {
            get { return ActorType.Text; }
            set { ActorType.Text = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryText ),
        Description( Consts.PropsDescriptions.ActorTypeTextColor )]
        public Color TextColor
        {
            get { return ActorType.TextColor; }
            set { ActorType.TextColor = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryText ),
        Description( Consts.PropsDescriptions.ActorTypeIsTextActor )]
        public bool IsTextActor
        {
            get { return ActorType.IsTextActor; }
            set { ActorType.IsTextActor = value; }
        }

        [CategoryAttribute( Consts.PropsDescriptions.CategoryText ),
        Description( Consts.PropsDescriptions.ActorTypeFont ),
        TypeConverter( typeof( PropertyGridStuff.FontNameConverter ) )]
        public string Font
        {
            get 
            {
                if( ActorType.FontAsset != null )
                    return ActorType.FontAsset.Font.Name;

                return null;
            }
            set
            {
                if( string.IsNullOrEmpty( value ) )
                    return;

                if( !Global.AssetsBrowser.FontItems.ContainsKey( value ) )
                {
                    MessageBox.Show( Global.EditorTxt.FontDontExistError, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                ActorType.FontAsset = Global.AssetsBrowser.FontItems[value];
                Global.MainWindow.OnAssetChanged( );
            }
        }
    }
}
