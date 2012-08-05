using System;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    using Classes;

    public class SpriteMenuItem : ToolStripMenuItem
    {
        public AssetNode SpriteNode;
        public SpriteAssetItem SpriteItem;

        #region Constructors

        public SpriteMenuItem( ) : base( ) { }

        public SpriteMenuItem( string text ) : base( text ) { }

        #endregion
    }
}
