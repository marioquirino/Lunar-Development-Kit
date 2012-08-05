using System;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    using Classes;
    using Controls;

    public partial class NewScriptWindow : Form
    {
        private Script _script;

        public NewScriptWindow( )
        {
            InitializeComponent( );

            _txtScriptName.LostFocus += new EventHandler( scriptNameText_LostFocus );
            _txtScriptName.GotFocus += new EventHandler( scriptNameText_GotFocus );

            _script = new Script( );
        }

        private void scriptNameText_GotFocus( object sender, EventArgs e )
        {
            if( _txtScriptName.Text == "<Script Name>" )
                _txtScriptName.Text = string.Empty;
        }

        private void scriptNameText_LostFocus( object sender, EventArgs e )
        {
            if( _txtScriptName.Text == string.Empty )
                _txtScriptName.Text = "<Script Name>";
        }

        private void scriptNameText_TextChanged( object sender, EventArgs e )
        {
            _btnCreate.Enabled = ( _txtScriptName.Text != string.Empty && _txtScriptName.Text != "<Script Name>" );
        }

        private void createButton_Click( object sender, EventArgs e )
        {
            if( Global.AssetsBrowser.ScriptItems.ContainsKey( _txtScriptName.Text ) )
            {
                MessageBox.Show( "This name is already being used by another script!", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                _txtScriptName.Focus( );
                _txtScriptName.SelectAll( );
                return;
            }

            _script.Name = _txtScriptName.Text;
            if( _radioLunarGUI.Checked )
                _script.ScriptType = ScriptType.Visual;
            else
                _script.ScriptType = ScriptType.CSharp;

            this.Close( );
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            _script = null;

            this.Close( );
        }

        public new Script Show( )
        {
            base.Show( );

            return _script;
        }

        public new Script Show( IWin32Window owner )
        {
            base.Show( owner );

            return _script;
        }

        public new Script ShowDialog( )
        {
            base.ShowDialog( );

            return _script;
        }

        public new Script ShowDialog( IWin32Window owner )
        {
            base.ShowDialog( owner );

            return _script;
        }
    }
}
