using System;
using System.ComponentModel;

namespace LunarDevKit.Classes.PropertyGridStuff
{
    public class SpriteNameConverter : StringConverter
    {
        public override bool GetStandardValuesSupported( ITypeDescriptorContext context )
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues( ITypeDescriptorContext context )
        {
            return new StandardValuesCollection( Global.AssetsBrowser.SpriteItems.Keys );
        }

        public override bool GetStandardValuesExclusive( ITypeDescriptorContext context )
        {
            return false;
        }
    }
}
