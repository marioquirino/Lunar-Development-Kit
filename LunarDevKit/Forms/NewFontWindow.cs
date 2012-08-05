using System;
using System.Windows.Forms;

namespace LunarDevKit.Forms
{
    using Classes;
    using Controls;

    public partial class NewFontWindow : Form
    {
        private FontEd _font;

        public NewFontWindow( )
        {
            InitializeComponent( );

            _txtFontName.LostFocus += new EventHandler( _txtFontName_LostFocus );
            _txtFontName.GotFocus += new EventHandler( _txtFontName_GotFocus );

            _font = new FontEd( );
        }

        private void _txtFontName_GotFocus( object sender, EventArgs e )
        {
            if( _txtFontName.Text == "<Font Name>" )
                _txtFontName.Text = string.Empty;
        }

        private void _txtFontName_LostFocus( object sender, EventArgs e )
        {
            if( _txtFontName.Text == string.Empty )
                _txtFontName.Text = "<Font Name>";
        }

        private void _txtFontName_TextChanged( object sender, EventArgs e )
        {
            _btnCreate.Enabled = (_txtFontName.Text != string.Empty && _txtFontName.Text != "<Font Name>");
        }

        private void createButton_Click( object sender, EventArgs e )
        {
            if( Global.AssetsBrowser.FontItems.ContainsKey( _txtFontName.Text ) )
            {
                MessageBox.Show( "This name is already being used by another font!", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                _txtFontName.Focus( );
                _txtFontName.SelectAll( );
                return;
            }

            _font.Name = _txtFontName.Text;
            _font.Text = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                         "<XnaContent xmlns:Graphics=\"Microsoft.Xna.Framework.Content.Pipeline.Graphics\">\n" +
	                     "\t<Asset Type=\"Graphics:FontDescription\">\n" +
                         "\t\t<FontName>"+_font.Name+"</FontName>\n" +
		                 "\t\t<Size>14</Size>\n" +
		                 "\t\t<Spacing>0</Spacing>\n" +
		                 "\t\t<UseKerning>true</UseKerning>\n" +
		                 "\t\t<Style>Regular</Style>\n" +
		                 "\t\t<CharacterRegions>\n" +
			             "\t\t\t<CharacterRegion>\n" +
				         "\t\t\t\t<Start>&#32;</Start>\n" +
				         "\t\t\t\t<End>&#126;</End>\n" +
			             "\t\t\t</CharacterRegion>\n" +
		                 "\t\t</CharacterRegions>\n" +
	                     "\t</Asset>\n" +
                         "</XnaContent>";

            this.Close( );
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            _font = null;

            this.Close( );
        }

        public new FontEd Show( )
        {
            base.Show( );

            return _font;
        }

        public new FontEd Show( IWin32Window owner )
        {
            base.Show( owner );

            return _font;
        }

        public new FontEd ShowDialog( )
        {
            base.ShowDialog( );

            return _font;
        }

        public new FontEd ShowDialog( IWin32Window owner )
        {
            base.ShowDialog( owner );

            return _font;
        }
    }
}
