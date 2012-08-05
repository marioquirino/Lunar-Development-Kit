using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Xna.Framework.Graphics;
using LunarDevKit.Controls;

namespace LunarDevKit.Classes
{
    public class FontEd
    {
        private SpriteFont _font;
        public SpriteFont SpriteFont
        {
            get { return _font; }
            set { _font = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if( !FontAdded )
                {
                    _name = value;
                    return;
                }

                if( string.IsNullOrEmpty( value ) )
                    return;

                if( Global.AssetsBrowser.FontItems.ContainsKey( value ) )
                {
                    MessageBox.Show( Global.EditorTxt.FontWithSameNameExistsError, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
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

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private FontAssetItem _parent;
        public FontAssetItem Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private FontProperties _properties;
        public FontProperties Properties
        {
            get { return _properties; }
        }


        public bool FontAdded = false;



        public FontEd( )
        {
            _properties.Font = this;
        }

        public bool Save( )
        {
            FileManager.CreateFontFile( this );
            _font = Global.MainWindow.LoadFont( _filePath );
            return ( _font != null );
        }
    }



    public struct FontProperties : IEdObject
    {
        public FontEd Font;

        [CategoryAttribute( Consts.PropsDescriptions.CategoryMain ),
        Description( Consts.PropsDescriptions.FontName )]
        public string Name
        {
            get { return Font.Name; }
            set { Font.Name = value; }
        }
    }
}
