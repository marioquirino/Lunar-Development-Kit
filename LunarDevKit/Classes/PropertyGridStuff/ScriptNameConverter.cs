using System;
using System.ComponentModel;

namespace LunarDevKit.Classes.PropertyGridStuff
{
    public class ScriptNameConverter : StringConverter
    {
        public override bool GetStandardValuesSupported( ITypeDescriptorContext context )
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues( ITypeDescriptorContext context )
        {
            return new StandardValuesCollection( Global.AssetsBrowser.ScriptItems.Keys );
        }

        public override bool GetStandardValuesExclusive( ITypeDescriptorContext context )
        {
            return false;
        }
    }
}
