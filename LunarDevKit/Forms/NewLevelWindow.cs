using System;
using System.IO;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    using Classes;

    public partial class NewLevelWindow : Form
    {
        LevelEd _level;

        public NewLevelWindow( )
        {
            InitializeComponent( );
            levelNameText.GotFocus += new EventHandler( levelNameText_GotFocus );
            levelNameText.LostFocus += new EventHandler( levelNameText_LostFocus );

            _level = new LevelEd( );
        }


        private void levelNameText_TextChanged( object sender, EventArgs e )
        {
            createButton.Enabled = ( levelNameText.Text != string.Empty && levelNameText.Text != "<Level Name>" );
        }

        void levelNameText_GotFocus( object sender, EventArgs e )
        {
            if ( levelNameText.Text == "<Level Name>" )
                levelNameText.Text = string.Empty;
        }
        void levelNameText_LostFocus( object sender, EventArgs e )
        {
            if ( levelNameText.Text == string.Empty )
                levelNameText.Text = "<Level Name>";
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            _level = null;

            this.Close( );
        }

        private void createButton_Click( object sender, EventArgs e )
        {
            levelNameText.Text = Helper.CheckLetterDigitInput( levelNameText.Text );
            if( Global.World.LevelExists( levelNameText.Text ) )
            {
                MessageBox.Show( Global.EditorTxt.LevelWithSameNameExists, "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                levelNameText.Focus( );
                levelNameText.SelectAll( );
                return;
            }

            string fullPath = Path.Combine( Global.World.LevelsFolderPath, levelNameText.Text + Consts.Files.LEVEL_EXTENSION );
            _level = new LevelEd( );
            _level.FilePath = fullPath;
            _level.Name = levelNameText.Text;
            _level.NewLayer( );

            this.Close( );
        }




        public new LevelEd Show( )
        {
            base.Show( );

            return _level;
        }

        public new LevelEd Show( IWin32Window owner )
        {
            base.Show( owner );

            return _level;
        }

        public new LevelEd ShowDialog( )
        {
            base.ShowDialog( );

            return _level;
        }

        public new LevelEd ShowDialog( IWin32Window owner )
        {
            base.ShowDialog( owner );

            return _level;
        }
    }
}
