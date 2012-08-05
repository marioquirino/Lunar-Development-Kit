using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public partial class ScriptAssetItem : AssetItem
    {
        #region Fields

        private Script _script;
        [Browsable( false )]
        public Script Script
        {
            get { return _script; }
        }

        [Browsable( false )]
        public new Image AssetThumbnail
        {
            get { return _image.Image; }
        }

        [Category( "_Asset Properties" )]
        public new string AssetName
        {
            get { return _script.Name; }
            set
            {
                _script.Name = value;
                LabelName = _script.Name;
            }
        }

        [Browsable( false )]
        public new string FilePath
        {
            get { return _script.FilePath; }
            set { _script.FilePath = value; }
        }

        #endregion

        public ScriptAssetItem( Script script )
            : base( )
        {
            InitializeComponent( );
            _image.Image = global::LunarDevKit.Properties.Resources.buttonscrpt2;
            _script = script;
            _script.Parent = this;
            this.LabelName = script.Name;
        }



        protected override void DisposeResources( )
        {
            if( _script != null )
                _script = null;

            if( AssetThumbnail != null )
                AssetThumbnail.Dispose( );

            base.DisposeResources( );
        }
    }
}
