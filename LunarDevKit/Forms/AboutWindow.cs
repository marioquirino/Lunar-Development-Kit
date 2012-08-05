using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    public partial class AboutWindow : Form
    {
        public AboutWindow( )
        {
            InitializeComponent( );

            this.Owner = Global.MainWindow;
        }

        private void AboutWindow_MouseClick( object sender, MouseEventArgs e )
        {
            this.Close( );
        }

        private void AboutWindow_KeyPress( object sender, KeyPressEventArgs e )
        {
            this.Close( );
        }
    }
}
