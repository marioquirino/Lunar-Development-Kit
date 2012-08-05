using System;
using System.Collections.Generic;
using System.Text;

namespace LunarEngine.Collections
{
    public class StringKeyPool<TValue> : Dictionary<string, TValue>
    {
        public new void Add( string key, TValue item )
        {
            if( !ContainsKey( key ) )
                base.Add( key, item );
        }

        public new void Remove( string key )
        {
            if( ContainsKey( key ) )
                base.Remove( key );
        }
    }
}
