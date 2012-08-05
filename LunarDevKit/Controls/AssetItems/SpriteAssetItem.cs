using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public partial class SpriteAssetItem : AssetItem
    {
        #region Fields

        private SpriteEd _sprite;
        [Browsable( false )]
        public SpriteEd Sprite
        {
            get { return _sprite; }
        }

        [Browsable( false )]
        public new Image AssetThumbnail
        {
            get { return _image.Image; }
            set { _image.ImageLocation = this.FilePath; }
        }

        [Browsable( false )]
        public new string FilePath
        {
            get { return _sprite.FilePath; }
            set { _sprite.FilePath = value; }
            //get { return _filePath; }
            //set
            //{
            //    if( _filePath == value )
            //        return;

            //    if( !string.IsNullOrEmpty( _filePath ) && File.Exists( _filePath ) && !string.IsNullOrEmpty( value ) )
            //    {
            //        File.Move( _filePath, value );
            //    }

            //    _filePath = value;
            //}
        }

        [Category( "_Asset Properties" )]
        public new string AssetName
        {
            get { return _sprite.Name; }
            set
            {
                _sprite.Name = value;
                LabelName = _sprite.Name;
            }
            //get { return _label.Text; }
            //set
            //{
            //    _label.Text = value;
            //    if( !Global.DesignMode && !string.IsNullOrEmpty( _filePath ) )
            //    {
            //        FilePath = Path.Combine( Path.GetDirectoryName( _filePath ), _label.Text + Path.GetExtension( _filePath ) );
            //    }
            //}
        }

        #endregion

        public SpriteAssetItem( SpriteEd sprite )
            : base( )
        {
            InitializeComponent( );
            if( File.Exists( sprite.FilePath ) )
                _image.ImageLocation = sprite.FilePath;
            else
                _image.Image = global::LunarDevKit.Properties.Resources.CharIcn;
            this._sprite = sprite;
            _sprite.Parent = this;
            //this._filePath = sprite.FilePath;
        }

        protected override void DisposeResources( )
        {
            if( _sprite != null )
                _sprite.Dispose( );

            if( AssetThumbnail != null )
                AssetThumbnail.Dispose( );

            base.DisposeResources( );
        }
    }
}
