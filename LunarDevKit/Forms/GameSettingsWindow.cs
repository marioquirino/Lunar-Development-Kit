using System;
using System.IO;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    using Classes;

    public partial class GameSettingsWindow : Form
    {
        private World world;
        private string audioProjName = null;

        #region Init

        public GameSettingsWindow( )
        {
            InitializeComponent( );

            world = Global.World;

            InitResolutionsComboBox( );
        }

        private void InitResolutionsComboBox( )
        {
            resolutionsComboBox.Items.Add( new ResolutionItem( 320, 240 ) );
            resolutionsComboBox.Items.Add( new ResolutionItem( 640, 480 ) );
            resolutionsComboBox.Items.Add( new ResolutionItem( 800, 600 ) );
            resolutionsComboBox.Items.Add( new ResolutionItem( 1024, 768 ) );
            resolutionsComboBox.Items.Add( new ResolutionItem( 1280, 1024 ) );
            resolutionsComboBox.Items.Add( new ResolutionItem( 1600, 1200 ) );
        }

        #endregion

        #region Event Methods

        private void GameSettingsWindow_Load( object sender, EventArgs e )
        {
            this.Text = world.Name + " Settings";
            this.gameTitleText.Text = world.GameSettings.Title;
            this.fullscreenCheck.Checked = world.GameSettings.Fullscreen;
            this.exitsWithEscCheck.Checked = world.GameSettings.EndWithEsc;
            this.widthUpDown.Value = world.GameSettings.Width;
            this.heightUpDown.Value = world.GameSettings.Height;

            RefreshScriptList( );

            if( string.IsNullOrEmpty( world.AudioProjectName ) )
                _lblAudio.Text = "Audio : <No audio project assigned>";
            else
                _lblAudio.Text = "Audio : " + world.AudioProjectName;
        }

        private void resolutionsComboBox_SelectionChangeCommitted( object sender, EventArgs e )
        {
            ResolutionItem item = (ResolutionItem)resolutionsComboBox.SelectedItem;
            widthUpDown.Value = item.Width;
            heightUpDown.Value = item.Height;
        }

        private void _btnAssignAudio_Click( object sender, EventArgs e )
        {
            using( OpenFileDialog fileDialog = new OpenFileDialog( ) )
            {
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Filter = "XACT Project Files (*.xap)|*.xap";
                fileDialog.Multiselect = false;
                if( fileDialog.ShowDialog( ) != DialogResult.Cancel )
                {
                    if( !Directory.Exists( world.AssetsFolderPath ) )
                        Directory.CreateDirectory( world.AssetsFolderPath );

                    string newpath = Path.Combine( world.AssetsFolderPath, Path.GetFileName( fileDialog.FileName ) );
                    if( File.Exists( newpath ) )
                        File.Delete( newpath );
                    File.Copy( fileDialog.FileName, newpath );
                    audioProjName = Path.GetFileNameWithoutExtension( fileDialog.FileName );
                    _lblAudio.Text = "Audio: " + audioProjName;
                }
            }
        }

        private void _comboScriptList_SelectedIndexChanged( object sender, EventArgs e )
        {
            _btnNewGameScript.Enabled = ( _comboScriptList.SelectedIndex == 0 );
        }

        private void _btnNewGameScript_Click( object sender, EventArgs e )
        {
            Global.AssetsBrowser.AddNewScript( Global.World.Name, ScriptFormat.Game );
            RefreshScriptList( );

            for( int i = 0; i < _comboScriptList.Items.Count; i++ )
            {
                if( ( (ScriptItem)_comboScriptList.Items[i] ).Script == Global.AssetsBrowser.LastCreatedScript.Script )
                {
                    _comboScriptList.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        private void saveButton_Click( object sender, EventArgs e )
        {
            world.GameSettings.Title = gameTitleText.Text;
            world.GameSettings.EndWithEsc = exitsWithEscCheck.Checked;
            world.GameSettings.Fullscreen = fullscreenCheck.Checked;
            world.GameSettings.Width = (int)widthUpDown.Value;
            world.GameSettings.Height = (int)heightUpDown.Value;
            world.Script = ((ScriptItem)_comboScriptList.Items[_comboScriptList.SelectedIndex]).Script;
            world.AudioProjectName = audioProjName;

            this.Close( );

            Global.MainWindow.SaveWorld( );
        }

        #endregion

        #region methods

        private void RefreshScriptList( )
        {
            _comboScriptList.Items.Clear( );
            _comboScriptList.Items.Add( new ScriptItem( null ) );

            foreach( Controls.ScriptAssetItem scriptAsset in Global.AssetsBrowser.ScriptItems.Values )
            {
                ScriptItem scriptItem = new ScriptItem( scriptAsset.Script );
                _comboScriptList.Items.Add( scriptItem );
                if( world.Script == scriptAsset.Script )
                    _comboScriptList.SelectedItem = scriptItem;
            }

            if( _comboScriptList.SelectedIndex == -1 )
                _comboScriptList.SelectedIndex = 0;
        }

        #endregion
    }
}
