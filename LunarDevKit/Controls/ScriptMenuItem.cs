using System;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    using Classes;

    public class ScriptMenuItem : ToolStripMenuItem
    {
        public AssetNode ScriptNode;

        #region Constructors

        public ScriptMenuItem( ) : base( ) { }

        public ScriptMenuItem( string text ) : base( text ) { }

        #endregion
    }
}
