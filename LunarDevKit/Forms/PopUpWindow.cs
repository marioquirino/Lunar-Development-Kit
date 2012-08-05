using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace LunarDevKit.Forms
{
    public partial class PopUpWindow : Form
    {
        private bool close = false;
        private float maxFadeTime = 0.5f;
        private float value;



        public PopUpWindow( Form owner )
        {
            InitializeComponent( );

            this.Owner = owner;
        }

        public void Display( string message, float duration )
        {
            Reset( );
            label1.Text = message;
            value = timer.Interval / 1000f / maxFadeTime;

            delayTimer.Interval = (int)( duration * 1000 );
            delayTimer.Start( );

            this.Show( );
        }

        public void Display( string message )
        {
            Display( message, 1f );
        }

        private void Reset( )
        {
            close = false;
            Opacity = 1f;
            delayTimer.Stop( );
            timer.Stop( );
        }

        private void delayTimer_Tick( object sender, EventArgs e )
        {
            Close( );
            delayTimer.Enabled = false;
        }

        private void timer_Tick( object sender, EventArgs e )
        {
            this.Opacity -= value;
            if( this.Opacity <= 0 )
            {
                timer.Stop( );
                close = true;
                Close( );
            }
        }

        private void PopUpWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            if( !close )
            {
                e.Cancel = true;
                timer.Start( );
            }
            else
            {
                e.Cancel = true;
                Hide( );
            }
        }
    }
}
