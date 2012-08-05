using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public partial class FontAssetItem : AssetItem
    {
        #region Fields

        private FontEd _font;
        [Browsable( false )]
        public new FontEd Font
        {
            get { return _font; }
        }

        private Forms.SpriteFontWindow _spriteFontWindow;
        [Browsable( false )]
        public Forms.SpriteFontWindow SpriteFontWindow
        {
            get
            {
                if( _spriteFontWindow == null )
                {
                    _spriteFontWindow = new Forms.SpriteFontWindow( _font );
                    _spriteFontWindow.FormClosed += new System.Windows.Forms.FormClosedEventHandler( _spriteFontWindow_FormClosed );
                }

                return _spriteFontWindow;
            }
        }

        [Browsable( false )]
        public new Image AssetThumbnail
        {
            get { return _image.Image; }
        }

        [Category( "_Asset Properties" )]
        public new string AssetName
        {
            get { return _font.Name; }
            set
            {
                _font.Name = value;
                LabelName = _font.Name;
            }
        }

        [Browsable( false )]
        public new string FilePath
        {
            get { return _font.FilePath; }
            set { _font.FilePath = value; }
        }

        #endregion

        public FontAssetItem( FontEd font )
            : base( )
        {
            InitializeComponent( );
            _image.Image = global::LunarDevKit.Properties.Resources.FontIcon;
            _font = font;
            _font.Parent = this;
            this.LabelName = font.Name;
        }





        private void _spriteFontWindow_FormClosed( object sender, System.Windows.Forms.FormClosedEventArgs e )
        {
            _spriteFontWindow.Dispose( );
            _spriteFontWindow = null;
        }

        protected override void DisposeResources( )
        {
            if( _font != null )
            {
                _font.SpriteFont = null;
                _font = null;
            }

            if( _spriteFontWindow != null )
                _spriteFontWindow.Dispose( );

            if( AssetThumbnail != null )
                AssetThumbnail.Dispose( );

            base.DisposeResources( );
        }
    }
}
