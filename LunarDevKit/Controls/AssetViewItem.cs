using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public class AssetViewItem : ListViewItem
    {
        #region Fields

        private AssetType _type;
        public AssetType Type
        {
            get { return _type; }
        }

        private ActorTypeEd _actor;
        public ActorTypeEd Actor
        {
            get { return _actor; }
            set
            {
                _actor = value;
                //this.ImageKey = _actor.Sprite.Name;
            }
        }

        private SpriteEd _sprite;
        public SpriteEd Sprite
        {
            get { return _sprite; }
            set
            {
                _sprite = value;
                this.ImageKey = _sprite.Name;
            }
        }

        private Script _script;
        public Script Script
        {
            get { return _script; }
            set { _script = value; }
        }

        private FontEd _font;
        public new FontEd Font
        {
            get { return _font; }
            set { _font = value; }
        }

        private Dictionary<string, bool> _tags;

        #endregion

        #region Init

        public AssetViewItem( AssetType type, string name )
            : base( name )
        {
            try
            {
                this._type = type;

                _tags = new Dictionary<string, bool>( );
            }
            catch( Exception e )
            {
                ErrorReport.Throw( e );
            }
        }

        /// <summary>
        /// This method initialize important properties of this object.\nBe sure to call it right after adding it to the assets list.
        /// </summary>
        public void Init( )
        {
            switch( this.Type )
            {
                case AssetType.Actor:
                    AddTag( "Actors" );
                    this.ImageKey = "*[NoSprite]*";
                    break;

                case AssetType.Sprite:
                    AddTag( "Sprites" );
                    break;

                case AssetType.Font:
                    AddTag( "Fonts" );
                    this.ImageKey = "*[Font]*";
                    break;

                case AssetType.Script:
                    AddTag( "Scripts" );
                    this.ImageKey = "*[Script]*";
                    break;

                case AssetType.None:
                    this.ImageKey = "*[NoSprite]*";
                    break;
            }
        }

        #endregion

        #region Methods

        #region Tag-related Methods
        public bool ContainsTag( string tag )
        {
            return _tags.ContainsKey( tag );
        }

        public bool ContainsTag( string[] tags )
        {
            foreach( string tag in tags )
            {
                if( !_tags.ContainsKey( tag ) )
                    return false;
            }
            return true;
        }

        public void AddTag( string tag )
        {
            if( !_tags.ContainsKey( tag ) )
                _tags.Add( tag, false );
        }

        public void RemoveTag( string tag )
        {
            if( _tags.ContainsKey( tag ) )
                _tags.Remove( tag );
        }
        #endregion

        #endregion
    }
}
