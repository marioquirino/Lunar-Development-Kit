using System;
using System.Windows.Forms;
using System.ComponentModel;
using LunarDevKit.Classes;

namespace LunarDevKit.Controls
{
    public class AssetsTabPage : TabPage
    {
        private AssetType _assetType;
        [Browsable( false )]
        public AssetType AssetType
        {
            get { return _assetType; }
            set { _assetType = value; }
        }
    }
}
