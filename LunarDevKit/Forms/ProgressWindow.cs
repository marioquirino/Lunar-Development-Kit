using System;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    public partial class ProgressWindow : Form
    {

        #region Constructors

        public ProgressWindow( Form owner, string title, int minValue, int maxValue )
        {
            InitializeComponent( );

            this.Owner = owner;
            Text = title;
            progressBar.Minimum = minValue;
            progressBar.Maximum = maxValue;

            Show( );
        }
        public ProgressWindow( Form owner, string title, int maxValue )
            : this( owner, title, 0, maxValue ) { }
        public ProgressWindow( Form owner, string title )
            : this( owner, title, 0, 100 ) { }

        #endregion

        #region Methods

        public void SetMessage( string message )
        {
            messageLabel.Text = message;
        }

        public void Step( int amount )
        {
            if( progressBar.Value + amount > progressBar.Maximum )
                progressBar.Value = progressBar.Maximum;
            else
                progressBar.Value += amount;
        }
        public void Step( )
        {
            Step( 1 );
        }

        public new void Close( )
        {
            shutdownTimer.Enabled = true;
        }

        #endregion

        private void shutdownTimer_Tick( object sender, EventArgs e )
        {
            base.Close( );
        }
    }
}
