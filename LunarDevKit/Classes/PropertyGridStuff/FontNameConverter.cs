using System;
using System.ComponentModel;

namespace LunarDevKit.Classes.PropertyGridStuff
{
    public class FontNameConverter : StringConverter
    {
        public override bool GetStandardValuesSupported( ITypeDescriptorContext context )
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues( ITypeDescriptorContext context )
        {
            return new StandardValuesCollection( Global.AssetsBrowser.FontItems.Keys );
        }
    }
}
