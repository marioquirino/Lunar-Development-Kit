using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    using Classes;

    public partial class PackageWizardWindow : Form
    {
        private static Point point = new Point( 12, 47 );

        public PackageWizardWindow( )
        {
            InitializeComponent( );

            assetsTree.ImageList = Global.AssetsTreeViewImages;

            createPackageRadio.Checked = true;
            worldAssetsRadio.Enabled = worldAssetsRadio.Checked = ( Global.World != null );
        }

        #region Event Methods

        #region Create Package Group Methods

        private void createPackageRadio_CheckedChanged( object sender, EventArgs e )
        {
            HideAllGroups( );

            AcceptButton = createPackageButton;

            CreatePackageGroup.Location = point;
            CreatePackageGroup.Show( );
        }

        private void packageNameText_TextChanged( object sender, EventArgs e )
        {
            createPackageButton.Enabled = ( packageNameText.Text != string.Empty && packageNameText.Text != "<Package Name>" && worldAssetsRadio.Checked ) ;
        }

        private void worldAssetsRadio_CheckedChanged( object sender, EventArgs e )
        {
            UpdateAssetsTree( );
        }

        private void computerAssetsRadio_CheckedChanged( object sender, EventArgs e )
        {
            browseAssetsButton.Visible = computerAssetsRadio.Checked;
            if ( computerAssetsRadio.Checked )
            {
                //clean the assets tree view
            }
        }

        private void createPackageButton_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you want to create this Package?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
            {
                packageNameText.Text = Helper.CheckLetterDigitInput( packageNameText.Text );
                FileManager.CreatePackageFile( packageNameText.Text, packageDescriptionText.Text, assetsTree );

                packageNameText.Text = "";
                packageDescriptionText.Text = "";
                packageNameText.Focus( );
            }
        }

        #region packageNameText Methods

        private void packageNameText_GotFocus( object sender, EventArgs e )
        {
            if ( packageNameText.Text == "<Package Name>" )
                packageNameText.Text = string.Empty;
        }

        private void packageNameText_LostFocus( object sender, EventArgs e )
        {
            if ( packageNameText.Text == string.Empty )
                packageNameText.Text = "<Package Name>";
        }

        #endregion

        #endregion

        #region Import Package Group Methods

        private void ImportPackageRadio_CheckedChanged( object sender, EventArgs e )
        {
            HideAllGroups( );

            AcceptButton = importPackagesButton;

            ImportPackageGroup.Location = point;
            ImportPackageGroup.Show( );
        }

        #endregion

        #region Lunar Dev Kit Group Methods

        private void availablePackagesRadio_CheckedChanged( object sender, EventArgs e )
        {
            HideAllGroups( );

            packagesList.Items.Clear( );

            foreach( string file in Directory.GetFiles( Consts.Folders.PACKAGES, "*.*", SearchOption.AllDirectories ) )
                if( file.EndsWith( Consts.Files.PACKAGE_EXTENSION ) )
                    packagesList.Items.Add( new ListItem( file ) );

            AcceptButton = importPackagesToWorldButton;

            LunarDevKitPackagesGroup.Location = point;
            LunarDevKitPackagesGroup.Show( );
        }

        private void importPackagesToWorldButton_Click( object sender, EventArgs e )
        {
            foreach ( ListItem item in packagesList.SelectedItems )
                FileManager.ImportPackageToWorld( item.FilePath );

            UpdateAssetsTree( );

            MessageBox.Show( "Package(s) imported successfully!" );
        }

        private void packagesList_SelectedIndexChanged( object sender, EventArgs e )
        {
            importPackagesToWorldButton.Enabled = ( packagesList.SelectedItems.Count > 0 );
        }

        #endregion

        #endregion

        #region Methods

        private void HideAllGroups( )
        {
            CreatePackageGroup.Hide( );
            ImportPackageGroup.Hide( );
            LunarDevKitPackagesGroup.Hide( );
        }

        private void UpdateAssetsTree( )
        {
            assetsTree.Nodes.Clear( );

            if ( worldAssetsRadio.Checked )
            {
                assetsTree.Initialization( );
            }
        }

        #endregion

    }
}
