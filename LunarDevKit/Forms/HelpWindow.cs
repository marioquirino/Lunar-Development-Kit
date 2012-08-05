using System;
using System.Windows.Forms;
using System.Drawing;

namespace LunarDevKit.Forms
{
    public partial class HelpWindow : Form
    {
        Point point;

        public HelpWindow( )
        {
            InitializeComponent( );
            Owner = Global.MainWindow;

            point = WorldGroup.Location;
            worldsRadio.Checked = true;
            Radios_Click( worldsRadio, null );
            worldsRadio.Focus( );
        }

        private void HelpWindow_FormClosing( object sender, FormClosingEventArgs e )
        {
            e.Cancel = true;
            Hide( );
        }

        private void Radios_Click( object sender, EventArgs e )
        {
            RadioButton radio = sender as RadioButton;

            HideAllGroups( );

            if ( radio == worldsRadio )
            {
                WorldGroup.Location = point;
                WorldGroup.Show( );
                return;
            }
            if ( radio == levelsRadio )
            {
                LevelsGroup.Location = point;
                LevelsGroup.Show( );
                return;
            }
            if ( radio == assetsRadio )
            {
                AssetsBrowserGroup.Location = point;
                AssetsBrowserGroup.Show( );
                return;
            }
            if ( radio == viewportRadio )
            {
                ViewportGroup.Location = point;
                ViewportGroup.Show( );
                return;
            }
            if ( radio == packagesRadio )
            {
                PackageWizardGroup.Location = point;
                PackageWizardGroup.Show( );
                return;
            }
        }

        private void HideAllGroups( )
        {
            WorldGroup.Hide( );
            LevelsGroup.Hide( );
            AssetsBrowserGroup.Hide( );
            ViewportGroup.Hide( );
            PackageWizardGroup.Hide( );
        }
    }
}
