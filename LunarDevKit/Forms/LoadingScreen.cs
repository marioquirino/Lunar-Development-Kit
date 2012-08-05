using System;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen( )
        {
            InitializeComponent( );
            progressBar1.Value = 100;
        }

        private void timer_Tick( object sender, EventArgs e )
        {
            //this.Close( );
            opacityTimer.Enabled = true;
        }

        private void opacityTimer_Tick( object sender, EventArgs e )
        {
            this.Opacity -= 0.03;
            if ( this.Opacity <= 0.0 )
                this.Close( );
        }
    }
}
