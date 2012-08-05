using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunarDevKit.Classes
{
    public struct ResolutionItem
    {
        public int Width;
        public int Height;

        public ResolutionItem( int Width, int Height )
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override string ToString( )
        {
            return Width + " x " + Height;
        }
    }
}
