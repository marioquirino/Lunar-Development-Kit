using System;
using System.Windows.Forms;

namespace LunarDevKit.Classes
{
    public class LayerItem
    {
        public LayerEd Layer;

        public LayerItem( LayerEd layer )
        {
            this.Layer = layer;
        }

        public override string ToString( )
        {
            return Layer.Name;
        }
    }
}
