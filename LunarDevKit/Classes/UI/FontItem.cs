using System;
using LunarDevKit.Controls;

namespace LunarDevKit.Classes
{
    public struct FontItem
    {
        public FontAssetItem FontAsset;

        public FontItem( FontAssetItem fontAsset )
        {
            this.FontAsset = fontAsset;
        }

        public override string ToString( )
        {
            if( FontAsset == null )
                return "<No Font Assigned>";

            return FontAsset.AssetName;
        }
    }
}
