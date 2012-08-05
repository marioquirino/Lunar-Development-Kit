using System.Collections.Generic;

namespace LunarEngine.Collections
{
    public class KeyPool<TValue> : Dictionary<int, TValue>
    {
        public new void Add( int key, TValue item )
        {
            if( !ContainsKey( key ) )
                base.Add( key, item );
        }
    }
}
