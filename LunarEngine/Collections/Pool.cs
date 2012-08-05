using System.Collections.Generic;

namespace LunarEngine.Collections
{
    public class Pool<T> : List<T>
    {
        public new void Add( T item )
        {
            if( !Contains( item ) )
                base.Add( item );
        }
    }
}
