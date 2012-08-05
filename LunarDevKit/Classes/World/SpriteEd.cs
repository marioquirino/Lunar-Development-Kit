using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Controls;

namespace LunarDevKit.Classes
{
    public class SpriteEd : Texture2D
    {
        #region Fields

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private System.Drawing.Bitmap _bitmap;
        public System.Drawing.Bitmap Bitmap
        {
            get { return _bitmap; }
            set { _bitmap = value; }
        }

        private string _name;
        public new string Name
        {
            get { return _name; }
            set
            {
                if( !SpriteAdded )
                {
                    _name = value;
                    return;
                }

                if( string.IsNullOrEmpty( value ) )
                    return;

                if( Global.AssetsBrowser.SpriteItems.ContainsKey( value ) )
                {
                    MessageBox.Show( Global.EditorTxt.SpriteWithSameNameExistsError, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                _name = value;
                string newPath = Helper.ChangeFilePathName( _filePath, _name );
                if( File.Exists( _filePath ) )
                    File.Move( _filePath, newPath );

                _filePath = newPath;
                Global.MainWindow.OnWorldChanged( );
                Global.MainWindow.OnAssetChanged( );
                Global.Properties.UpdateTitle( );

                Parent.LabelName = _name;
            }
        }

        private SpriteProperties _properties;
        public SpriteProperties Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        private SpriteAssetItem _parent;
        public SpriteAssetItem Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }


        public bool SpriteAdded = false;

        #endregion

        #region Constructors

        public SpriteEd( GraphicsDevice graphicsDevice, int width, int height )
            : base( graphicsDevice, width, height )
        {
            _properties.Sprite = this;
        }

        public SpriteEd( GraphicsDevice graphicsDevice, int width, int height, int numberLevels, TextureUsage usage, SurfaceFormat format )
            : base( graphicsDevice, width, height, numberLevels, usage, format )
        {
            _properties.Sprite = this;
        }

        #endregion
    }



    public struct SpriteProperties : IEdObject
    {
        public SpriteEd Sprite;

        [Category( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.SpriteName )]
        public string Name
        {
            get { return Sprite.Name; }
            set { Sprite.Name = value; }
        }
    }
}
