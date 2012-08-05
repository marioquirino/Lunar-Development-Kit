using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public partial class ActorAssetItem : AssetItem
    {
        #region Fields

        private ActorTypeEd _actorType;
        [Browsable( false )]
        public ActorTypeEd Actor
        {
            get { return _actorType; }
        }

        [Browsable( false )]
        public new Image AssetThumbnail
        {
            get { return _image.Image; }
        }

        [Category( "_Asset Properties" )]
        public new string AssetName
        {
            get { return _actorType.Name; }
            set
            {
                _actorType.Name = value;
                LabelName = _actorType.Name;
            }
        }

        [Browsable( false )]
        public new string FilePath
        {
            get { return _actorType.FilePath; }
            set { _actorType.FilePath = value; }
        }

        #endregion

        public ActorAssetItem( ActorTypeEd actor )
            : base( )
        {
            InitializeComponent( );

            if( actor.IsTextActor )
                _image.Image = LunarDevKit.Properties.Resources.FontIcon;
            else if( actor.SpriteAsset == Global.AssetsBrowser.NoSpriteItem )
                _image.Image = LunarDevKit.Properties.Resources.NoSprite32;
            else
                _image.ImageLocation = actor.SpriteAsset.FilePath;
            _actorType = actor;
            _actorType.Parent = this;
            _actorType.IsTextActorChanged += new EventHandler( _actorType_IsTextActorChanged );
            _actorType.SpriteChanged += new EventHandler( _actorType_SpriteChanged );
            this.LabelName = actor.Name;
        }

        public void UpdateAssetThumbnail( )
        {
            _image.Image = _actorType.SpriteAsset.AssetThumbnail;
        }

        protected override void DisposeResources( )
        {
            if( _actorType != null )
                _actorType = null;

            if( AssetThumbnail != null )
                AssetThumbnail.Dispose( );

            base.DisposeResources( );
        }




        private void _actorType_IsTextActorChanged( object sender, EventArgs e )
        {
            if( _actorType.IsTextActor )
                _image.Image = LunarDevKit.Properties.Resources.FontIcon;
            else if( Actor.SpriteAsset == Global.AssetsBrowser.NoSpriteItem )
                _image.Image = LunarDevKit.Properties.Resources.NoSprite32;
            else
                _image.ImageLocation = Actor.SpriteAsset.FilePath;
        }

        private void _actorType_SpriteChanged( object sender, EventArgs e )
        {
            if( _actorType.SpriteAsset == Global.AssetsBrowser.NoSpriteItem )
                _image.Image = LunarDevKit.Properties.Resources.NoSprite32;
            else
                _image.ImageLocation = _actorType.SpriteAsset.FilePath;
        }
    }
}
