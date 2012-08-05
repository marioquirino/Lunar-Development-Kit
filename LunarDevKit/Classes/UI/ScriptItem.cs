using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunarDevKit.Classes
{
    public struct ScriptItem
    {
        public Script Script;

        public ScriptItem( Script script )
        {
            this.Script = script;
        }

        public override string ToString( )
        {
            if( Script == null )
                return "<No Script Assigned>";

            return Script.Name;
        }
    }
}
