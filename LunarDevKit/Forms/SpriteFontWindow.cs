using System;
using System.Windows.Forms;
using LunarDevKit.Classes;

namespace LunarDevKit.Forms
{
    public partial class SpriteFontWindow : Form
    {
        private FontEd _font;
        private bool _changed = false;

        public SpriteFontWindow( FontEd font )
        {
            InitializeComponent( );
            this.Owner = Global.MainWindow;
            _font = font;
        }

        #region Methods

        private bool _Show( )
        {
            if( _font == null )
                return false;

            this.Text = _font.Name;
            _font.Text = System.IO.File.ReadAllText( _font.FilePath );
            _txtScript.Text = _font.Text;

            return true;
        }

        public new void Show( )
        {
            if( _Show( ) )
                base.Show( );
        }

        public new void Show( IWin32Window owner )
        {
            if( _Show( ) )
                base.Show( owner );
        }

        public new void ShowDialog( )
        {
            if( _Show( ) )
                base.ShowDialog( );
        }

        public new void ShowDialog( IWin32Window owner )
        {
            if( _Show( ) )
                base.ShowDialog( owner );
        }

        #endregion

        private void _btnSave_Click( object sender, EventArgs e )
        {
            _font.Text = _txtScript.Text;
            _font.Save( );

            this.Text = _font.Name;
            _changed = false;
        }

        private void _txtScript_TextChanged( object sender, EventArgs e )
        {
            if( !_changed )
            {
                this.Text = _font.Name + "*";
                _changed = true;
            }
        }
    }
}
