using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LunarDevKit.Classes;
using LunarDevKit.Classes.Collections;

namespace LunarDevKit.Controls
{
    public partial class AssetsGroup : CollapsibleGroup
    {
        #region Fields

        private AssetsPool _assets;
        private Font _prevFont;


        private string _folderPath;
        [Browsable( false )]
        public string FolderPath
        {
            get { return _folderPath; }
            set
            {
                if( _folderPath == value )
                    return;

                if( !string.IsNullOrEmpty( _folderPath ) && Directory.Exists( _folderPath ) && !string.IsNullOrEmpty( value ) )
                    Directory.Move( _folderPath, value );
                
                _folderPath = value;

                foreach( AssetItem asset in _assets )
                {
                    asset.FilePath = Path.Combine( _folderPath, Path.GetFileName( asset.FilePath ) );
                }

            }
        }

        private bool _isSelected = false;
        [Browsable( false )]
        public bool IsSelected
        {
            get { return _isSelected; }
        }

        private AssetType _assetType;
        [Browsable( false )]
        public AssetType AssetType
        {
            get { return _assetType; }
        }

        [Obsolete( "Using Controls directly to add and remove objects cause errors, so use the pre-defined methods instead!" )]
        public new ControlCollection Controls
        {
            get { return null; }
        }

        #endregion

        public AssetsGroup( AssetType assetType )
        {
            InitializeComponent( );

            _assets = new AssetsPool( );
            _assetType = assetType;
        }

        #region Methods

        public void SelectMe( )
        {
            this.TitleColor = Color.White;
            _prevFont = this.TitleFont;
            this.TitleFont = new Font( this.TitleFont, FontStyle.Bold );
        }

        public void DeselectMe( )
        {
            this.TitleColor = Color.LightGray;
            this.TitleFont.Dispose( );
            this.TitleFont = _prevFont;
        }


        public void AddAsset( AssetItem asset )
        {
            _assets.Add( asset );
            base.AddControl( asset );
        }

        public void RemoveAsset( AssetItem asset )
        {
            _assets.Remove( asset );
            base.Controls.Remove( asset );
        }

        public AssetItem FindAsset( string name )
        {
            foreach( AssetItem asset in _assets )
            {
                if( asset.AssetName.Contains( name ) )
                    return asset;
            }
            return null;
        }

        [Obsolete( "Use the AddAsset method instead" )]
        public new void AddControl( Control control ) { }

        #endregion
    }
}
