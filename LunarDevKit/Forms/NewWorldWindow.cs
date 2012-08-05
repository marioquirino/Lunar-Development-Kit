using System;
using System.IO;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    using Classes;

    public partial class NewWorldWindow : Form
    {
        #region Fields

        static string FullPath = @"C:\";

        private World _world;

        #endregion

        public NewWorldWindow( )
        {
            InitializeComponent( );

            locationText.Text = Consts.Folders.LUNAR_PROJECTS_PATH;
            fullPathLabel.Text = "";
        }

        #region Event Methods

        private void browseButton_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog( );
            if ( folderBrowser.ShowDialog( ) == DialogResult.OK )
                locationText.Text = folderBrowser.SelectedPath;
        }

        private void createButton_Click( object sender, EventArgs e )
        {
            if ( !Directory.Exists( locationText.Text ) )
            {
                Global.DisplayMessage( Global.EditorTxt.InvalidLocationPath, 1.5f );
                locationText.Focus( );
                return;
            }

            worldNameText.Text = Helper.CheckLetterDigitInput( worldNameText.Text );

            try
            {
                if( Directory.Exists( FullPath ) )
                {
                    if( MessageBox.Show( "A project with the same name already exists! Do you wish to overwrite it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                        Directory.Delete( FullPath, true );
                    else
                        return;
                }

                _world = new World( );
                _world.FilePath = FullPath = Path.Combine( FullPath, worldNameText.Text + Consts.Files.PROJECT_EXTENSION );
                _world.Name = worldNameText.Text;
            }
            catch( Exception ex )
            {
                ErrorReport.Throw( ex );
                _world = null;
                this.Close( );
                return;
            }

            this.Close( );
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            _world = null;

            this.Close( );
        }

        #region worldNameText Methods

        private void worldNameText_TextChanged( object sender, EventArgs e )
        {
            try
            {
                if( worldNameText.Text == "" || worldNameText.Text == "<World Name>" || locationText.Text == "" )
                {
                    createButton.Enabled = false;
                    fullPathLabel.Text = "Full Path:";
                }
                else
                {
                    createButton.Enabled = true;

                    FullPath = Path.Combine( locationText.Text, worldNameText.Text );
                    fullPathLabel.Text = FullPath;
                }
            }
            catch
            { }
        }

        private void worldNameText_GotFocus( object sender, EventArgs e )
        {
            if ( worldNameText.Text == "<World Name>" )
                worldNameText.Text = string.Empty;
        }

        private void worldNameText_LostFocus( object sender, EventArgs e )
        {
            if ( worldNameText.Text == string.Empty )
                worldNameText.Text = "<World Name>";
        }

        #endregion

        #region locationText Methods

        private void locationText_DoubleClick( object sender, EventArgs e )
        {
            browseButton_Click( sender, e );
        }

        #endregion

        #endregion


        public new World Show( )
        {
            base.Show( );

            return _world;
        }

        public new World Show( IWin32Window owner )
        {
            base.Show( owner );

            return _world;
        }

        public new World ShowDialog( )
        {
            base.ShowDialog( );

            return _world;
        }

        public new World ShowDialog( IWin32Window owner )
        {
            base.ShowDialog( owner );

            return _world;
        }
    }
}