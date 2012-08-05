using System;
using System.Windows.Forms;

namespace LunarDevKit.Controls
{
    using Classes;

    public class LevelTabPage : TabPage
    {
        #region Fields

        private ViewportControl viewport;
        private LevelEd _level;

        #endregion

        #region Properties

        public ViewportControl Viewport
        {
            get { return viewport; }
        }

        public LevelEd Level
        {
            get { return _level; }
        }

        #endregion

        public LevelTabPage( LevelEd level )
        {
            viewport = new ViewportControl( );

            this.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add( viewport );
            viewport.Dock = DockStyle.Fill;

            this.Text = level.Name;
            this._level = level;
        }
    }
}
